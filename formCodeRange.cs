using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YuvaParichay
{
    public partial class formCodeRange : Form
    {
        //decl. numeric range var
       public  int intCodeStart, intCodeEnd;
        public formCodeRange()
        {
            InitializeComponent();
        }
        //properties to make visible in form1
      
       public string textBoxStartCodeStr
       {    
            get 
            {
               return this.textBoxStartCode.ToString ()  ;// return this.tableBoys;
            }           
       }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStartCode_Validating(object sender, CancelEventArgs e)
        {
           // textBoxStartCode.
            //if (textBoxStartCode.GetType () = typeof ( int);       
        }

        private void textBoxStartCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow only numeric value/digit
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b')   e.Handled = false;            
            
            else
            {               
                e.Handled = true; MessageBox.Show("Enter Only 1..9 digit");             
            }
        }

        private void textBoxEndCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow only numeric value/digit
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') e.Handled = false;
            else { e.Handled = true; MessageBox.Show("Enter Only 1..9 digit"); }       
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {   
            //Start code
           // bool canConvert = long.TryParse("99", out lngCodeStart);
            intCodeStart = Convert.ToInt16(this.textBoxStartCode.Text);
            if (intCodeStart == 0) { MessageBox.Show("Start value Can not be Zero"); this.Close(); return; }

            //End code
           // canConvert = long.TryParse("133", out lngCodeEnd);
            intCodeEnd = Convert.ToInt16(this.textBoxEndCode.Text);
            if (intCodeEnd == 0) { MessageBox.Show("End value Can not be Zero"); this.Close(); return; }

            this.Visible = false;
            this.Close();
          }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            //reset both num , so that method calling them would not proceed
            textBoxEndCode.Text = ""; textBoxStartCode.Text = ""; 
            this.Visible = false;
        }
        
    }

 }
