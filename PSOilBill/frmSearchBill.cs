using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSOilBill
{
    public partial class frmSearchBill : Form
    {
        public frmSearchBill()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "";

            if (cmbRecord.Text != "ALL")
            {
                lvSQL += "Select Top " + cmbRecord.Text + " * from Queue_Diary Where 1=1 ";
            }
            else
            {
                lvSQL += "Select * from Queue_Diary Where 1=1 ";
            }

            if (txtSearch.Text != "")
            {
                string lvSearch = txtSearch.Text;
                lvSQL += "And (Q_No like '%" + lvSearch + "%' OR Q_CarNum like '%" + lvSearch + "%' OR Q_Quota like '%" + lvSearch + "%' OR Q_BillingNo like '%" + lvSearch + "%') ";
            }

            if (txtDate.Text != "")
            {
                string lvDateS = Gstr.fncChangeTDate(txtDate.Text);
                string lvDateE = Gstr.fncChangeTDate(txtDate1.Text);

                if (txtDate1.Text == "")
                {
                    lvDateS = lvDateE;
                }

                lvSQL += "And Q_WeightOUTDate >= '" + lvDateS + "' And Q_WeightOUTDate <= '" + lvDateE + "' ";
            }

            if (!chkShowAll.Checked)
            {
                lvSQL += "And Q_OilBillNo = '' ";
            }            

            lvSQL += "And Q_BillingNo != '' And Q_Year = '' ";
            lvSQL += "Order by Q_BillingNo DESC";
            //lvSQL += "Order by Q_Date Desc,Q_BillingNo";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;
            sp1.ActiveSheet.RowCount = lvNumRow;
            //HD
            for (int i = 0; i < lvNumRow; i++)
            {
                sp1.ActiveSheet.Cells[i, 0].Text = DT.Rows[i]["Q_BillingNo"].ToString();
                sp1.ActiveSheet.Cells[i, 1].Text = DT.Rows[i]["Q_No"].ToString();
                sp1.ActiveSheet.Cells[i, 2].Text = Gstr.fncChangeSDate(DT.Rows[i]["Q_WeightOUTDate"].ToString()) + " " + DT.Rows[i]["Q_WeightOUTTime"].ToString();
                sp1.ActiveSheet.Cells[i, 3].Text = DT.Rows[i]["Q_Quota"].ToString();
                sp1.ActiveSheet.Cells[i, 4].Text = GsysSQL.fncFindQuotaName(DT.Rows[i]["Q_Quota"].ToString());
                sp1.ActiveSheet.Cells[i, 5].Text = DT.Rows[i]["Q_CarNum"].ToString();
                sp1.ActiveSheet.Cells[i, 6].Text = DT.Rows[i]["Q_SampleNo"].ToString();
            }

            txtSearch.Focus();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }

        private void sp1_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            GVar.gvSCode = sp1.ActiveSheet.Cells[e.Row, 0].Text;
            GVar.gvSName = sp1.ActiveSheet.Cells[e.Row, 1].Text;
            GVar.gvQuota = sp1.ActiveSheet.Cells[e.Row, 3].Text;
            GVar.gvCarNum = sp1.ActiveSheet.Cells[e.Row, 5].Text;
            GVar.gvSampleNo = sp1.ActiveSheet.Cells[e.Row, 6].Text;

            this.Close();
        }

        private void frmSearchBill_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSearch.Focus();
            timer1.Enabled = false;
        }

        private void cmbRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chkShowAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
