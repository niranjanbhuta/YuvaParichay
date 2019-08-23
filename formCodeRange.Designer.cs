namespace YuvaParichay
{
    partial class formCodeRange
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
            this.textBoxStartCode = new System.Windows.Forms.TextBox();
            this.textBoxEndCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStartCode
            // 
            this.textBoxStartCode.Location = new System.Drawing.Point(112, 40);
            this.textBoxStartCode.Name = "textBoxStartCode";
            this.textBoxStartCode.Size = new System.Drawing.Size(61, 20);
            this.textBoxStartCode.TabIndex = 0;
            this.textBoxStartCode.Text = "1";
            this.textBoxStartCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartCode_KeyPress);
            this.textBoxStartCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStartCode_Validating);
            // 
            // textBoxEndCode
            // 
            this.textBoxEndCode.Location = new System.Drawing.Point(112, 76);
            this.textBoxEndCode.Name = "textBoxEndCode";
            this.textBoxEndCode.Size = new System.Drawing.Size(64, 20);
            this.textBoxEndCode.TabIndex = 1;
            this.textBoxEndCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEndCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start-Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End-Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(113, 116);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(41, 32);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code Range Must be Numeric Only";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(20, 122);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(55, 25);
            this.cmdCancel.TabIndex = 6;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // formCodeRange
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 171);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEndCode);
            this.Controls.Add(this.textBoxStartCode);
            this.Name = "formCodeRange";
            this.Text = "formAppendCodeRange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStartCode;
        private System.Windows.Forms.TextBox textBoxEndCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdCancel;
    }
}