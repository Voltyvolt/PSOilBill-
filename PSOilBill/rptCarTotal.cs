using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PSOilBill
{
    public partial class rptCarTotal : DevExpress.XtraReports.UI.XtraReport
    {
        int counter = 0;
        public rptCarTotal()
        {
            InitializeComponent();
        }

        private void xrLabel30_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void xrLabel24_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            counter++;
            xrLabel24.Text = counter.ToString();
        }

        private void xrLabel35_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            int lvText = Gstr.fncToInt(xrLabel35.Text);

            if(lvText > 200)
            {
                xrLabel35.ForeColor = Color.Red;
            }
            else
            {
                xrLabel35.ForeColor = Color.Black;
            }
        }
    }
}
