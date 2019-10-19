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
    public partial class frmOilChange : Form
    {
        public frmOilChange()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadFarpoint();
        }

        private void LoadFarpoint()
        {
            //โหลดข้อมูล
            DataTable DT = new DataTable();
            string lvSQL = "Select * From Cane_OilBillDT inner join Cane_OilBillHD on Cane_OilBillDT.O_DocNo = Cane_OilBillHD.O_DocNo ";

            string lvDateS = txtDateS.Text;
            string lvDateE = txtDateE.Text;
            string lvDocBillS = txtBillS.Text;
            string lvDocBillE = txtBillE.Text;

            if (lvDateS == "" && lvDateE == "" && lvDocBillS == "" && lvDocBillE == "")
            {
                MessageBox.Show("กรุณาระบุวันที่หรือเลขที่บิล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBillS.Focus();
                return;
            }

            else
            {

            }

            if(lvDateS != "")
            {
                string lvDateChkS = Gstr.fncChangeTDate(lvDateS);
                string lvDateChkE = Gstr.fncChangeTDate(lvDateE);
                if (lvDateChkE == "") lvDateChkE = lvDateChkS;

                lvSQL += "Where Cane_OilBillHD.O_Date >= '" + lvDateChkS + "' And Cane_OilBillHD.O_Date <= '" + lvDateChkE + "' ";
            }

            if(lvDocBillS != "")
            {
                string lvBillChkS = lvDocBillS;
                string lvBillChkE = lvDocBillE;
                if (lvBillChkE == "") lvBillChkE = lvBillChkS;

                lvSQL += "And Cane_OilBillHD.O_DocNo >= '" + lvBillChkS + "' And Cane_OilBillHD.O_DocNo <= '" + lvBillChkE + "' ";
            }

            lvSQL += "Order by Cane_OilBillHD.O_DocNo,Cane_OilBillHD.O_Date";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;
            spread1.ActiveSheet.RowCount = 0;
            spread1.ActiveSheet.RowCount = lvNumRow;

            this.Cursor = Cursors.WaitCursor;

            for (int i = 0; i < lvNumRow; i++)
            {
                spread1.ActiveSheet.Cells[i, 0].Text = DT.Rows[i]["O_DocNo"].ToString(); //ร้านค้า
                spread1.ActiveSheet.Cells[i, 1].Text = Gstr.fncChangeSDate(DT.Rows[i]["O_Date"].ToString()); //วันที่
                spread1.ActiveSheet.Cells[i, 2].Text = DT.Rows[i]["O_EmpName"].ToString(); //จำนวน
                spread1.ActiveSheet.Cells[i, 3].Text = DT.Rows[i]["O_Price"].ToString(); //ราคาลิตรละ
                spread1.ActiveSheet.Cells[i, 4].Text = DT.Rows[i]["O_Litter"].ToString(); //ราคารวม
                spread1.ActiveSheet.Cells[i, 5].Text = DT.Rows[i]["O_Total"].ToString(); //ราคารวม
            }
            this.Cursor = Cursors.Default;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDateS.Text = "";
            txtDateE.Text = "";
            txtBillS.Text = "";
            txtBillE.Text = "";
            txtPrice.Text = "";

            int lvNumrow = spread1.ActiveSheet.RowCount;
            for (int i = 0; i < lvNumrow; i++)
            {
                spread1.ActiveSheet.Cells[i, 0].Text = "";
                spread1.ActiveSheet.Cells[i, 1].Text = "";
                spread1.ActiveSheet.Cells[i, 2].Text = "";
                spread1.ActiveSheet.Cells[i, 3].Text = "";
                spread1.ActiveSheet.Cells[i, 4].Text = "";
                spread1.ActiveSheet.Cells[i, 5].Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ยืนยัน
            DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int lvNumrow = spread1.ActiveSheet.RowCount;
            for (int i = 0; i < lvNumrow; i++)
            {
                string lvBill = spread1.ActiveSheet.Cells[i, 0].Text;
                string lvDate = Gstr.fncChangeTDate(spread1.ActiveSheet.Cells[i, 1].Text);
                string lvName = spread1.ActiveSheet.Cells[i, 2].Text;
                double lvPrice = Gstr.fncToDouble(spread1.ActiveSheet.Cells[i, 3].Text);
                double lvLitter = Gstr.fncToDouble(spread1.ActiveSheet.Cells[i, 4].Text);
                double lvTotal = Gstr.fncToDouble(spread1.ActiveSheet.Cells[i, 5].Text);

                if (lvBill == "") break;

                //Update
                string lvSQL = "Update Cane_OilBillDT SET O_Price = '" + lvPrice + "', O_Total = '" + lvTotal + "' Where O_DocNo = '" + lvBill + "' ";
                string lvResult = GsysSQL.fncExecuteQueryData(lvSQL);
            }
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Clear
            txtDateS.Text = "";
            txtDateE.Text = "";
            txtBillS.Text = "";
            txtBillE.Text = "";
            txtPrice.Text = "";

            int lvNumrow2 = spread1.ActiveSheet.RowCount;
            for (int i = 0; i < lvNumrow; i++)
            {
                spread1.ActiveSheet.Cells[i, 0].Text = "";
                spread1.ActiveSheet.Cells[i, 1].Text = "";
                spread1.ActiveSheet.Cells[i, 2].Text = "";
                spread1.ActiveSheet.Cells[i, 3].Text = "";
                spread1.ActiveSheet.Cells[i, 4].Text = "";
                spread1.ActiveSheet.Cells[i, 5].Text = "";
            }
        }

        private void frmOilChange_Load(object sender, EventArgs e)
        {
            txtBillS.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string lvPriceNew = txtPrice.Text;
            int lvNumRow = spread1.ActiveSheet.RowCount;

            for (int i = 0; i < lvNumRow; i++)
            {
                spread1.ActiveSheet.Cells[i, 3].Text = lvPriceNew;
            }
            MessageBox.Show("เปลี่ยนแปลงราคาน้ำมันเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int lvNumRow = spread1.ActiveSheet.RowCount;

            for (int i = 0; i < lvNumRow; i++)
            {
                double lvPrice = Gstr.fncToDouble(spread1.ActiveSheet.Cells[i, 3].Text);
                double lvLiter = Gstr.fncToDouble(spread1.ActiveSheet.Cells[i, 4].Text);
                double lvTotalNew = lvPrice * lvLiter;

                spread1.ActiveSheet.Cells[i, 5].Text = lvTotalNew.ToString();
            }
            MessageBox.Show("คำนวณราคาเสร็จสิ้น กรุณาตรวจสอบความถูกต้องก่อนบันทึก", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAccept_Click(sender, e);
            }
        }
    }
}
