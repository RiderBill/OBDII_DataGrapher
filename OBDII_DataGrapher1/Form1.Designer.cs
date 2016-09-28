namespace OBDII_DataGrapher1
{
   partial class Form1
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
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.browsBtn1 = new System.Windows.Forms.Button();
         this.infileLabel = new System.Windows.Forms.Label();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.listBoxInputFiles = new System.Windows.Forms.ListBox();
         this.fileContentsLabel = new System.Windows.Forms.Label();
         this.labelFrameData = new System.Windows.Forms.Label();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.inFileContentsRichTextBox = new System.Windows.Forms.RichTextBox();
         this.graphBtn = new System.Windows.Forms.Button();
         this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.tableBtn = new System.Windows.Forms.Button();
         this.TabularDataRichTextBox = new System.Windows.Forms.RichTextBox();
         this.chanListBtn = new System.Windows.Forms.Button();
         this.showFileBtn = new System.Windows.Forms.Button();
         this.listBoxChannels = new System.Windows.Forms.ListBox();
         this.menuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
         this.SuspendLayout();
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.Filter = "Text files|*.txt|All files|*.*";
         this.openFileDialog1.ReadOnlyChecked = true;
         // 
         // browsBtn1
         // 
         this.browsBtn1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.browsBtn1.Location = new System.Drawing.Point(615, 128);
         this.browsBtn1.Name = "browsBtn1";
         this.browsBtn1.Size = new System.Drawing.Size(26, 19);
         this.browsBtn1.TabIndex = 0;
         this.browsBtn1.Text = "...";
         this.browsBtn1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         this.browsBtn1.UseVisualStyleBackColor = true;
         this.browsBtn1.Click += new System.EventHandler(this.browsBtn1_Click);
         // 
         // infileLabel
         // 
         this.infileLabel.AutoSize = true;
         this.infileLabel.Location = new System.Drawing.Point(9, 36);
         this.infileLabel.Name = "infileLabel";
         this.infileLabel.Size = new System.Drawing.Size(53, 13);
         this.infileLabel.TabIndex = 2;
         this.infileLabel.Text = "Input File:";
         // 
         // menuStrip1
         // 
         this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(653, 24);
         this.menuStrip1.TabIndex = 3;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
         this.openToolStripMenuItem.Text = "Open";
         this.openToolStripMenuItem.ToolTipText = "Open a .txt file previously downloaded from the OBD-II Scantool";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
         this.saveToolStripMenuItem.Text = "Save";
         this.saveToolStripMenuItem.ToolTipText = "Save Frame Data Table";
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
         this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.helpToolStripMenuItem.Text = "Help";
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
         this.aboutToolStripMenuItem.Text = "About";
         this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
         // 
         // listBoxInputFiles
         // 
         this.listBoxInputFiles.FormattingEnabled = true;
         this.listBoxInputFiles.HorizontalScrollbar = true;
         this.listBoxInputFiles.Location = new System.Drawing.Point(12, 52);
         this.listBoxInputFiles.Name = "listBoxInputFiles";
         this.listBoxInputFiles.ScrollAlwaysVisible = true;
         this.listBoxInputFiles.Size = new System.Drawing.Size(628, 95);
         this.listBoxInputFiles.TabIndex = 4;
         this.listBoxInputFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxInputFiles_SelectedIndexChanged);
         // 
         // fileContentsLabel
         // 
         this.fileContentsLabel.AutoSize = true;
         this.fileContentsLabel.Location = new System.Drawing.Point(12, 159);
         this.fileContentsLabel.Name = "fileContentsLabel";
         this.fileContentsLabel.Size = new System.Drawing.Size(68, 13);
         this.fileContentsLabel.TabIndex = 5;
         this.fileContentsLabel.Text = "File Contents";
         // 
         // labelFrameData
         // 
         this.labelFrameData.AutoSize = true;
         this.labelFrameData.Location = new System.Drawing.Point(275, 159);
         this.labelFrameData.Name = "labelFrameData";
         this.labelFrameData.Size = new System.Drawing.Size(53, 13);
         this.labelFrameData.TabIndex = 7;
         this.labelFrameData.Text = "Live Data";
         // 
         // inFileContentsRichTextBox
         // 
         this.inFileContentsRichTextBox.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.inFileContentsRichTextBox.Location = new System.Drawing.Point(12, 183);
         this.inFileContentsRichTextBox.MaxLength = 65535;
         this.inFileContentsRichTextBox.Name = "inFileContentsRichTextBox";
         this.inFileContentsRichTextBox.ReadOnly = true;
         this.inFileContentsRichTextBox.Size = new System.Drawing.Size(260, 283);
         this.inFileContentsRichTextBox.TabIndex = 1;
         this.inFileContentsRichTextBox.Text = "";
         this.inFileContentsRichTextBox.WordWrap = false;
         // 
         // graphBtn
         // 
         this.graphBtn.Location = new System.Drawing.Point(334, 154);
         this.graphBtn.Name = "graphBtn";
         this.graphBtn.Size = new System.Drawing.Size(62, 22);
         this.graphBtn.TabIndex = 8;
         this.graphBtn.Text = "Graph";
         this.graphBtn.UseVisualStyleBackColor = true;
         this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
         // 
         // chart1
         // 
         chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         chartArea1.Name = "ChartArea1";
         this.chart1.ChartAreas.Add(chartArea1);
         legend1.DockedToChartArea = "ChartArea1";
         legend1.IsDockedInsideChartArea = false;
         legend1.Name = "Legend1";
         this.chart1.Legends.Add(legend1);
         this.chart1.Location = new System.Drawing.Point(278, 184);
         this.chart1.Name = "chart1";
         this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
         series1.ChartArea = "ChartArea1";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
         series1.Legend = "Legend1";
         series1.Name = "Series1";
         series1.XValueMember = "Form1.x";
         series1.YValueMembers = "Form1.y";
         this.chart1.Series.Add(series1);
         this.chart1.Size = new System.Drawing.Size(375, 276);
         this.chart1.TabIndex = 10;
         this.chart1.Text = "OBD Frame Data";
         // 
         // tableBtn
         // 
         this.tableBtn.Location = new System.Drawing.Point(402, 154);
         this.tableBtn.Name = "tableBtn";
         this.tableBtn.Size = new System.Drawing.Size(63, 22);
         this.tableBtn.TabIndex = 11;
         this.tableBtn.Text = "Table";
         this.tableBtn.UseVisualStyleBackColor = true;
         this.tableBtn.Click += new System.EventHandler(this.tableBtn_Click);
         // 
         // TabularDataRichTextBox
         // 
         this.TabularDataRichTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TabularDataRichTextBox.Location = new System.Drawing.Point(278, 184);
         this.TabularDataRichTextBox.Name = "TabularDataRichTextBox";
         this.TabularDataRichTextBox.Size = new System.Drawing.Size(362, 282);
         this.TabularDataRichTextBox.TabIndex = 12;
         this.TabularDataRichTextBox.Text = "";
         this.TabularDataRichTextBox.WordWrap = false;
         // 
         // chanListBtn
         // 
         this.chanListBtn.Location = new System.Drawing.Point(168, 154);
         this.chanListBtn.Name = "chanListBtn";
         this.chanListBtn.Size = new System.Drawing.Size(80, 22);
         this.chanListBtn.TabIndex = 13;
         this.chanListBtn.Text = "List Channels";
         this.chanListBtn.UseVisualStyleBackColor = true;
         this.chanListBtn.Click += new System.EventHandler(this.chanListBtn_Click);
         // 
         // showFileBtn
         // 
         this.showFileBtn.Location = new System.Drawing.Point(82, 154);
         this.showFileBtn.Name = "showFileBtn";
         this.showFileBtn.Size = new System.Drawing.Size(80, 22);
         this.showFileBtn.TabIndex = 14;
         this.showFileBtn.Text = "Show File";
         this.showFileBtn.UseVisualStyleBackColor = true;
         this.showFileBtn.Click += new System.EventHandler(this.showFileBtn_Click);
         // 
         // listBoxChannels
         // 
         this.listBoxChannels.FormattingEnabled = true;
         this.listBoxChannels.HorizontalScrollbar = true;
         this.listBoxChannels.Location = new System.Drawing.Point(12, 183);
         this.listBoxChannels.Name = "listBoxChannels";
         this.listBoxChannels.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
         this.listBoxChannels.Size = new System.Drawing.Size(260, 277);
         this.listBoxChannels.TabIndex = 15;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(653, 476);
         this.Controls.Add(this.listBoxChannels);
         this.Controls.Add(this.showFileBtn);
         this.Controls.Add(this.chanListBtn);
         this.Controls.Add(this.TabularDataRichTextBox);
         this.Controls.Add(this.tableBtn);
         this.Controls.Add(this.graphBtn);
         this.Controls.Add(this.inFileContentsRichTextBox);
         this.Controls.Add(this.labelFrameData);
         this.Controls.Add(this.fileContentsLabel);
         this.Controls.Add(this.infileLabel);
         this.Controls.Add(this.browsBtn1);
         this.Controls.Add(this.menuStrip1);
         this.Controls.Add(this.listBoxInputFiles);
         this.Controls.Add(this.chart1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "Form1";
         this.Text = "test";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.Button browsBtn1;
      private System.Windows.Forms.Label infileLabel;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ListBox listBoxInputFiles;
      private System.Windows.Forms.Label fileContentsLabel;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.Label labelFrameData;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.RichTextBox inFileContentsRichTextBox;
      private System.Windows.Forms.Button graphBtn;
      private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
      private System.Windows.Forms.Button tableBtn;
      private System.Windows.Forms.RichTextBox TabularDataRichTextBox;
      private System.Windows.Forms.Button chanListBtn;
      private System.Windows.Forms.Button showFileBtn;
      private System.Windows.Forms.ListBox listBoxChannels;
   }
}

