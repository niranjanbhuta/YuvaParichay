 namespace YuvaParichay
{
    partial class formReport
    {
        //To make visible in main form, change scope.
         public  Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
         public Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
         
         public Microsoft.Reporting.WinForms.ReportViewer reportViewerGirl;
         public Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
         
         public Microsoft.Reporting.WinForms.ReportViewer reportViewerMatch;
         public Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
        
    
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BoysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new YuvaParichay.DataSet1();
            this.GirlsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BoysTableAdapter = new YuvaParichay.DataSet1TableAdapters.BoysTableAdapter();
            this.GirlsTableAdapter = new YuvaParichay.DataSet1TableAdapters.GirlsTableAdapter();
            this.qryMatchBoyGirlBindingSource = new System.Windows.Forms.BindingSource(this.components);
  //          this.qryMatchBoyGirlTableAdapter = new YuvaParichay.DataSet1TableAdapters.qryMatchBoyGirlTableAdapter();
            this.reportViewerGirl = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewerMatch = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BoysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirlsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryMatchBoyGirlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BoysBindingSource
            // 
            this.BoysBindingSource.DataMember = "Boys";
            this.BoysBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GirlsBindingSource
            // 
            this.GirlsBindingSource.DataMember = "Girls";
            this.GirlsBindingSource.DataSource = this.DataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BoysBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YuvaParichay.BoyReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(801, 440);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BoysTableAdapter
            // 
            this.BoysTableAdapter.ClearBeforeFill = true;
            // 
            // GirlsTableAdapter
            // 
            this.GirlsTableAdapter.ClearBeforeFill = true;
            // 
            // qryMatchBoyGirlBindingSource
            // 
            this.qryMatchBoyGirlBindingSource.DataMember = "qryMatchBoyGirl";
            this.qryMatchBoyGirlBindingSource.DataSource = this.DataSet1;
            // 
            // qryMatchBoyGirlTableAdapter
            // 
  //          this.qryMatchBoyGirlTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewerGirl
            // 
            this.reportViewerGirl.AutoSize = true;
            this.reportViewerGirl.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.GirlsBindingSource;
            this.reportViewerGirl.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerGirl.LocalReport.ReportEmbeddedResource = "YuvaParichay.GirlReport.rdlc";
            this.reportViewerGirl.Location = new System.Drawing.Point(0, 0);
            this.reportViewerGirl.Name = "reportViewerGirl";
            this.reportViewerGirl.Size = new System.Drawing.Size(801, 440);
            this.reportViewerGirl.TabIndex = 1;
            // 
            // reportViewerMatch
            // 
            this.reportViewerMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.qryMatchBoyGirlBindingSource;
            this.reportViewerMatch.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerMatch.LocalReport.ReportEmbeddedResource = "YuvaParichay.MatchReport.rdlc";
            this.reportViewerMatch.Location = new System.Drawing.Point(0, 0);
            this.reportViewerMatch.Name = "reportViewerMatch";
            this.reportViewerMatch.Size = new System.Drawing.Size(801, 440);
            this.reportViewerMatch.TabIndex = 2;
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 440);
            this.Controls.Add(this.reportViewerMatch);
            this.Controls.Add(this.reportViewerGirl);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formReport";
            this.Text = "formReport";
            this.Load += new System.EventHandler(this.formReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GirlsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qryMatchBoyGirlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
       // friend Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BoysBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.BoysTableAdapter BoysTableAdapter;
        private System.Windows.Forms.BindingSource GirlsBindingSource;
        private DataSet1TableAdapters.GirlsTableAdapter GirlsTableAdapter;
        private System.Windows.Forms.BindingSource qryMatchBoyGirlBindingSource;
  //      private DataSet1TableAdapters.qryMatchBoyGirlTableAdapter qryMatchBoyGirlTableAdapter;
      //  private Microsoft.Reporting.WinForms.ReportViewer reportViewerMatch;
      //  private Microsoft.Reporting.WinForms.ReportViewer reportViewerGirl; //nsb to change scope
    }
}