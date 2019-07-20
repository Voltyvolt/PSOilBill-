using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSOilBill
{
    public partial class frmSearchPrint : Form
    {
        public frmSearchPrint()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btnSearch.Enabled = false;

            if (cmbType.Text == "บิลรถโรงงาน")
            {
                fncReportPrint1();
            }
            else
            {
                //รายงานอื่นๆ
                fncReportPrint();
            }
        }

        private void fncReportPrint()
        {
            //ลบข้อมูล
            string lvSQL = "Delete From SysTempOilBill ";
            string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

            //Get Data
            DataTable DT = new DataTable();
            lvSQL = "select O_Name,O_Quota,O_DocS,Cane_OilBillHD.O_DocNo,O_Litter,O_Price,O_Total,O_CarNum,O_CaneNo,O_Date,O_Dept,O_Objective,O_EmpID,O_Type ";
            lvSQL += "from Cane_OilBillHD ";
            lvSQL += "inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo ";
            lvSQL += "where Cane_OilBillDT.O_Item = '01' And O_Status <> 'Cancel' ";

            if (txtDateS.Text != "")
            {
                string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                if (lvDateE == "") lvDateE = lvDateS;

                lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
            }

            if (txtQuotaS.Text != "")
            {
                string lvQS = txtQuotaS.Text;
                string lvQE = txtQuotaE.Text;
                if (lvQE == "") lvQE = lvQS;

                lvSQL += "And O_Quota >= '" + lvQS + "' And O_Quota <= '" + lvQE + "' ";
            }

            if (txtDocS.Text != "")
            {
                string lvDocS = txtDocS.Text;
                string lvDocE = txtDocE.Text;
                if (lvDocE == "") lvDocE = lvDocS;

                lvSQL += "And Cast(Cane_OilBillHD.O_CaneNo as int) >= '" + lvDocS + "' And Cast(Cane_OilBillHD.O_CaneNo as int) <= '" + lvDocE + "' ";
            }

            if (cmbType.Text == "บิลเรียกเก็บค่าบรรทุก")
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo like 'A-%' ";
            }
            else if (cmbType.Text == "บิลน้ำมัน")
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo not like 'A-%' ";
            }
            else if (cmbType.Text == "บิลรถโรงงาน")
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo like 'C-%' ";
            }

            if (txtYear.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Year = '" + txtYear.Text + "' ";
            }

            if (txtDue.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Due = '" + txtDue.Text + "' ";
            }

            if (txtCarNum.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_CarNum like '%" + txtCarNum.Text + "%' ";
            }

            if(txtType.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Type = '" + txtType.Text + "'";
            }

            lvSQL += "Order by Cane_OilBillHD.O_DocNo ";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;

            progressBar1.Maximum = lvNumRow;
            progressBar1.Value = 0;
            //progressBar1.Visible = true;

            for (int i = 0; i < lvNumRow; i++)
            {
                //ตัวแปร
                string lvField1 = DT.Rows[i]["O_Name"].ToString();
                string lvField2 = DT.Rows[i]["O_Quota"].ToString();
                string lvField3 = DT.Rows[i]["O_DocNo"].ToString();
                string lvField4 = Gstr.fncToDouble(DT.Rows[i]["O_Litter"].ToString()).ToString("#,###.#0");
                string lvField5 = Gstr.fncToDouble(DT.Rows[i]["O_Price"].ToString()).ToString("#,###.#0");
                string lvField6 = Gstr.fncToDouble(DT.Rows[i]["O_Total"].ToString()).ToString("#,###.#0");
                string lvField7 = DT.Rows[i]["O_CarNum"].ToString();
                string lvField8 = txtYear.Text;
                string lvField9 = txtKa.Text;
                string lvField10 = "";
                string lvField11 = DT.Rows[i]["O_CaneNo"].ToString();

                if (lvField11 == "035810")
                {

                }

                if (cmbType.Text == "บิลรถโรงงาน") lvField11 = DT.Rows[i]["O_DocNo"].ToString();

                string lvField12 = "ใบรายงานน้ำมันโซล่า";
                string lvField13 = Gstr.fncChangeSDate(DT.Rows[i]["O_Date"].ToString());
                string lvField14 = "";
                string lvField15 = "";
                string lvField16 = "";
                string lvField17 = "";

                if (txtDateS.Text != "" && txtDateE.Text == "")
                    lvField10 = txtDateS.Text;
                else
                {
                    if (txtDateS.Text == txtDateE.Text)
                        lvField10 = txtDateS.Text;
                    else
                        lvField10 = txtDateS.Text + "    ถึง    " + txtDateE.Text;
                }

                if (cmbType.Text == "บิลเรียกเก็บค่าบรรทุก")
                {
                    lvField12 = "ใบรายงานเรียกเก็บค่าบรรทุก";
                    lvField14 = "เลขที่บิลอ้อย";
                    lvField15 = "ชื่อโควตา";
                    lvField16 = "รหัสโควตา";
                    lvField17 = "ใบเบิกเลขที่";
                }
                else if (cmbType.Text == "บิลน้ำมัน")
                {
                    lvField14 = "เลขที่บิลอ้อย";
                    lvField15 = "ชื่อโควตา";
                    lvField16 = "รหัสโควตา";
                    lvField17 = "ใบเบิกเลขที่";
                }
                else if (cmbType.Text == "บิลรถโรงงาน")
                {
                    lvField14 = "เลขที่บิล";
                    lvField15 = "ชื่อ";
                    lvField16 = "รหัสหน่วยงาน";
                    lvField17 = "วัตถุประสงค์";

                    lvField2 = DT.Rows[i]["O_Dept"].ToString();
                    lvField3 = DT.Rows[i]["O_Objective"].ToString();
                }

                //เพิ่ม
                lvSQL = "Insert into SysTempOilBill (S_Fieid1, S_Fieid2, S_Fieid3, S_Fieid4, S_Fieid5, S_Fieid6, S_Fieid7, S_Fieid8, S_Fieid9, S_Fieid10, S_Fieid11, S_Fieid12, S_Fieid13, S_Fieid14, S_Fieid15, S_Fieid16, S_Fieid17) ";
                lvSQL += "Values ('" + lvField1 + "', '" + lvField2 + "', '" + lvField3 + "', '" + lvField4 + "', '" + lvField5 + "', '" + lvField6 + "', '" + lvField7 + "', '" + lvField8 + "', '" + lvField9 + "', '" + lvField10 + "', '" + lvField11 + "', '" + lvField12 + "', '" + lvField13 + "', '" + lvField14 + "', '" + lvField15 + "', '" + lvField16 + "', '" + lvField17 + "')";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                progressBar1.Value += 1;
                Application.DoEvents();
            }

            progressBar1.Value = 0;

            this.Cursor = Cursors.Default;
            btnSearch.Enabled = true;

            //Refresh รายงาน
            rptSumReport Report = new rptSumReport();
            Report.CreateDocument();
            documentViewer1.DocumentSource = Report;
        }

        private void fncReportPrint1()
        {
            //ลบข้อมูล
            string lvSQL = "Delete From SysTemp ";
            string lvResault = GsysSQL.fncExecuteQueryDataAccess(lvSQL);

            //Get Data
            DataTable DT = new DataTable();
            lvSQL = "select O_Name,O_Quota,O_DocS,Cane_OilBillHD.O_DocNo,O_Litter,O_Price,O_Total,O_CarNum,O_CaneNo,O_Date,O_Dept,O_Objective,O_EmpID,O_CarFront,O_MeterS,O_MeterE,Cane_OilBillHD.O_Remark,O_EmpName ";
            lvSQL += "from Cane_OilBillHD ";
            lvSQL += "inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo ";
            lvSQL += "where Cane_OilBillDT.O_Item = '01' And O_Status <> 'Cancel' ";

            if (txtDateS.Text != "")
            {
                string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                if (lvDateE == "") lvDateE = lvDateS;

                lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
            }

            if (txtQuotaS.Text != "")
            {
                string lvQS = txtQuotaS.Text;
                string lvQE = txtQuotaE.Text;
                if (lvQE == "") lvQE = lvQS;

                lvSQL += "And O_Quota >= '" + lvQS + "' And O_Quota <= '" + lvQE + "' ";
            }

            if (txtDocS.Text != "")
            {
                string lvDocS = txtDocS.Text;
                string lvDocE = txtDocE.Text;
                if (lvDocE == "") lvDocE = lvDocS;

                lvSQL += "And Cane_OilBillHD.O_DocNo >= '" + lvDocS + "' And Cane_OilBillHD.O_DocNo <= '" + lvDocE + "' ";
            }

            //เฉพาะบิลโรงงาน
            lvSQL += "And Cane_OilBillHD.O_DocNo like 'C-%' ";

            if (txtYear.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Year = '" + txtYear.Text + "' ";
            }

            if (txtDue.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Due = '" + txtDue.Text + "' ";
            }

            if (txtCarNum.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_CarNum like '%" + txtCarNum.Text + "%' ";
            }

            lvSQL += "Order by Cane_OilBillHD.O_CarFront , Cane_OilBillHD.O_DocNo ";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;

            progressBar1.Maximum = lvNumRow;
            progressBar1.Value = 0;
            //progressBar1.Visible = true;

            for (int i = 0; i < lvNumRow; i++)
            {
                //ตัวแปร
                string lvDate = txtDateS.Text + " - " + txtDateE.Text;
                if (txtDateS.Text == txtDateE.Text)
                    lvDate = txtDateS.Text;

                string lvField1 = lvDate; //วันที่
                string lvField2 = DT.Rows[i]["O_CarFront"].ToString(); //ตู้
                string lvField3 = (i + 1).ToString(); //ลำดับ
                string lvField4 = ""; //นามผู้รับ

                if (DT.Rows[i]["O_EmpID"].ToString() != "")
                    lvField4 = GsysSQL.fncFindEmpFullName(DT.Rows[i]["O_EmpID"].ToString());
                else
                    lvField4 = DT.Rows[i]["O_EmpName"].ToString();

                string lvField5 = Gstr.fncToInt(DT.Rows[i]["O_MeterS"].ToString()).ToString(); //มิเตอร์ ก่อน
                string lvField6 = Gstr.fncToInt(DT.Rows[i]["O_Litter"].ToString()).ToString("#,###"); //จำนวนลิตร
                string lvField7 = Gstr.fncToInt(DT.Rows[i]["O_MeterE"].ToString()).ToString(); //มิเตอร์ หลัง
                string lvField8 = DT.Rows[i]["O_CarNum"].ToString(); //ทะเบียนรถ
                string lvField9 = DT.Rows[i]["O_Remark"].ToString(); //หมายเหตุ
                string lvField10 = DT.Rows[i]["O_DocNo"].ToString(); //เลขที่อ้างอิง
                string lvField11 = Gstr.fncToDouble(DT.Rows[i]["O_Price"].ToString()).ToString(""); //ราคาน้ำมันต่อลิตร

                //เพิ่ม
                lvSQL = "Insert into SysTemp (Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Field10, Field11) ";
                lvSQL += "Values ('" + lvField1 + "', '" + lvField2 + "', '" + lvField3 + "', '" + lvField4 + "', '" + lvField5 + "', '" + lvField6 + "', '" + lvField7 + "', '" + lvField8 + "', '" + lvField9 + "', '" + lvField10 + "', '" + lvField11 + "')";
                lvResault = GsysSQL.fncExecuteQueryDataAccess(lvSQL);

                progressBar1.Value += 1;
                Application.DoEvents();
            }

            progressBar1.Value = 0;

            this.Cursor = Cursors.Default;
            btnSearch.Enabled = true;

            //Refresh รายงาน
            rptReport1 Report = new rptReport1();
            Report.CreateDocument();
            documentViewer1.DocumentSource = Report;
        }

        private void frmSearchPrint_Load(object sender, EventArgs e)
        {
            //ลบข้อมูล
            string lvSQL = "Delete From SysTempOilBill ";
            string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

            txtYear.Text = "61/62";
        }

        private void txtYear_QueryPopUp(object sender, CancelEventArgs e)
        {
            txtYear.Properties.Items.Clear();

            int lvYearNow = DateTime.Now.Year;
            if (lvYearNow < 2500) lvYearNow += 543;
            int lvDiffFirst = 1;
            int lvDiffLast = 2;

            //txtYear.Items.Add("", "");
            for (int i = 0; i < 7; i++)
            {
                int lvFirst = (lvYearNow + lvDiffFirst) - 2500;
                int lvLast = (lvYearNow + lvDiffLast) - 2500;
                string lvValue = lvFirst + "/" + lvLast;
                txtYear.Properties.Items.Add(lvValue);

                lvDiffFirst += -1;
                lvDiffLast += -1;
            }
        }

        private void frmSearchPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btntxt_Click(object sender, EventArgs e)
        {
            if (cmbType.Text != "บิลน้ำมัน")
            {
                MessageBox.Show("ไม่สามารถ Export ข้อมูลได้เนื่องจากต้องเป็นประเภท บิลน้ำมัน เท่านั้น","แจ้งเตือน",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            //Get Data0
            DataTable DT = new DataTable();
            string lvSQL = "select O_Name,O_Quota,O_DocS,Cane_OilBillHD.O_DocNo ,O_Litter,O_Price,O_Total,O_CarNum,O_CaneNo,O_Date,O_Time ";
            lvSQL += "from Cane_OilBillHD ";
            lvSQL += "inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo ";
            lvSQL += "where Cane_OilBillDT.O_Item = '01'  And O_Status <> 'Cancel' ";

            if (txtDateS.Text != "")
            {
                string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                if (lvDateE == "") lvDateE = lvDateS;

                lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
            }

            if (txtQuotaS.Text != "")
            {
                string lvQS = txtQuotaS.Text;
                string lvQE = txtQuotaE.Text;
                if (lvQE == "") lvQE = lvQS;

                lvSQL += "And O_Quota >= '" + lvQS + "' And O_Quota <= '" + lvQE + "' ";
            }

            if (txtDocS.Text != "")
            {
                string lvDocS = txtDocS.Text;
                string lvDocE = txtDocE.Text;
                if (lvDocE == "") lvDocE = lvDocS;

                lvSQL += "And Cast(Cane_OilBillHD.O_CaneNo as int) >= '" + lvDocS + "' And Cast(Cane_OilBillHD.O_CaneNo as int) <= '" + lvDocE + "' ";
            }

            if (cmbType.Text == "บิลเรียกเก็บค่าบรรทุก")
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo like 'A-%' ";
            }
            else if (cmbType.Text == "บิลน้ำมัน")
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo not like 'A-%' ";
            }

            if (txtYear.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Year = '" + txtYear.Text + "' ";
            }

            if (txtDue.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Due = '" + txtDue.Text + "' ";
            }

            lvSQL += "Order by Cast(Cane_OilBillHD.O_CaneNo as int) ";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count + 1;
            
            string[] lines = new string[lvNumRow];
            string lvPeriod = txtDue.Text;
            
            //Header
            lines[0] = "Period,Billno,Quota_no,Date,Amount,Cost";
            for (int i = 1; i < lvNumRow; i++)
            {
                //ตัวแปร
                string lvField1 = GsysSQL.fncFindQuotaName(DT.Rows[i - 1]["O_Name"].ToString());
                string lvField2 = DT.Rows[i - 1]["O_Quota"].ToString();
                string lvField3 = Gstr.fncToInt(DT.Rows[i - 1]["O_CaneNo"].ToString()).ToString();
                string lvField4 = Gstr.fncToDouble(DT.Rows[i - 1]["O_Litter"].ToString()).ToString("");
                string lvField5 = Gstr.fncToDouble(DT.Rows[i - 1]["O_Price"].ToString()).ToString("");
                string lvField6 = Gstr.fncToDouble(DT.Rows[i - 1]["O_Total"].ToString()).ToString("");
                string lvField7 = DT.Rows[i - 1]["O_CarNum"].ToString();
                string lvField8 = txtYear.Text;
                string lvField9 = txtKa.Text;
                string lvField10 = "";
                string lvField11 = DT.Rows[i - 1]["O_CaneNo"].ToString();
                string lvField12 = Gstr.fncChangeSDate(DT.Rows[i - 1]["O_Date"].ToString());
                string lvField13 = DT.Rows[i - 1]["O_Time"].ToString();
                
                // 0 - บิลอ้อย - โควต้า - วันที่ - จำนวนลิตร - จำนวนเงิน
                lines[i] = "0" + "," + lvField3 + "," + lvField2 + "," + lvField12 + " " + lvField13 + "," + lvField4 + "," + lvField6;
            }

            string lvPath = "X:\\FuelData";

            string lvDay = DateTime.Now.ToString("dd");
            string lvMonth = DateTime.Now.ToString("MM");
            string lvYear = DateTime.Now.ToString("yyyy");
            if (Gstr.fncToInt(lvYear) > 2500) lvYear = (Gstr.fncToInt(lvYear) - 543).ToString();
            string lvAll = lvYear + lvMonth + lvDay;

            string lvPathFile = lvPath + "\\"+ lvAll + "#1FuelData.txt";
            if (!Directory.Exists(lvPath))
            {
                Directory.CreateDirectory(lvPath);
            }
                        
            System.IO.File.WriteAllLines(lvPathFile, lines);

            MessageBox.Show("Export ไฟล์เรียบร้อย","Export Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Process.Start(lvPath);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbType.Text = "บิลน้ำมัน";
            txtYear.Text = "";
            txtDue.Text = "";
            txtDateE.Text = "";
            txtDateS.Text = "";
            txtQuotaS.Text = "";
            txtQuotaE.Text = "";
            txtDocS.Text = "";
            txtDocE.Text = "";
        }
    }
}
