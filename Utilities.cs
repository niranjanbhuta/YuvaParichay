
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb; // may be reqd
using System.Xml.Linq;
using System.Data.SqlClient;
//using System.Data.SqlServerCe; // .SqlServerCe; // .SqlServerCe; //  .Client 
using System.Configuration;
using System.Reflection;
using System.Text.RegularExpressions;

using LinqToExcel;
using log4net; 



namespace YuvaParichay
{
    class Utilities
    {

        /// <summary>
        /// This will be moved to the util class so it can service any paste into a DGV
        /// </summary>
       // private void PasteClipboard() // Not used as insert/append not available. Modified by nsb
        private void PasteClipboardWithPara(DataGridView dgData) // Not used as insert/append not available
   
        {
            try
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int iFail = 0, iRow = dgData.CurrentCell.RowIndex;
                int iCol = dgData.CurrentCell.ColumnIndex;
                DataGridViewCell oCell;
                foreach (string line in lines)
                {
                    if (iRow < dgData.RowCount && line.Length > 0) //nsb: No provision for inserting new row !
                    {
                        string[] sCells = line.Split('\t');
                        for (int i = 0; i < sCells.GetLength(0); ++i)
                        {
                            if (iCol + i < dgData.ColumnCount) //this.dgData.ColumnCount
                            {
                                oCell = dgData[iCol + i, iRow];
                                if (!oCell.ReadOnly)
                                {
                                    if (oCell.Value.ToString() != sCells[i])
                                    {
                                        oCell.Value = Convert.ChangeType(sCells[i], oCell.ValueType);
                                        oCell.Style.BackColor = Color.Tomato;
                                    }
                                    else
                                        iFail++;//only traps a fail if the data has changed and you are pasting into a read only cell
                                }
                            }
                            else
                            { break; }
                        }
                        iRow++;
                    }
                    else
                    { break; }
                    if (iFail > 0)
                        MessageBox.Show(string.Format("{0} updates failed due to read only column setting", iFail));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The data you pasted is in the wrong format for the cell");
                return;
            }
        }


        //dt 22-12-14
        private void PasteClipboard(DataGridView dgv) // Not used as insert/append not available
        {
            try
            {
                DataGridViewRow selectedRow;
                /* Find first selected cell's row (or first selected row). */
                if (dgv.SelectedRows.Count > 0)
                    selectedRow = dgv.SelectedRows[0];
                else if (dgv.SelectedCells.Count > 0)
                    selectedRow = dgv.SelectedCells[0].OwningRow;
                else
                    return;
                /* Get clipboard Text */
                string clipText = Clipboard.GetText();
                /* Get Rows ( newline delimited ) */
                string[] rowLines = Regex.Split(clipText, "\r\n");
                foreach (string row in rowLines)
                {
                    /* Get Cell contents ( tab delimited ) */
                    string[] cells = Regex.Split(row, "\t");
                    DataGridViewRow r = new DataGridViewRow();
                    foreach (string sc in cells)
                    {
                        DataGridViewTextBoxCell c = new DataGridViewTextBoxCell();
                        c.Value = sc;
                        r.Cells.Add(c);
                    }
                    dgv.Rows.Insert(selectedRow.Index, r);
                    //              this.toolStripStatusLabel1.Text = "Data has been pasted.";
                }


            }
            catch (System.ArgumentException ex)
            {
                //            MessageBeep(MB_ICONEXCLAMATION);
                //            this.toolStripStatusLabel1.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 


    }
}
