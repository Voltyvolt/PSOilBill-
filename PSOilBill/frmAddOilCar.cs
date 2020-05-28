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
    public partial class frmAddOilCar : Form
    {
        string pvMode = "";

        public frmAddOilCar()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lvSQL = "";
            string lvResult = "";
            string lvPK = GVar.gvPass;
            string lvName = txtName.Text;
            string lvCarName = txtCarName.Text;
            string lvBudjet = txtBudjet.Text;
            string lvAsset = txtAsset.Text;
            string lvSecID = cmbDept.Text;
            string lvSecName = txtDeptName.Text;
            string lvCarnumS = txtCarNumS.Text;
            string lvCarNumE = txtCarNumE.Text;
            string lvCarNum = lvCarnumS + "." + lvCarNumE;

            try
            {
                if (pvMode == "New")
                {
                    lvSQL = "Insert Into MiniCane_OilCar (M_Budjet, M_Name, M_Asset, M_CarName, M_CarNum, M_SecID, M_SecName) ";
                    lvSQL += "Values ('" + lvBudjet + "', '" + lvName + "', '" + lvAsset + "', '" + lvCarName + "', '" + lvCarNum + "', '" + lvSecID + "', '" + lvSecName + "')";
                    lvResult = GsysSQL.fncExecuteQueryData(lvSQL);

                    MessageBox.Show("บันทึกข้อมูลสำเร็จ!", "แจ้งเตือน!", MessageBoxButtons.OK);
                }

                if(pvMode == "Edit")
                {
                    lvSQL = "Update MiniCane_OilCar SET M_Budjet = '" + lvBudjet + "', M_Name = '" + lvName + "', M_Asset = '" + lvAsset + "', M_CarName = '" + lvCarName + "', M_Carnum = '" + lvCarNum + "', M_SecID = '" + lvSecID + "', M_SecName = '" + lvSecName + "' Where M_PK = '" + lvPK + "' ";
                    lvResult = GsysSQL.fncExecuteQueryData(lvSQL);

                    MessageBox.Show("บันทึกข้อมูลสำเร็จ!", "แจ้งเตือน!", MessageBoxButtons.OK);
                }

                fncClearData();
                pvMode = "";
                groupBox2.Enabled = false;
                fncLoadDT();
            }
            catch(Exception ex)
            {
                MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ!" + " " + ex.ToString(), "แจ้งเตือน!", MessageBoxButtons.OK);
                return;
            }
            
        }

        private void frmAddOilCar_Load(object sender, EventArgs e)
        {
            fncLoadDT();

            groupBox2.Enabled = false;
        }

        private void fncClearData()
        {
            txtName.Text = "";
            txtBudjet.Text = "";
            txtAsset.Text = "";
            txtCarNumS.Text = "";
            txtCarNumE.Text = "";
            cmbDept.Text = "";
            txtDeptName.Text = "";
            txtCarName.Text = "";
        }

        private void fncLoadDT()
        {
            this.Cursor = Cursors.WaitCursor;

            DataTable DT = new DataTable();
            string lvSQL = "Select * From MiniCane_OilCar Where 1=1 ";

            if(txtDeptSrc.Text != "")
            {
                lvSQL += "And M_SecID like '%" + txtDeptSrc.Text + "%' ";
            }

            if(txtBudjetSrc.Text != "")
            {
                lvSQL += "And M_Budjet like '%" + txtBudjetSrc.Text + "%' ";
            }

            if(txtAssetSrc.Text != "")
            {
                lvSQL += "And M_Asset like '%" + txtAssetSrc.Text + "%' ";
            }

            if(txtCarnumSrc.Text != "")
            {
                lvSQL += "And M_CarNum like '%" + txtCarnumSrc.Text + "%' ";
            }

            lvSQL += "Order By M_SecID ASC";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;
            fp1.ActiveSheet.RowCount = lvNumRow;

            for (int i = 0; i < lvNumRow; i++)
            {
                fp1.ActiveSheet.Cells[i, 0].Text = DT.Rows[i]["M_PK"].ToString();
                fp1.ActiveSheet.Cells[i, 1].Text = DT.Rows[i]["M_Budjet"].ToString();
                fp1.ActiveSheet.Cells[i, 2].Text = DT.Rows[i]["M_Name"].ToString();
                fp1.ActiveSheet.Cells[i, 3].Text = DT.Rows[i]["M_Asset"].ToString();
                fp1.ActiveSheet.Cells[i, 4].Text = DT.Rows[i]["M_CarName"].ToString();
                fp1.ActiveSheet.Cells[i, 5].Text = DT.Rows[i]["M_CarNum"].ToString();
                fp1.ActiveSheet.Cells[i, 6].Text = DT.Rows[i]["M_SecID"].ToString();
                fp1.ActiveSheet.Cells[i, 7].Text = DT.Rows[i]["M_SecName"].ToString();
            }

            this.Cursor = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fncLoadDT();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDeptSrc.Text = "";
            txtBudjetSrc.Text = "";
            txtAssetSrc.Text = "";
            txtCarnumSrc.Text = "";

            fncLoadDT();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            pvMode = "New";
        }

        private void fp1_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if(e.Column == 8)
            {
                pvMode = "Edit";
                groupBox2.Enabled = true;

                GVar.gvPass = fp1.ActiveSheet.Cells[e.Row, 0].Text;
                string lvBudjet = fp1.ActiveSheet.Cells[e.Row, 1].Text;
                string lvName = fp1.ActiveSheet.Cells[e.Row, 2].Text;
                string lvAsset = fp1.ActiveSheet.Cells[e.Row, 3].Text;
                string lvCarName = fp1.ActiveSheet.Cells[e.Row, 4].Text;
                string lvCarnum = fp1.ActiveSheet.Cells[e.Row, 5].Text;
                string lvDept = fp1.ActiveSheet.Cells[e.Row, 6].Text;
                string lvDeptName = fp1.ActiveSheet.Cells[e.Row, 7].Text;

                txtName.Text = lvName;
                txtCarName.Text = lvCarName;
                txtAsset.Text = lvAsset;
                txtBudjet.Text = lvBudjet;
                if (lvCarnum != "")
                {
                    string[] lvArr = lvCarnum.Split('.');
                    txtCarNumS.Text = lvArr[0];
                    txtCarNumE.Text = lvArr[1];
                }
                else
                {
                    txtCarNumS.Text = "";
                    txtCarNumS.Text = "";
                }
                cmbDept.Text = lvDept;
                txtDeptName.Text = lvDeptName;
            }

            if(e.Column == 9)
            {
                DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    string lvPK = fp1.ActiveSheet.Cells[e.Row, 0].Text;
                    string lvSQL = "Delete From MiniCane_OilCar Where M_PK = '" + lvPK + "' ";
                    string lvResult = GsysSQL.fncExecuteQueryData(lvSQL);

                    MessageBox.Show("ลบทะเบียนสำเร็จ!", "แจ้งเตือน!", MessageBoxButtons.OK);
                    fncLoadDT();
                }  
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            fncClearData();
            pvMode = "";
            groupBox2.Enabled = false;
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDeptName.Text = GsysSQL.fncFindFactionName(cmbDept.Text);
        }
    }
}