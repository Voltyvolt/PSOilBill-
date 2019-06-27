using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace PSOilBill
{
    public partial class rptBill : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBill()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            //lbDocS.Text = GVar.gvDocS;
            lbDocNo.Text = GVar.gvDocNo;
            lbDate.Text = GVar.gvDate;
            lbMonth.Text = GVar.gvMonth;
            lbYear.Text = GVar.gvYear;
            lbName.Text = GVar.gvName;
            lbQuota.Text = GVar.gvQuota;
            lbCarNum.Text = GVar.gvCarNum;
            lbFront.Text = GVar.gvFront;
            //lbCaneS.Text = GVar.gvCaneS;
            lbCaneNo.Text = GVar.gvCaneNo;
        }

        private void rptBill_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (GVar.gvCarryPriceStatus == "1")
            {
                xrPictureBox1.Visible = false;
                xrPictureBox2.Visible = true;
            }
            else
            {
                xrPictureBox1.Visible = true;
                xrPictureBox2.Visible = false;
            }
        }

        private void lbName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
