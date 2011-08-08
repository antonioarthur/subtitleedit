﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Nikse.SubtitleEdit.Logic.SubtitleFormats
{
    class YouTubeAnnotations : SubtitleFormat
    {
        public override string Extension
        {
            get { return ".xml"; }
        }

        public override string Name
        {
            get { return "YouTube Annotations"; }
        }

        public override bool HasLineNumber
        {
            get { return false; }
        }

        public override bool IsTimeBased
        {
            get { return true; }
        }

        public override bool IsMine(List<string> lines, string fileName)
        {
            var subtitle = new Subtitle();
            LoadSubtitle(subtitle, lines, fileName);
            return subtitle.Paragraphs.Count > 0;
        }

        public override string ToText(Subtitle subtitle, string title)
        {
            string xmlStructure =
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<document>" + Environment.NewLine +
                "   <requestheader video_id=\"X\"/>" + Environment.NewLine +
                "  <annotations/>" + Environment.NewLine +
                "</document>";

            var xml = new XmlDocument();
            xml.LoadXml(xmlStructure);

            XmlNode annotations = xml.DocumentElement.SelectSingleNode("annotations");

            int count = 1;
            foreach (Paragraph p in subtitle.Paragraphs)
            {
                //<annotation id="annotation_126995" author="StopFear" type="text" style="speech">
                //  <TEXT>BUT now something inside is BROKEN!</TEXT>
                //  <segment>
                //    <movingRegion type="anchored">
                //      <anchoredRegion x="6.005" y="9.231" w="26.328" h="18.154" sx="40.647" sy="14.462" t="0:01:08.0" d="0"/>
                //      <anchoredRegion x="6.005" y="9.231" w="26.328" h="18.154" sx="40.647" sy="14.462" t="0:01:13.0" d="0"/>
                //    </movingRegion>
                //  </segment>
                //</annotation>

                XmlNode annotation = xml.CreateElement("annotation");

                XmlAttribute att = xml.CreateAttribute("id");
                att.InnerText = "annotation_" + count;
                annotation.Attributes.Append(att);

                att = xml.CreateAttribute("author");
                att.InnerText = "Subtitle Edit";
                annotation.Attributes.Append(att);

                att = xml.CreateAttribute("type");
                att.InnerText = "text";
                annotation.Attributes.Append(att);

                att = xml.CreateAttribute("style");
                att.InnerText = "speech";
                annotation.Attributes.Append(att);

                XmlNode text = xml.CreateElement("TEXT");
                text.InnerText = p.Text;
                annotation.AppendChild(text);

                XmlNode segment = xml.CreateElement("segment");
                annotation.AppendChild(segment);

                XmlNode movingRegion = xml.CreateElement("movingRegion");
                segment.AppendChild(movingRegion);

                att = xml.CreateAttribute("type");
                att.InnerText = "anchored";
                movingRegion.Attributes.Append(att);

                XmlNode anchoredRegion = xml.CreateElement("anchoredRegion");
                movingRegion.AppendChild(anchoredRegion);
                att = xml.CreateAttribute("t");
                att.InnerText = EncodeTime(p.StartTime);
                anchoredRegion.Attributes.Append(att);
                att = xml.CreateAttribute("d");
                att.InnerText = "0";
                anchoredRegion.Attributes.Append(att);

                anchoredRegion = xml.CreateElement("anchoredRegion");
                movingRegion.AppendChild(anchoredRegion);
                att = xml.CreateAttribute("t");
                att.InnerText = EncodeTime(p.EndTime);
                anchoredRegion.Attributes.Append(att);
                att = xml.CreateAttribute("d");
                att.InnerText = "0";
                anchoredRegion.Attributes.Append(att);

                annotations.AppendChild(annotation);
                count++;
            }

            var ms = new MemoryStream();
            var writer = new XmlTextWriter(ms, Encoding.UTF8) { Formatting = Formatting.Indented };
            xml.Save(writer);

            string returnXml = Encoding.UTF8.GetString(ms.ToArray()).Trim();
            return returnXml;
        }

        public override void LoadSubtitle(Subtitle subtitle, List<string> lines, string fileName)
        {
            _errorCount = 0;

            var sb = new StringBuilder();
            lines.ForEach(line => sb.AppendLine(line));
            if (!sb.ToString().Contains("</annotations>") || !sb.ToString().Contains("</TEXT>"))
                return;
            var xml = new XmlDocument();
            try
            {
                string xmlText = sb.ToString();
                xml.LoadXml(xmlText);

                foreach (XmlNode node in xml.SelectNodes("//annotation"))
                {
                    try
                    {
                        XmlNode textNode = node.SelectSingleNode("TEXT");
                        XmlNodeList anchoredRegions = node.SelectNodes("segment/movingRegion/anchoredRegion");

                        if (textNode != null && anchoredRegions.Count == 2)
                        {
                            string startTime = anchoredRegions[0].Attributes["t"].Value;
                            string endTime = anchoredRegions[1].Attributes["t"].Value;
                            var p = new Paragraph();
                            p.StartTime = DecodeTimeCode(startTime);
                            p.EndTime = DecodeTimeCode(endTime);
                            p.Text = textNode.InnerText;
                            subtitle.Paragraphs.Add(p);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        _errorCount++;
                    }
                }
                subtitle.Sort(Enums.SubtitleSortCriteria.StartTime); // force order by start time
                subtitle.Renumber(1);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                _errorCount = 1;
                return;
            }
        }

        private TimeCode DecodeTimeCode(string time)
        {
            string[] arr = time.Split(".:".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int hours = int.Parse(arr[0]);
            int minutes = int.Parse(arr[1]);
            int seconds = int.Parse(arr[2]);
            int milliseconds = int.Parse(arr[3]);
            TimeSpan ts = new TimeSpan(0, hours, minutes, seconds, milliseconds);
            return new TimeCode(ts);
        }

        private string EncodeTime(TimeCode timeCode)
        {
            //0:01:08.0
            return string.Format("{0}:{1:00}:{2:00}.{3}", timeCode.Hours, timeCode.Minutes, timeCode.Seconds, timeCode.Milliseconds);
        }

    }
}


