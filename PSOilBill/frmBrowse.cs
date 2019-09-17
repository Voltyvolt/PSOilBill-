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
    public partial class frmBrowse : Form
    {
        public frmBrowse()
        {
            InitializeComponent();
        }

        private void frmBrowse_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        public void LoadData()
        {
            this.Cursor = Cursors.WaitCursor;

            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "";

            if (cmbRecord.Text != "ALL")
            {
                lvSQL += "Select Top "+ cmbRecord.Text + " * from Cane_OilBillHD HD inner join Cane_OilBillDT DT on HD.O_DocNo = DT.O_DocNo Where 1=1 ";
            }
            else
            {
                lvSQL += "Select * from Cane_OilBillHD HD inner join Cane_OilBillDT DT on HD.O_DocNo = DT.O_DocNo Where 1=1 ";
            }

            if (txtSearch.Text != "")
            {
                string lvSearch = txtSearch.Text;
                lvSQL += "And (HD.O_DocS like '%"+ lvSearch + "%' OR HD.O_DocNo like '%" + lvSearch + "%' OR HD.O_Name like '%" + lvSearch + "%' OR HD.O_Quota like '%" + lvSearch + "%' OR HD.O_CarNum like '%" + lvSearch + "%') ";
            }

            if (txtDate.Text != "")
            {
                string lvDateS = Gstr.fncChangeTDate(txtDate.Text);
                string lvDateE = Gstr.fncChangeTDate(txtDate1.Text);

                if (txtDate1.Text == "")
                {
                    lvDateS = lvDateE;
                }

                lvSQL += "And HD.O_Date >= '" + lvDateS + "' And HD.O_Date <= '" + lvDateE +"' ";

            }

            if (txtFront.Text != "")
            {
                lvSQL += "And HD.O_CarFront = '" + txtFront.Text + "' ";
            }

            lvSQL += "And HD.O_Status = '' ";
            lvSQL += "Order by HD.O_DocNo desc ";//by HD.O_CaneNo desc,HD.O_Date,

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;
            sp1.ActiveSheet.RowCount = lvNumRow;
            //HD
            for (int i = 0; i < lvNumRow; i++)
            {
                sp1.ActiveSheet.Cells[i, 0].Text = Gstr.fncChangeSDate(DT.Rows[i]["O_Date"].ToString());
                sp1.ActiveSheet.Cells[i, 1].Text = DT.Rows[i]["O_CarFront"].ToString();
                sp1.ActiveSheet.Cells[i, 2].Text = DT.Rows[i]["O_CaneNo"].ToString();
                sp1.ActiveSheet.Cells[i, 3].Text = DT.Rows[i]["O_Quota"].ToString();
                sp1.ActiveSheet.Cells[i, 4].Text = DT.Rows[i]["O_Name"].ToString();
                sp1.ActiveSheet.Cells[i, 5].Text = DT.Rows[i]["O_CarNum"].ToString();
                sp1.ActiveSheet.Cells[i, 6].Text = DT.Rows[i]["O_DocNo"].ToString();
                sp1.ActiveSheet.Cells[i, 7].Text = DT.Rows[i]["O_Litter"].ToString();
                sp1.ActiveSheet.Cells[i, 8].Text = DT.Rows[i]["O_MeterS"].ToString();
                sp1.ActiveSheet.Cells[i, 9].Text = DT.Rows[i]["O_MeterE"].ToString();
                sp1.ActiveSheet.Cells[i, 10].Text = DT.Rows[i]["O_Time"].ToString();
            }

            txtSearch.Focus();

            this.Cursor = Cursors.Default;
        }

        private void cmbRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void sp1_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            int lvIndex = sp1.ActiveSheet.ActiveRowIndex;
            GVar.gvDocS = sp1.ActiveSheet.Cells[lvIndex, 1].Text;
            GVar.gvDocNo = sp1.ActiveSheet.Cells[lvIndex, 6].Text;

            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtDate.Text = "";
            txtDate1.Text = "";
            txtFront.Text = "";
            txtSearch.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSearch.Focus();
            timer1.Enabled = false;
        }

        private void txtFront_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
