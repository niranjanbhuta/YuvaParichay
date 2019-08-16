namespace YuvaParichay
{
    partial class aboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutBox));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBoxNsbPhoto = new System.Windows.Forms.PictureBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCopyRT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNsbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPictureBox.Image = global::YuvaParichay.Properties.Resources.HastMilap;
            this.logoPictureBox.Location = new System.Drawing.Point(-2, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(167, 181);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // pictureBoxNsbPhoto
            // 
            this.pictureBoxNsbPhoto.Image = global::YuvaParichay.Properties.Resources.NsbPhoto;
            this.pictureBoxNsbPhoto.InitialImage = null;
            this.pictureBoxNsbPhoto.Location = new System.Drawing.Point(0, 190);
            this.pictureBoxNsbPhoto.Name = "pictureBoxNsbPhoto";
            this.pictureBoxNsbPhoto.Size = new System.Drawing.Size(165, 177);
            this.pictureBoxNsbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNsbPhoto.TabIndex = 1;
            this.pictureBoxNsbPhoto.TabStop = false;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.Location = new System.Drawing.Point(174, 37);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(0, 17);
            this.labelCompanyName.TabIndex = 26;
            this.labelCompanyName.Text = "Niranjan S. Bhuta";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            // 
            // lblCopyRT
            // 
            this.lblCopyRT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopyRT.Location = new System.Drawing.Point(177, 65);
            this.lblCopyRT.MaximumSize = new System.Drawing.Size(400, 30);
            this.lblCopyRT.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblCopyRT.Name = "lblCopyRT";
            this.lblCopyRT.Size = new System.Drawing.Size(327, 30);
            this.lblCopyRT.TabIndex = 28;
            this.lblCopyRT.Text = "Copy Right: Warning!: This Computer Program is copy protected by Copy Right Law a" +
    "nd International Treaties.\r\n";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(171, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 114);
            this.label2.TabIndex = 29;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProductName.Location = new System.Drawing.Point(174, 9);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(229, 23);
            this.labelProductName.TabIndex = 30;
            this.labelProductName.Text = "Product Name: Yuva Parichay, 2014";
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(180, 32);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(196, 33);
            this.labelVersion.TabIndex = 31;
            this.labelVersion.Text = "Version 1.0.0.0";
            // 
            // aboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 374);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCopyRT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.pictureBoxNsbPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "aboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.aboutBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNsbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox pictureBoxNsbPhoto;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCopyRT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
    }
}
