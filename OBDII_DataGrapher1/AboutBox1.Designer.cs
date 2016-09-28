namespace OBDII_DataGrapher1
{
   partial class AboutBox1
   {  /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose(bool disposing)
      {  if (disposing && (components != null))
         {  components.Dispose();
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
         this.logoPictureBox = new System.Windows.Forms.PictureBox();
         this.labelCopyright = new System.Windows.Forms.Label();
         this.labelCompanyName = new System.Windows.Forms.Label();
         this.descriptionTextBox = new System.Windows.Forms.TextBox();
         this.okButton = new System.Windows.Forms.Button();
         this.labelProductName = new System.Windows.Forms.Label();
         this.labelVersion = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // logoPictureBox
         // 
         this.logoPictureBox.Image = global::OBDII_DataGrapher1.Properties.Resources.OBD_II_Image;
         this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
         this.logoPictureBox.Name = "logoPictureBox";
         this.logoPictureBox.Size = new System.Drawing.Size(160, 128);
         this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.logoPictureBox.TabIndex = 12;
         this.logoPictureBox.TabStop = false;
         // 
         // labelCopyright
         // 
         this.labelCopyright.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelCopyright.Location = new System.Drawing.Point(11, 72);
         this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
         this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 23);
         this.labelCopyright.MinimumSize = new System.Drawing.Size(219, 0);
         this.labelCopyright.Name = "labelCopyright";
         this.labelCopyright.Size = new System.Drawing.Size(219, 23);
         this.labelCopyright.TabIndex = 3;
         this.labelCopyright.Text = "Copyright";
         this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // labelCompanyName
         // 
         this.labelCompanyName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelCompanyName.Location = new System.Drawing.Point(11, 100);
         this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
         this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 23);
         this.labelCompanyName.MinimumSize = new System.Drawing.Size(219, 23);
         this.labelCompanyName.Name = "labelCompanyName";
         this.labelCompanyName.Size = new System.Drawing.Size(219, 23);
         this.labelCompanyName.TabIndex = 4;
         this.labelCompanyName.Text = "Company Name";
         this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // descriptionTextBox
         // 
         this.descriptionTextBox.Location = new System.Drawing.Point(12, 146);
         this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
         this.descriptionTextBox.Multiline = true;
         this.descriptionTextBox.Name = "descriptionTextBox";
         this.descriptionTextBox.ReadOnly = true;
         this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.descriptionTextBox.Size = new System.Drawing.Size(411, 121);
         this.descriptionTextBox.TabIndex = 5;
         this.descriptionTextBox.TabStop = false;
         this.descriptionTextBox.Text = "Description";
         // 
         // okButton
         // 
         this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.okButton.Location = new System.Drawing.Point(348, 275);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(75, 20);
         this.okButton.TabIndex = 6;
         this.okButton.Text = "&OK";
         // 
         // labelProductName
         // 
         this.labelProductName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelProductName.Location = new System.Drawing.Point(11, 10);
         this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
         this.labelProductName.Name = "labelProductName";
         this.labelProductName.Size = new System.Drawing.Size(219, 23);
         this.labelProductName.TabIndex = 1;
         this.labelProductName.Text = "Product Name";
         this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // labelVersion
         // 
         this.labelVersion.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelVersion.Location = new System.Drawing.Point(11, 44);
         this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
         this.labelVersion.MaximumSize = new System.Drawing.Size(0, 23);
         this.labelVersion.MinimumSize = new System.Drawing.Size(219, 0);
         this.labelVersion.Name = "labelVersion";
         this.labelVersion.Size = new System.Drawing.Size(219, 23);
         this.labelVersion.TabIndex = 2;
         this.labelVersion.Text = "Version";
         this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.labelVersion);
         this.panel1.Controls.Add(this.labelProductName);
         this.panel1.Controls.Add(this.labelCopyright);
         this.panel1.Controls.Add(this.labelCompanyName);
         this.panel1.Location = new System.Drawing.Point(178, 12);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(245, 128);
         this.panel1.TabIndex = 25;
         // 
         // AboutBox1
         // 
         this.AcceptButton = this.okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(435, 304);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.okButton);
         this.Controls.Add(this.logoPictureBox);
         this.Controls.Add(this.descriptionTextBox);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AboutBox1";
         this.Padding = new System.Windows.Forms.Padding(9);
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "About OBD II DataGrapher";
         ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox logoPictureBox;
      private System.Windows.Forms.Label labelProductName;
      private System.Windows.Forms.Label labelCopyright;
      private System.Windows.Forms.Label labelCompanyName;
      private System.Windows.Forms.TextBox descriptionTextBox;
      private System.Windows.Forms.Button okButton;
      private System.Windows.Forms.Label labelVersion;
      private System.Windows.Forms.Panel panel1;
   }
}
