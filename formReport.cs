using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuvaParichay
{
    public partial class formReport : Form
    {
        public formReport()
        {
            InitializeComponent();
        }
        
        private void formReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.qryMatchBoyGirl' table. You can move, or remove it, as needed.
           try{
            //this.qryMatchBoyGirlTableAdapter.Fill(this.DataSet1.qryMatchBoyGirl);

               //Select and fill data directly from basic tables of database thru select-qry, instead of filling from
               // readymade table 'qryMatchBoyGirl' (one which is deleted for secrecy of code from unencrypted DB) of database.
               //this._commandCollection[0].CommandText = "SELECT IdCandidateFK, IdILike, IdLikedBy FROM qryMatchBoyGirl";
                //DataRow[] foundRows = dt.Select("page_name='Management'");
                //qryMatchGirlBoyRow
              // this.DataSet1.  .qryMatchBoyGirl.  .
               //qryMatchGirlBoyRow rows[] = 
                      
               string cmdText = "SELECT DISTINCT BoysLike.IdCandidateFK, BoysLike.IdILike, BoysLikedBy.IdLikedBy FROM BoysLike INNER JOIN BoysLikedBy ON (BoysLike.IdILike=BoysLikedBy.IdLikedBy) AND (BoysLike.IdCandidateFK=BoysLikedBy.IdCandidateFK)";
             //  System.Data.OleDb.OleDbDataReader dataReader;
             //  System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(cmd); 
               System.Data.OleDb.OleDbConnection cn = new System.Data.OleDb.OleDbConnection ();
               System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
               cn.ConnectionString = YuvaParichay.Properties.Settings.Default.YuvaParichayConnectionString;
               cmd.Connection = cn;
               cmd.CommandText = cmdText;
               //dataReader=cmd.ExecuteReader(); 
               //cmd.ExecuteNonQuery();

               System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(cmd); 
             
               DataTable dt = new DataTable();
               //da.Fill(dt);
               da.Fill(this.DataSet1.qryMatchBoyGirl);
               
              //this.qryMatchBoyGirlTableAdapter
               //this.DataSet1.qryMatchBoyGirl.Select 
        //       DataSet1.qryMatchBoyGirlRow[] rows ; //= new DataSet1.qryMatchBoyGirlRow;


                     }
            catch (  Exception  err){
                MessageBox .Show (err.Message );
            }

            // TODO: This line of code loads data into the 'DataSet1.Girls' table. You can move, or remove it, as needed.
            this.GirlsTableAdapter.Fill(this.DataSet1.Girls);
            // TODO: This line of code loads data into the 'DataSet1.Boys' table. You can move, or remove it, as needed.
            this.BoysTableAdapter.Fill(this.DataSet1.Boys);

            this.reportViewer1.RefreshReport();
            //this.reportViewer1 .LocalReport
            //LocalReport localReport = reportViewer1.LocalReport;
         //   reportViewer1.LocalReport.ReportEmbeddedResource = "BoyReport.rdlc"   ;//"Sales Order Detail.rdlc" nsb
         //   Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();

            //this.reportViewerGirl.RefreshReport(); //duplicate
            
            this.reportViewerGirl.RefreshReport();
            this.reportViewerMatch.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
