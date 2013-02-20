﻿namespace Nikse.SubtitleEdit.Forms
{
    partial class BatchConvert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxConvertOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxFixCommonErrors = new System.Windows.Forms.CheckBox();
            this.buttonFixCommonErrorSettings = new System.Windows.Forms.Button();
            this.groupBoxChangeFrameRate = new System.Windows.Forms.GroupBox();
            this.comboBoxFrameRateTo = new System.Windows.Forms.ComboBox();
            this.labelToFrameRate = new System.Windows.Forms.Label();
            this.comboBoxFrameRateFrom = new System.Windows.Forms.ComboBox();
            this.labelFromFrameRate = new System.Windows.Forms.Label();
            this.groupBoxOffsetTimeCodes = new System.Windows.Forms.GroupBox();
            this.timeUpDownAdjust = new Nikse.SubtitleEdit.Controls.TimeUpDown();
            this.labelHoursMinSecsMilliSecs = new System.Windows.Forms.Label();
            this.checkBoxFixCasing = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveTextForHI = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveFormatting = new System.Windows.Forms.CheckBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.linkLabelOpenOutputFolder = new System.Windows.Forms.LinkLabel();
            this.buttonStyles = new System.Windows.Forms.Button();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.comboBoxSubtitleFormats = new System.Windows.Forms.ComboBox();
            this.labelEncoding = new System.Windows.Forms.Label();
            this.comboBoxEncoding = new System.Windows.Forms.ComboBox();
            this.labelOutputFormat = new System.Windows.Forms.Label();
            this.labelChooseOutputFolder = new System.Windows.Forms.Label();
            this.buttonChooseFolder = new System.Windows.Forms.Button();
            this.textBoxOutputFolder = new System.Windows.Forms.TextBox();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.buttonInputBrowse = new System.Windows.Forms.Button();
            this.labelChooseInputFiles = new System.Windows.Forms.Label();
            this.listViewInputFiles = new System.Windows.Forms.ListView();
            this.columnHeaderFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxConvertOptions.SuspendLayout();
            this.groupBoxChangeFrameRate.SuspendLayout();
            this.groupBoxOffsetTimeCodes.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.contextMenuStripFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConvert
            // 
            this.buttonConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvert.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonConvert.Location = new System.Drawing.Point(857, 547);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(98, 21);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "&Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(961, 547);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Done";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxConvertOptions
            // 
            this.groupBoxConvertOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConvertOptions.Controls.Add(this.checkBoxFixCommonErrors);
            this.groupBoxConvertOptions.Controls.Add(this.buttonFixCommonErrorSettings);
            this.groupBoxConvertOptions.Controls.Add(this.groupBoxChangeFrameRate);
            this.groupBoxConvertOptions.Controls.Add(this.groupBoxOffsetTimeCodes);
            this.groupBoxConvertOptions.Controls.Add(this.checkBoxFixCasing);
            this.groupBoxConvertOptions.Controls.Add(this.checkBoxRemoveTextForHI);
            this.groupBoxConvertOptions.Controls.Add(this.checkBoxRemoveFormatting);
            this.groupBoxConvertOptions.Location = new System.Drawing.Point(494, 19);
            this.groupBoxConvertOptions.Name = "groupBoxConvertOptions";
            this.groupBoxConvertOptions.Size = new System.Drawing.Size(524, 193);
            this.groupBoxConvertOptions.TabIndex = 10;
            this.groupBoxConvertOptions.TabStop = false;
            this.groupBoxConvertOptions.Text = "Convert options";
            // 
            // checkBoxFixCommonErrors
            // 
            this.checkBoxFixCommonErrors.AutoSize = true;
            this.checkBoxFixCommonErrors.Location = new System.Drawing.Point(16, 91);
            this.checkBoxFixCommonErrors.Name = "checkBoxFixCommonErrors";
            this.checkBoxFixCommonErrors.Size = new System.Drawing.Size(111, 17);
            this.checkBoxFixCommonErrors.TabIndex = 3;
            this.checkBoxFixCommonErrors.Text = "Fix common errors";
            this.checkBoxFixCommonErrors.UseVisualStyleBackColor = true;
            this.checkBoxFixCommonErrors.CheckedChanged += new System.EventHandler(this.checkBoxFixCommonErrors_CheckedChanged);
            // 
            // buttonFixCommonErrorSettings
            // 
            this.buttonFixCommonErrorSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonFixCommonErrorSettings.Location = new System.Drawing.Point(149, 88);
            this.buttonFixCommonErrorSettings.Name = "buttonFixCommonErrorSettings";
            this.buttonFixCommonErrorSettings.Size = new System.Drawing.Size(87, 21);
            this.buttonFixCommonErrorSettings.TabIndex = 4;
            this.buttonFixCommonErrorSettings.Text = "Settings...";
            this.buttonFixCommonErrorSettings.UseVisualStyleBackColor = true;
            this.buttonFixCommonErrorSettings.Click += new System.EventHandler(this.buttonFixCommonErrorSettings_Click);
            // 
            // groupBoxChangeFrameRate
            // 
            this.groupBoxChangeFrameRate.Controls.Add(this.comboBoxFrameRateTo);
            this.groupBoxChangeFrameRate.Controls.Add(this.labelToFrameRate);
            this.groupBoxChangeFrameRate.Controls.Add(this.comboBoxFrameRateFrom);
            this.groupBoxChangeFrameRate.Controls.Add(this.labelFromFrameRate);
            this.groupBoxChangeFrameRate.Location = new System.Drawing.Point(249, 12);
            this.groupBoxChangeFrameRate.Name = "groupBoxChangeFrameRate";
            this.groupBoxChangeFrameRate.Size = new System.Drawing.Size(270, 73);
            this.groupBoxChangeFrameRate.TabIndex = 5;
            this.groupBoxChangeFrameRate.TabStop = false;
            this.groupBoxChangeFrameRate.Text = "Change frame rate";
            // 
            // comboBoxFrameRateTo
            // 
            this.comboBoxFrameRateTo.FormattingEnabled = true;
            this.comboBoxFrameRateTo.Location = new System.Drawing.Point(144, 47);
            this.comboBoxFrameRateTo.Name = "comboBoxFrameRateTo";
            this.comboBoxFrameRateTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrameRateTo.TabIndex = 3;
            // 
            // labelToFrameRate
            // 
            this.labelToFrameRate.Location = new System.Drawing.Point(3, 47);
            this.labelToFrameRate.Name = "labelToFrameRate";
            this.labelToFrameRate.Size = new System.Drawing.Size(141, 21);
            this.labelToFrameRate.TabIndex = 2;
            this.labelToFrameRate.Text = "To frame rate";
            this.labelToFrameRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxFrameRateFrom
            // 
            this.comboBoxFrameRateFrom.FormattingEnabled = true;
            this.comboBoxFrameRateFrom.Location = new System.Drawing.Point(144, 18);
            this.comboBoxFrameRateFrom.Name = "comboBoxFrameRateFrom";
            this.comboBoxFrameRateFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFrameRateFrom.TabIndex = 1;
            // 
            // labelFromFrameRate
            // 
            this.labelFromFrameRate.Location = new System.Drawing.Point(5, 18);
            this.labelFromFrameRate.Name = "labelFromFrameRate";
            this.labelFromFrameRate.Size = new System.Drawing.Size(139, 21);
            this.labelFromFrameRate.TabIndex = 0;
            this.labelFromFrameRate.Text = "From frame rate";
            this.labelFromFrameRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxOffsetTimeCodes
            // 
            this.groupBoxOffsetTimeCodes.Controls.Add(this.timeUpDownAdjust);
            this.groupBoxOffsetTimeCodes.Controls.Add(this.labelHoursMinSecsMilliSecs);
            this.groupBoxOffsetTimeCodes.Location = new System.Drawing.Point(249, 89);
            this.groupBoxOffsetTimeCodes.Name = "groupBoxOffsetTimeCodes";
            this.groupBoxOffsetTimeCodes.Size = new System.Drawing.Size(270, 98);
            this.groupBoxOffsetTimeCodes.TabIndex = 6;
            this.groupBoxOffsetTimeCodes.TabStop = false;
            this.groupBoxOffsetTimeCodes.Text = "Offset time codes";
            // 
            // timeUpDownAdjust
            // 
            this.timeUpDownAdjust.AutoSize = true;
            this.timeUpDownAdjust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timeUpDownAdjust.Location = new System.Drawing.Point(7, 33);
            this.timeUpDownAdjust.Margin = new System.Windows.Forms.Padding(4);
            this.timeUpDownAdjust.Name = "timeUpDownAdjust";
            this.timeUpDownAdjust.Size = new System.Drawing.Size(92, 24);
            this.timeUpDownAdjust.TabIndex = 1;
            // 
            // labelHoursMinSecsMilliSecs
            // 
            this.labelHoursMinSecsMilliSecs.AutoSize = true;
            this.labelHoursMinSecsMilliSecs.Location = new System.Drawing.Point(6, 16);
            this.labelHoursMinSecsMilliSecs.Name = "labelHoursMinSecsMilliSecs";
            this.labelHoursMinSecsMilliSecs.Size = new System.Drawing.Size(107, 13);
            this.labelHoursMinSecsMilliSecs.TabIndex = 0;
            this.labelHoursMinSecsMilliSecs.Text = "Hours:min:sec.msecs";
            // 
            // checkBoxFixCasing
            // 
            this.checkBoxFixCasing.AutoSize = true;
            this.checkBoxFixCasing.Location = new System.Drawing.Point(16, 45);
            this.checkBoxFixCasing.Name = "checkBoxFixCasing";
            this.checkBoxFixCasing.Size = new System.Drawing.Size(95, 17);
            this.checkBoxFixCasing.TabIndex = 1;
            this.checkBoxFixCasing.Text = "Auto-fix casing";
            this.checkBoxFixCasing.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemoveTextForHI
            // 
            this.checkBoxRemoveTextForHI.AutoSize = true;
            this.checkBoxRemoveTextForHI.Location = new System.Drawing.Point(16, 68);
            this.checkBoxRemoveTextForHI.Name = "checkBoxRemoveTextForHI";
            this.checkBoxRemoveTextForHI.Size = new System.Drawing.Size(115, 17);
            this.checkBoxRemoveTextForHI.TabIndex = 2;
            this.checkBoxRemoveTextForHI.Text = "Remove text for HI";
            this.checkBoxRemoveTextForHI.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemoveFormatting
            // 
            this.checkBoxRemoveFormatting.AutoSize = true;
            this.checkBoxRemoveFormatting.Location = new System.Drawing.Point(16, 22);
            this.checkBoxRemoveFormatting.Name = "checkBoxRemoveFormatting";
            this.checkBoxRemoveFormatting.Size = new System.Drawing.Size(115, 17);
            this.checkBoxRemoveFormatting.TabIndex = 0;
            this.checkBoxRemoveFormatting.Text = "Remove formatting";
            this.checkBoxRemoveFormatting.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.Controls.Add(this.linkLabelOpenOutputFolder);
            this.groupBoxOutput.Controls.Add(this.buttonStyles);
            this.groupBoxOutput.Controls.Add(this.checkBoxOverwrite);
            this.groupBoxOutput.Controls.Add(this.comboBoxSubtitleFormats);
            this.groupBoxOutput.Controls.Add(this.labelEncoding);
            this.groupBoxOutput.Controls.Add(this.comboBoxEncoding);
            this.groupBoxOutput.Controls.Add(this.labelOutputFormat);
            this.groupBoxOutput.Controls.Add(this.groupBoxConvertOptions);
            this.groupBoxOutput.Controls.Add(this.labelChooseOutputFolder);
            this.groupBoxOutput.Controls.Add(this.buttonChooseFolder);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputFolder);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 316);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(1027, 218);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // linkLabelOpenOutputFolder
            // 
            this.linkLabelOpenOutputFolder.AutoSize = true;
            this.linkLabelOpenOutputFolder.Location = new System.Drawing.Point(434, 44);
            this.linkLabelOpenOutputFolder.Name = "linkLabelOpenOutputFolder";
            this.linkLabelOpenOutputFolder.Size = new System.Drawing.Size(42, 13);
            this.linkLabelOpenOutputFolder.TabIndex = 3;
            this.linkLabelOpenOutputFolder.TabStop = true;
            this.linkLabelOpenOutputFolder.Text = "Open...";
            this.linkLabelOpenOutputFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelOpenOutputFolderLinkClicked);
            // 
            // buttonStyles
            // 
            this.buttonStyles.Location = new System.Drawing.Point(311, 100);
            this.buttonStyles.Name = "buttonStyles";
            this.buttonStyles.Size = new System.Drawing.Size(116, 23);
            this.buttonStyles.TabIndex = 7;
            this.buttonStyles.Text = "Style...";
            this.buttonStyles.UseVisualStyleBackColor = true;
            this.buttonStyles.Visible = false;
            this.buttonStyles.Click += new System.EventHandler(this.ButtonStylesClick);
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(13, 67);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(130, 17);
            this.checkBoxOverwrite.TabIndex = 4;
            this.checkBoxOverwrite.Text = "Overwrite exsiting files";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // comboBoxSubtitleFormats
            // 
            this.comboBoxSubtitleFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubtitleFormats.FormattingEnabled = true;
            this.comboBoxSubtitleFormats.Location = new System.Drawing.Point(80, 102);
            this.comboBoxSubtitleFormats.Name = "comboBoxSubtitleFormats";
            this.comboBoxSubtitleFormats.Size = new System.Drawing.Size(225, 21);
            this.comboBoxSubtitleFormats.TabIndex = 6;
            this.comboBoxSubtitleFormats.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSubtitleFormatsSelectedIndexChanged);
            // 
            // labelEncoding
            // 
            this.labelEncoding.AutoSize = true;
            this.labelEncoding.Location = new System.Drawing.Point(10, 137);
            this.labelEncoding.Name = "labelEncoding";
            this.labelEncoding.Size = new System.Drawing.Size(52, 13);
            this.labelEncoding.TabIndex = 8;
            this.labelEncoding.Text = "Encoding";
            // 
            // comboBoxEncoding
            // 
            this.comboBoxEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncoding.FormattingEnabled = true;
            this.comboBoxEncoding.Location = new System.Drawing.Point(80, 134);
            this.comboBoxEncoding.Name = "comboBoxEncoding";
            this.comboBoxEncoding.Size = new System.Drawing.Size(225, 21);
            this.comboBoxEncoding.TabIndex = 9;
            // 
            // labelOutputFormat
            // 
            this.labelOutputFormat.AutoSize = true;
            this.labelOutputFormat.Location = new System.Drawing.Point(10, 105);
            this.labelOutputFormat.Name = "labelOutputFormat";
            this.labelOutputFormat.Size = new System.Drawing.Size(39, 13);
            this.labelOutputFormat.TabIndex = 5;
            this.labelOutputFormat.Text = "Format";
            // 
            // labelChooseOutputFolder
            // 
            this.labelChooseOutputFolder.AutoSize = true;
            this.labelChooseOutputFolder.Location = new System.Drawing.Point(10, 25);
            this.labelChooseOutputFolder.Name = "labelChooseOutputFolder";
            this.labelChooseOutputFolder.Size = new System.Drawing.Size(105, 13);
            this.labelChooseOutputFolder.TabIndex = 0;
            this.labelChooseOutputFolder.Text = "Choose output folder";
            // 
            // buttonChooseFolder
            // 
            this.buttonChooseFolder.Location = new System.Drawing.Point(402, 39);
            this.buttonChooseFolder.Name = "buttonChooseFolder";
            this.buttonChooseFolder.Size = new System.Drawing.Size(26, 23);
            this.buttonChooseFolder.TabIndex = 2;
            this.buttonChooseFolder.Text = "...";
            this.buttonChooseFolder.UseVisualStyleBackColor = true;
            this.buttonChooseFolder.Click += new System.EventHandler(this.buttonChooseFolder_Click);
            // 
            // textBoxOutputFolder
            // 
            this.textBoxOutputFolder.Location = new System.Drawing.Point(11, 41);
            this.textBoxOutputFolder.Name = "textBoxOutputFolder";
            this.textBoxOutputFolder.Size = new System.Drawing.Size(385, 20);
            this.textBoxOutputFolder.TabIndex = 1;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput.Controls.Add(this.buttonInputBrowse);
            this.groupBoxInput.Controls.Add(this.labelChooseInputFiles);
            this.groupBoxInput.Controls.Add(this.listViewInputFiles);
            this.groupBoxInput.Location = new System.Drawing.Point(15, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(1024, 298);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // buttonInputBrowse
            // 
            this.buttonInputBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInputBrowse.Location = new System.Drawing.Point(989, 41);
            this.buttonInputBrowse.Name = "buttonInputBrowse";
            this.buttonInputBrowse.Size = new System.Drawing.Size(26, 23);
            this.buttonInputBrowse.TabIndex = 2;
            this.buttonInputBrowse.Text = "...";
            this.buttonInputBrowse.UseVisualStyleBackColor = true;
            this.buttonInputBrowse.Click += new System.EventHandler(this.buttonInputBrowse_Click);
            // 
            // labelChooseInputFiles
            // 
            this.labelChooseInputFiles.AutoSize = true;
            this.labelChooseInputFiles.Location = new System.Drawing.Point(5, 25);
            this.labelChooseInputFiles.Name = "labelChooseInputFiles";
            this.labelChooseInputFiles.Size = new System.Drawing.Size(202, 13);
            this.labelChooseInputFiles.TabIndex = 0;
            this.labelChooseInputFiles.Text = "Choose input files (browse or drag-n-drop)";
            // 
            // listViewInputFiles
            // 
            this.listViewInputFiles.AllowDrop = true;
            this.listViewInputFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewInputFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFName,
            this.columnHeaderSize,
            this.columnHeaderFormat,
            this.columnHeaderStatus});
            this.listViewInputFiles.ContextMenuStrip = this.contextMenuStripFiles;
            this.listViewInputFiles.FullRowSelect = true;
            this.listViewInputFiles.HideSelection = false;
            this.listViewInputFiles.Location = new System.Drawing.Point(6, 41);
            this.listViewInputFiles.Name = "listViewInputFiles";
            this.listViewInputFiles.Size = new System.Drawing.Size(978, 249);
            this.listViewInputFiles.TabIndex = 1;
            this.listViewInputFiles.UseCompatibleStateImageBehavior = false;
            this.listViewInputFiles.View = System.Windows.Forms.View.Details;
            this.listViewInputFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewInputFiles_DragDrop);
            this.listViewInputFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewInputFiles_DragEnter);
            this.listViewInputFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewInputFilesKeyDown);
            // 
            // columnHeaderFName
            // 
            this.columnHeaderFName.Text = "File name";
            this.columnHeaderFName.Width = 500;
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Size";
            this.columnHeaderSize.Width = 75;
            // 
            // columnHeaderFormat
            // 
            this.columnHeaderFormat.Text = "Format";
            this.columnHeaderFormat.Width = 200;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 124;
            // 
            // contextMenuStripFiles
            // 
            this.contextMenuStripFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.removeAllToolStripMenuItem});
            this.contextMenuStripFiles.Name = "contextMenuStripStyles";
            this.contextMenuStripFiles.Size = new System.Drawing.Size(153, 70);
            this.contextMenuStripFiles.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripFilesOpening);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItemClick);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeAllToolStripMenuItem.Text = "Remove all";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.RemoveAllToolStripMenuItemClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(15, 556);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(833, 10);
            this.progressBar1.TabIndex = 8;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 540);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(59, 13);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "labelStatus";
            // 
            // BatchConvert
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 580);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonCancel);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1024, 578);
            this.Name = "BatchConvert";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Batch convert";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BatchConvert_FormClosing);
            this.groupBoxConvertOptions.ResumeLayout(false);
            this.groupBoxConvertOptions.PerformLayout();
            this.groupBoxChangeFrameRate.ResumeLayout(false);
            this.groupBoxOffsetTimeCodes.ResumeLayout(false);
            this.groupBoxOffsetTimeCodes.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.contextMenuStripFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxConvertOptions;
        private System.Windows.Forms.CheckBox checkBoxFixCasing;
        private System.Windows.Forms.CheckBox checkBoxRemoveTextForHI;
        private System.Windows.Forms.CheckBox checkBoxRemoveFormatting;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.ComboBox comboBoxSubtitleFormats;
        private System.Windows.Forms.Label labelEncoding;
        private System.Windows.Forms.ComboBox comboBoxEncoding;
        private System.Windows.Forms.Label labelOutputFormat;
        private System.Windows.Forms.Label labelChooseOutputFolder;
        private System.Windows.Forms.Button buttonChooseFolder;
        private System.Windows.Forms.TextBox textBoxOutputFolder;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button buttonInputBrowse;
        private System.Windows.Forms.Label labelChooseInputFiles;
        private System.Windows.Forms.ListView listViewInputFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderFName;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.ColumnHeader columnHeaderFormat;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.Button buttonStyles;
        private System.Windows.Forms.GroupBox groupBoxOffsetTimeCodes;
        private System.Windows.Forms.GroupBox groupBoxChangeFrameRate;
        private Controls.TimeUpDown timeUpDownAdjust;
        private System.Windows.Forms.Label labelHoursMinSecsMilliSecs;
        private System.Windows.Forms.ComboBox comboBoxFrameRateTo;
        private System.Windows.Forms.Label labelToFrameRate;
        private System.Windows.Forms.ComboBox comboBoxFrameRateFrom;
        private System.Windows.Forms.Label labelFromFrameRate;
        private System.Windows.Forms.LinkLabel linkLabelOpenOutputFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFiles;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxFixCommonErrors;
        private System.Windows.Forms.Button buttonFixCommonErrorSettings;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelStatus;

    }
}