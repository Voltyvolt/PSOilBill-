using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string lvKa = txtKa.Text;
            string lvDue = txtDue.Text;
            string lvDateS = txtDateS.Text;
            string lvDateE = txtDateE.Text;
            string lvQuotaS = txtQuotaS.Text;
            string lvQuotaE = txtQuotaE.Text;
            string lvDocS = txtDocS.Text;
            string lvDocE = txtDocE.Text;
            string lvDocBillE = txtDocBillE.Text;
            string lvDocBillS = txtDocBillS.Text;
            string lvCarNum = txtCarNum.Text;
            string lvType = txtType.Text;

            if(lvKa == "" && lvDue == "" && lvDateS == "" && lvDateS == "" && lvDateE == "" && lvQuotaS == "" && lvQuotaE == "" && lvDocS == "" && lvDocE == "" && lvDocBillS == "" && lvDocBillE == "" && lvCarNum == "" && lvType == "")
            {
                DialogResult dialogResultP = MessageBox.Show("ต้องการพิมพ์ใบเสร็จหรือไม่?", "Confirm?", MessageBoxButtons.YesNo);
                if (dialogResultP == DialogResult.No)
                {
                    return;
                }
                else
                {

                }
            }

            this.Cursor = Cursors.WaitCursor;
            btnSearch.Enabled = false;

            //รับค่าบิล
            string lvInS = txtDocBillS.Text;

            string ChklvInS = Gstr.Left(lvInS, 2);

            if(txtDocBillS.Text != "")
            {
                //เช็ครูปแบบ
                if (ChklvInS != "A-" && ChklvInS != "C-")
                {
                    cmbType.Text = "บิลน้ำมัน";
                }

                else if (ChklvInS == "A-")
                {
                    cmbType.Text = "บิลเรียกเก็บค่าบรรทุก";
                }

                else if (ChklvInS == "C-")
                {
                    cmbType.Text = "น้ำมันโซล่าประจำวัน";
                }
            }

            //สั่งพิมพ์
            if (cmbType.Text == "น้ำมันโซล่าประจำวัน")
            {
                //fncReportPrint1();
                fncReportPrint2();
            }

            else if (cmbType.Text == "บิลรวมแบบละเอียด")
            {
                //fncReportPrint1();
                fncReportPrint3();
            }

            else if (cmbType.Text == "บิลรวม")
            {
                //fncReportPrint1();
                fncReportPrint4();
            }

            else if (cmbType.Text == "บิลรวมรายทะเบียน")
            {
                fncReportPrint5();
            }

            else
            {
                //รายงานอื่นๆ
                fncReportPrint();
            }
            this.Cursor = Cursors.Default;
        }

        private void fncReportPrint()
        {
            //ลบข้อมูล
            string lvSQL = "Delete From SysTempOilBill ";
            string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

            //Get Data
            DataTable DT = new DataTable();
            lvSQL = "select O_Name,O_Quota,O_DocS,Cane_OilBillHD.O_DocNo,O_Litter,O_Price,O_Total,O_CarNum,O_CaneNo,O_RealDate,O_Date,O_Dept,O_Objective,O_EmpID,O_Type ";
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

            if (txtDocBillS.Text != "")
            {
                string lvDocBillS = txtDocBillS.Text;
                string lvDocBillE = txtDocBillE.Text;

                if (lvDocBillE == "") lvDocBillE = lvDocBillS;
                lvSQL += "And Cane_OilBillHD.O_DocNo  >= '" + lvDocBillS + "' And Cane_OilBillHD.O_DocNo <= '" + lvDocBillE + "' ";
            }

            if (cmbType.Text == "บิลเรียกเก็บค่าบรรทุก")
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo like 'A-%' ";
            }
            else if (cmbType.Text == "บิลน้ำมัน")
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo not like 'A-%' And Cane_OilBillHD.O_DocNo not like 'C-%'";
            }
            else if (cmbType.Text == "น้ำมันโซล่าประจำวัน")
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo like 'C-%' ";
            }

            if (txtYear.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Year = '' ";
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

                if (cmbType.Text == "น้ำมันโซล่าประจำวัน") lvField11 = DT.Rows[i]["O_DocNo"].ToString();

                string lvField12 = "ใบรายงานน้ำมันโซล่า";
                string lvField13 = Gstr.fncChangeSDate(DT.Rows[i]["O_RealDate"].ToString());
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
                else if (cmbType.Text == "น้ำมันโซล่าประจำวัน")
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

            if (cmbDept.Text != "")
            {
                lvSQL += "And Cane.OilBillHD.O_Dept = '" + cmbDept.Text + "' ";
            }

            if (txtBudjet.Text != "")
            {
                lvSQL += "And Cane.OilBillHD.O_Budjet like '%" + txtBudjet.Text + "%'";
            }
            if (txtAsset.Text != "")
            {
                lvSQL += "And Cane.OilBillHD.O_Asset like '%" + txtAsset.Text + "%' ";
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

        private void fncReportPrint2()
        {
            //ลบข้อมูล
            string lvSQL = "Delete From SysTemp";
            string lvResault = GsysSQL.fncExecuteQueryDataAccess(lvSQL);

            ////Get Data
            DataTable DT = new DataTable();
            lvSQL = "select O_Name,O_Quota,O_DocS,Cane_OilBillHD.O_DocNo,O_Litter,O_Price,O_Total,O_CarNum,O_CaneNo,O_Date,O_Dept,O_Objective,O_EmpID,O_CarFront,O_MeterS,O_MeterE,Cane_OilBillHD.O_Remark,O_EmpName,O_PdIn,O_PdOut,O_Type,O_Budjet,O_Asset,O_CarnumS6,O_CarnumE6,O_Time ";
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

            //if (txtDocS.Text != "")
            //{
            //    string lvDocS = txtDocS.Text;
            //    string lvDocE = txtDocE.Text;
            //    if (lvDocE == "") lvDocE = lvDocS;


            //    lvSQL += "And Cane_OilBillHD.O_DocNo >= '" + lvDocS + "' And Cane_OilBillHD.O_DocNo <= '" + lvDocE + "' ";
            //}

            if (txtDocBillS.Text != "")
            {
                string lvDocBillS = txtDocBillS.Text;
                string lvDocBillE = txtDocBillE.Text;

                if (lvDocBillE == "") lvDocBillE = lvDocBillS;
                lvSQL += "And Cane_OilBillHD.O_DocNo  >= '" + lvDocBillS + "' And Cane_OilBillHD.O_DocNo <= '" + lvDocBillE + "' ";
            }

            //เฉพาะบิลโรงงาน
            lvSQL += "And Cane_OilBillHD.O_DocNo like 'C-%' ";

            if (txtYear.Text != "" && txtYear.Text == "64/65")
            {
                lvSQL += "And Cane_OilBillHD.O_Year = '' ";
            }
            else if(txtYear.Text != "")
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

            if(txtType.Text != "หน่วยงาน" && txtType.Text != "ชื่อลูกค้า/ร้านค้า" && txtType.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Type = '" + txtType.Text + "' ";
            }

            if(cmbDept.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Dept = '" + cmbDept.Text + "' ";
            }

            if(txtBudjet.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Budjet like '%" + txtBudjet.Text + "%'";
            }
            if(txtAsset.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Asset like '%" + txtAsset.Text + "%' ";
            }

            //lvSQL += "And Cane_OilBillHD.O_Type = 'รถบริษัท' ";

            lvSQL += "Order by Cane_OilBillHD.O_Dept ";

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

                string lvField5 = "";
                string lvField7 = "";
                string lvNameChk = DT.Rows[i]["O_Name"].ToString();
                if (lvNameChk == "บรรทุกน้ำตาล (สยามศรี)")
                {
                    lvField5 = "";
                    lvField7 = "";
                }
                else
                {
                    lvField5 = Gstr.fncToInt(DT.Rows[i]["O_MeterS"].ToString()).ToString(); //มิเตอร์ ก่อน
                    lvField7 = Gstr.fncToInt(DT.Rows[i]["O_MeterE"].ToString()).ToString(); //มิเตอร์ หลัง
                }
                
                double lvNum3 = Gstr.fncToInt(DT.Rows[i]["O_Litter"].ToString()); //จำนวนลิตร
                string lvField8 = DT.Rows[i]["O_CarNum"].ToString(); //ทะเบียนรถ
                string lvField9 = DT.Rows[i]["O_Remark"].ToString(); //หมายเหตุ
                string lvField10 = DT.Rows[i]["O_DocNo"].ToString(); //เลขที่อ้างอิง
                double lvNum1 = Gstr.fncToDouble(DT.Rows[i]["O_Price"].ToString()); //ราคาน้ำมันต่อลิตร
                string lvField12 = DT.Rows[i]["O_PdIN"].ToString(); //ใบรับ
                string lvField13 = DT.Rows[i]["O_PdOut"].ToString(); //ใบสั่งจ่าย
                string lvField14 = DT.Rows[i]["O_Budjet"].ToString(); //รหัสงบประมาณ
                string lvField15 = DT.Rows[i]["O_Asset"].ToString(); //รหัสทรัพย์สิน
                string lvField16 = "";

                if(txtType.Text == "หน่วยงาน")
                {
                    lvField16 = DT.Rows[i]["O_Name"].ToString(); //หน่วยงาน
                }

                else if(txtType.Text == "ชื่อลูกค้า/ร้านค้า")
                {
                    lvField16 = DT.Rows[i]["O_EmpName"].ToString(); //ชื่อร้านค้า
                }
                else
                {
                    lvField16 = DT.Rows[i]["O_Type"].ToString(); //ประเภทรถ
                }
                
                string lvField17 = DT.Rows[i]["O_Name"].ToString(); //ชื่อหน่วยงาน
                string lvField18 = DT.Rows[i]["O_CarnumS6"].ToString(); //อักษรรถ
                string lvField19 = DT.Rows[i]["O_CarnumE6"].ToString(); //ทะเบียนรถ
                double lvNum2 = Gstr.fncToDouble(DT.Rows[i]["O_Total"].ToString()); //ราคารวม
                string lvField21 = DT.Rows[i]["O_DocNo"].ToString(); //เลขเอกสาร
                string lvField22 = DT.Rows[i]["O_Dept"].ToString(); //รหัส
                string lvField23 = Gstr.fncChangeSDate(DT.Rows[i]["O_Date"].ToString()); //ประเภทรถ
                string lvField6 = DT.Rows[i]["O_Time"].ToString(); //เวลา
                string lvField24 = txtDateS.Text;
                string lvField25 = txtDateE.Text;

                //เพิ่ม
                lvSQL = "Insert into SysTemp (Field1, Field2, Field3, Field4, Field5, Num3, Field7, Field8, Field9, Field10, Num1, Field12, Field13, Field14, Field15, Field16, Field17, Field18, Field19, Num2, Field21, Field22, Field23, Field6, Field24, Field25) ";
                lvSQL += "Values ('" + lvField1 + "', '" + lvField2 + "', '" + lvField3 + "', '" + lvField4 + "', '" + lvField5 + "', '" + lvNum3 + "', '" + lvField7 + "', '" + lvField8 + "', '" + lvField9 + "', '" + lvField10 + "', '" + lvNum1 + "', '" + lvField12 + "', '" + lvField13 + "', '" + lvField14 + "', '" + lvField15 + "', '" + lvField16 + "', '" + lvField17 + "', '" + lvField18 + "', '" + lvField19 + "', '" + lvNum2 + "',  '" + lvField21 + "', '" + lvField22 + "', '" + lvField23 + "', '" + lvField6 + "', '" + lvField24 + "', '" + lvField25 + "')";
                lvResault = GsysSQL.fncExecuteQueryDataAccess(lvSQL);

                progressBar1.Value += 1;
                Application.DoEvents();
            }

            progressBar1.Value = 0;

            this.Cursor = Cursors.Default;
            btnSearch.Enabled = true;

            //Refresh รายงาน
            newrptX Report = new newrptX();
            Report.CreateDocument();
            documentViewer1.DocumentSource = Report;
        }

        private void fncReportPrint3()
        {
            string lvSQL = "Delete From SysTemp";
            string lvResult = GsysSQL.fncExecuteQueryDataAccess(lvSQL);

            try
            {
                this.Cursor = Cursors.WaitCursor;

                // DT2
                DataTable DT2 = new DataTable();
                lvSQL = "SELECT * FROM Cane_OilBillHD inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo where Cane_OilBillDT.O_Item = '01' And O_Status <> 'Cancel' And Cane_OilBillHD.O_DocNo Not Like '%A-%' And Cane_OilBillHD.O_DocNo Not Like '%C-%' And O_Year = '' ";

                if (txtDateS.Text != "")
                {
                    string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                    string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                    if (lvDateE == "") lvDateE = lvDateS;

                    lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
                }

                if(cmbDept.Text != "")
                {
                    lvSQL += "And O_Dept = '" + cmbDept.Text + "' ";
                }

                DT2 = GsysSQL.fncGetQueryData(lvSQL, DT2);

                int lvNumRow2 = DT2.Rows.Count;

                for (int i = 0; i < lvNumRow2; i++)
                {
                    //ตัวแปร
                    string lvDate = Gstr.fncChangeSDate(DT2.Rows[i]["O_Date"].ToString());
                    string lvField1 = lvDate; //วันที่
                    string lvField2 = DT2.Rows[i]["O_Price"].ToString();
                    string lvField3 = DT2.Rows[i]["O_Name"].ToString();
                    double Num1 = Gstr.fncToDouble(DT2.Rows[i]["O_Litter"].ToString());

                    lvSQL = "Insert Into SysTemp (Field1,Field2,Field3,Num1) Values ('" + lvField1 + "','" + lvField2 + "','" + lvField3 + "','" + Num1 + "')";
                    lvResult = GsysSQL.fncExecuteQueryDataAccess(lvSQL);
                }

                //DT3
                DataTable DT3 = new DataTable();
                lvSQL = "SELECT* FROM Cane_OilBillHD inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo where Cane_OilBillDT.O_Item = '01' And O_Status<> 'Cancel' And Cane_OilBillHD.O_DocNo Like '%A-%' And O_Year = '' ";

                if (txtDateS.Text != "")
                {
                    string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                    string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                    if (lvDateE == "") lvDateE = lvDateS;

                    lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
                }

                if (cmbDept.Text != "")
                {
                    lvSQL += "And O_Dept = '" + cmbDept.Text + "' ";
                }

                DT3 = GsysSQL.fncGetQueryData(lvSQL, DT3);

                int lvNumRow3 = DT3.Rows.Count;

                for (int i = 0; i < lvNumRow3; i++)
                {
                    //ตัวแปร
                    string lvDate = Gstr.fncChangeSDate(DT3.Rows[i]["O_Date"].ToString());
                    string lvField1 = lvDate;
                    string lvField2 = DT3.Rows[i]["O_Price"].ToString();
                    string lvField3 = DT3.Rows[i]["O_Name"].ToString();
                    double Num2 = Gstr.fncToDouble(DT3.Rows[i]["O_Litter"].ToString());

                    lvSQL = "Insert Into SysTemp (Field1,Field2,Field3,Num2) Values ('" + lvField1 + "','" + lvField2 + "','" + lvField3 + "','" + Num2 + "')";
                    lvResult = GsysSQL.fncExecuteQueryDataAccess(lvSQL);
                }

                //DT4
                DataTable DT4 = new DataTable();
                lvSQL = "SELECT * FROM Cane_OilBillHD inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo where Cane_OilBillDT.O_Item = '01' And Cane_OilBillHD.O_DocNo Not Like '%C-%' And O_Year = '' ";

                if (txtDateS.Text != "")
                {
                    string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                    string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                    if (lvDateE == "") lvDateE = lvDateS;

                    lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
                }

                if (cmbDept.Text != "")
                {
                    lvSQL += "And O_Dept = '" + cmbDept.Text + "' ";
                }

                DT4 = GsysSQL.fncGetQueryData(lvSQL, DT4);

                int lvNumRow4 = DT4.Rows.Count;

                for (int i = 0; i < lvNumRow4; i++)
                {
                    string lvDate = Gstr.fncChangeSDate(DT4.Rows[i]["O_Date"].ToString());
                    string lvField1 = lvDate;
                    string lvField2 = DT4.Rows[i]["O_Price"].ToString();
                    string lvField3 = DT4.Rows[i]["O_Name"].ToString();
                    double Num3 = Gstr.fncToDouble(DT4.Rows[i]["O_Total"].ToString());

                    lvSQL = "Insert Into SysTemp (Field1,Field2,Field3,Num3) Values ('" + lvField1 + "','" + lvField2 + "','" + lvField3 + "','" + Num3 + "')";
                    lvResult = GsysSQL.fncExecuteQueryDataAccess(lvSQL);
                }

                //DT5
                DataTable DT5 = new DataTable();
                lvSQL = "SELECT * From Cane_OilBillHD inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo where Cane_OilBillDT.O_Item = '01' And Cane_OilBillHD.O_Type = 'รถบริษัท' And Cane_OilBillHD.O_DocNo Like '%C-%' And O_Year = '' ";
                if (txtDateS.Text != "")
                {
                    string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                    string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                    if (lvDateE == "") lvDateE = lvDateS;

                    lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
                }

                if (cmbDept.Text != "")
                {
                    lvSQL += "And O_Dept = '" + cmbDept.Text + "' ";
                }

                DT5 = GsysSQL.fncGetQueryData(lvSQL, DT5);

                int lvNumRow5 = DT5.Rows.Count;

                for (int i = 0; i < lvNumRow5; i++)
                {
                    //ตัวแปร
                    string lvDate = Gstr.fncChangeSDate(DT5.Rows[i]["O_Date"].ToString());
                    string lvField1 = lvDate;
                    string lvField2 = DT5.Rows[i]["O_Price"].ToString();
                    string lvField3 = DT5.Rows[i]["O_Name"].ToString();
                    double Num4 = Gstr.fncToDouble(DT5.Rows[i]["O_Litter"].ToString());
                    double Num5 = Gstr.fncToDouble(DT5.Rows[i]["O_Total"].ToString());

                    lvSQL = "Insert Into SysTemp (Field1,Field2,Field3, Num4, Num5) Values ('" + lvField1 + "','" + lvField2 + "','" + lvField3 + "','" + Num4 + "', '" + Num5 + "')";
                    lvResult = GsysSQL.fncExecuteQueryDataAccess(lvSQL);
                }

                //DT6
                DataTable DT6 = new DataTable();
                lvSQL = "SELECT * From Cane_OilBillHD inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo where Cane_OilBillDT.O_Item = '01' And Cane_OilBillHD.O_Type = 'รับเหมา' And Cane_OilBillHD.O_DocNo Like '%C-%' And O_Year = '' ";
                if (txtDateS.Text != "")
                {
                    string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                    string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                    if (lvDateE == "") lvDateE = lvDateS;

                    lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
                }

                if (cmbDept.Text != "")
                {
                    lvSQL += "And O_Dept = '" + cmbDept.Text + "' ";
                }
                 
                DT6 = GsysSQL.fncGetQueryData(lvSQL, DT6);

                int lvNumRow6 = DT6.Rows.Count;

                for (int i = 0; i < lvNumRow6; i++)
                {
                    //ตัวแปร
                    string lvDate = Gstr.fncChangeSDate(DT6.Rows[i]["O_Date"].ToString());
                    string lvField1 = lvDate;
                    string lvField2 = DT6.Rows[i]["O_Price"].ToString();
                    string lvField3 = DT6.Rows[i]["O_Name"].ToString();
                    double Num6 = Gstr.fncToDouble(DT6.Rows[i]["O_Litter"].ToString());
                    double Num7 = Gstr.fncToDouble(DT6.Rows[i]["O_Total"].ToString());

                    lvSQL = "Insert Into SysTemp (Field1,Field2,Field3, Num6, Num7) Values ('" + lvField1 + "','" + lvField2 + "','" + lvField3 + "', '" + Num6 + "', '" + Num7 + "')";
                    lvResult = GsysSQL.fncExecuteQueryDataAccess(lvSQL);
                }

                this.Cursor = Cursors.Default;
                btnSearch.Enabled = true;

                //Refresh รายงาน
                rptTotal Report = new rptTotal();
                Report.CreateDocument();
                documentViewer1.DocumentSource = Report;
            }
            catch(Exception ex)
            {

            }
        }

        private void fncReportPrint4()
        {
            string lvSQL = "Delete From SysTemp";
            string lvResult = GsysSQL.fncExecuteQueryDataAccess(lvSQL);

            try
            {
                this.Cursor = Cursors.WaitCursor;

                // DT
                DataTable DT2 = new DataTable();
                lvSQL = "SELECT * FROM Cane_OilBillHD inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo where Cane_OilBillDT.O_Item = '01' And O_Status <> 'Cancel' And O_Year = '' ";

                if (txtDateS.Text != "")
                {
                    string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                    string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                    if (lvDateE == "") lvDateE = lvDateS;

                    lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
                }

                if (cmbDept.Text != "")
                {
                    lvSQL += "And O_Dept = '" + cmbDept.Text + "' ";
                }

                DT2 = GsysSQL.fncGetQueryData(lvSQL, DT2);

                int lvNumRow2 = DT2.Rows.Count;

                for (int i = 0; i < lvNumRow2; i++)
                {
                    //ตัวแปร
                    string lvDate = Gstr.fncChangeSDate(DT2.Rows[i]["O_Date"].ToString());
                    string lvField1 = lvDate; //วันที่
                    string lvField2 = DT2.Rows[i]["O_Price"].ToString();
                    string lvField3 = DT2.Rows[i]["O_Name"].ToString();
                    string lvField4 = DT2.Rows[i]["O_Dept"].ToString();
                    string lvField5 = Gstr.fncChangeTDate(lvDate);
                    string lvField6 = DT2.Rows[i]["O_CarNum"].ToString();
                    string lvMonthsort = Gstr.Left(lvField5, 6);
                    double Num1 = Gstr.fncToDouble(DT2.Rows[i]["O_Litter"].ToString());
                    double Num2 = Gstr.fncToDouble(DT2.Rows[i]["O_Price"].ToString());

                    lvSQL = "Insert Into SysTemp (Field1,Field2,Field3,Field4,Field5,Field6,Num1,Num2,Field7) Values ('" + lvField1 + "','" + lvField2 + "','" + lvField3 + "','" + lvField4 + "','" + lvField5 + "','" + lvMonthsort + "','" + Num1 + "','" + Num2 + "','" + lvField6 + "')";
                    lvResult = GsysSQL.fncExecuteQueryDataAccess(lvSQL);
                }

                this.Cursor = Cursors.Default;
                btnSearch.Enabled = true;

                //Refresh รายงาน
                rptTotal2_1 Report = new rptTotal2_1();
                Report.CreateDocument();
                documentViewer1.DocumentSource = Report;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void fncReportPrint5()
        {
            string lvSQL = "Delete From SysTemp";
            string lvResult = GsysSQL.fncExecuteQueryData(lvSQL);

            try
            {
                this.Cursor = Cursors.WaitCursor;

                //DataTable DT = new DataTable();
                //lvSQL = "SELECT* FROM Cane_OilBillHD inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo where Cane_OilBillDT.O_Item = '01' And O_Status<> 'Cancel' ";

                ////if (txtDateS.Text != "")
                ////{
                ////    string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                ////    string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                ////    if (lvDateE == "") lvDateE = lvDateS;

                ////    lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
                ////}

                //if (cmbDept.Text != "")
                //{
                //    lvSQL += "And O_Dept = '" + cmbDept.Text + "' ";
                //}

                //DT = GsysSQL.fncGetQueryData(lvSQL, DT);

                string lvDate = "";
                string lvCarnum = "";
                string lvDept = "";
                string lvDeptName = "";
                string lvDatesort = "";
                string lvMonthsort = "";
                string lvCanecarnum = "";
                double lvLitterM = 0;
                double lvLitterY = 0;
                double lvTotalM = 0;
                double lvTotalY = 0;
                double lvPrice = 0;

                //int lvNumRow = DT.Rows.Count;
                //for (int i = 0; i < lvNumRow; i++)
                //{
                //    lvDate = Gstr.fncChangeSDate(DT.Rows[i]["O_Date"].ToString());
                //    lvCarnum = DT.Rows[i]["O_CarNum"].ToString();
                //    lvDept = DT.Rows[i]["O_Dept"].ToString();
                //    lvDeptName = DT.Rows[i]["O_Name"].ToString();
                //    lvLitter = Gstr.fncToDouble(DT.Rows[i]["O_Litter"].ToString());
                //    lvTotal = Gstr.fncToDouble(DT.Rows[i]["O_Total"].ToString());
                //    lvPrice = Gstr.fncToDouble(DT.Rows[i]["O_Price"].ToString());

                //    lvSQL = "Insert Into SysTemp (S_Fieid1, S_Fieid2, S_Fieid3, S_Fieid4, S_Num1, S_Num2, S_Num7) Values ('" + lvDate + "', '" + lvCarnum + "', '" + lvDept + "', '" + lvDeptName + "', '" + lvLitter + "', '" + lvTotal + "', '" + lvPrice + "')";
                //    lvResult = GsysSQL.fncExecuteQueryData(lvSQL);
                //}

                DataTable DT2 = new DataTable();
                lvSQL = "SELECT * From Cane_OilBillHD inner JOIN Cane_OilBillDT ON Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo inner join Cane_Oilmonth ON Cane_OilBillHD.O_DocNo = Cane_Oilmonth.Cane_DocNo inner join Cane_Oilyear ON Cane_OilBillHD.O_DocNo = Cane_Oilyear.Cane_DocNo where Cane_OilBillDT.O_Item = '01' And O_Status <> 'Cancel' And O_Year <> '62/63' ";

                if (txtDateS.Text != "")
                {
                    string lvDateS = Gstr.fncChangeTDate(txtDateS.Text);
                    string lvDateE = Gstr.fncChangeTDate(txtDateE.Text);
                    if (lvDateE == "") lvDateE = lvDateS;

                    lvSQL += "And O_Date >= '" + lvDateS + "' And O_Date <= '" + lvDateE + "' ";
                }

                if (cmbDept.Text != "")
                {
                    lvSQL += "And O_Dept = '" + cmbDept.Text + "' ";
                }
                else
                {
                    lvSQL += "And O_Dept <> '' ";
                }

                if(txtCarNum.Text != "")
                {
                    lvSQL += "And O_CarNum = '" + txtCarNum.Text + "' ";
                }

                DT2 = GsysSQL.fncGetQueryData(lvSQL, DT2);

                int lvNumRow2 = DT2.Rows.Count;
                for (int i = 0; i < lvNumRow2; i++)
                {
                    lvDate = Gstr.fncChangeSDate(DT2.Rows[i]["O_Date"].ToString());
                    lvCarnum = DT2.Rows[i]["O_CarNum"].ToString().Trim();
                    lvDept = DT2.Rows[i]["O_Dept"].ToString();
                    lvDeptName = DT2.Rows[i]["O_Name"].ToString();
                    lvDatesort = DT2.Rows[i]["O_Date"].ToString();
                    lvMonthsort = Gstr.Left(lvDatesort, 6);
                    lvCanecarnum = DT2.Rows[i]["Cane_Carnum"].ToString();
                    lvLitterM = Gstr.fncToDouble(DT2.Rows[i]["Cane_Litter"].ToString());
                    lvLitterY = Gstr.fncToDouble(DT2.Rows[i]["Cane_Litter1"].ToString());
                    lvTotalM = Gstr.fncToDouble(DT2.Rows[i]["Cane_Price"].ToString());
                    lvTotalY = Gstr.fncToDouble(DT2.Rows[i]["Cane_Price1"].ToString());
                    lvPrice = Gstr.fncToDouble(DT2.Rows[i]["O_Price"].ToString());

                    lvSQL = "Insert Into SysTemp (S_Fieid1, S_Fieid2, S_Fieid3, S_Fieid4, S_Fieid5, S_Fieid6, S_Fieid7, S_Num3, S_Num4, S_Num5, S_Num6, S_Num7) Values ('" + lvDate + "', '" + lvCarnum + "', '" + lvDept + "', '" + lvDeptName + "', '" + lvDatesort + "' , '" + lvMonthsort + "' , '" + lvCanecarnum + "', '" + lvLitterM + "', '" + lvTotalM + "', '" + lvLitterY + "', '" + lvTotalY + "', '" + lvPrice + "')";
                    lvResult = GsysSQL.fncExecuteQueryData(lvSQL);
                }
                this.Cursor = Cursors.Default;
                btnSearch.Enabled = true;

                //Refresh รายงาน
                rptCarTotal Report = new rptCarTotal();
                Report.CreateDocument();
                documentViewer1.DocumentSource = Report;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "เตือน", MessageBoxButtons.OK);
            }
        }

        private void frmSearchPrint_Load(object sender, EventArgs e)
        {
            //ลบข้อมูล
            string lvSQL = "Delete From SysTempOilBill ";
            string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

            txtYear.Text = "64/65";
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
            /*if (cmbType.Text != "บิลน้ำมัน")
            {
                MessageBox.Show("ไม่สามารถ Export ข้อมูลได้เนื่องจากต้องเป็นประเภท บิลน้ำมัน เท่านั้น","แจ้งเตือน",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }*/
            if (txtDateS.Text.Equals(""))
            {
                MessageBox.Show("ไม่สามารถ Export ข้อมูลได้ กรุณาเลือกวันที่ทำรายการให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //fncSendTxtFileExport(); //ส่งเป็น TxTfile แบบเก่า
                fncSaveTophpAPI(); //ส่งข้อมูลไปเป็น PHP
            }
        }

        private void fncSaveTophpAPI()
        {
            //Get Data0
            string lvCarryStatus = "0";
            DataTable DT = new DataTable();
            string lvSQL = "select O_Name,O_Quota,O_DocS,Cane_OilBillHD.O_DocNo ,O_Litter,O_Price,O_Total,O_CarNum,Queue_Diary.Q_CarNum2,O_CaneNo,O_Date,O_Time ";
            lvSQL += "from Cane_OilBillHD ";
            lvSQL += "inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo ";
            lvSQL += "INNER JOIN Queue_Diary ON Cane_OilBillHD.O_DocNo = Queue_Diary.Q_OilBillNo ";
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
                lvSQL += "And Cane_OilBillHD.O_DocNo not like 'A-%' And Cane_OilBillHD.O_DocNo not like 'C-%' ";
            }

            if (txtYear.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Year = ' ' ";
            }

            if (txtDue.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Due = '" + txtDue.Text + "' ";
            }

            lvSQL += "Order by Cast(Cane_OilBillHD.O_CaneNo as int) ";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;

            int io = 0;

            string lvType = "";

            if (cmbType.Text == "บิลน้ำมัน")
            {
                lvType = "บิลน้ำมัน";
            }
            if(cmbType.Text == "บิลเรียกเก็บค่าบรรทุก")
            {
                lvType = "บิลเรียกเก็บค่าบรรทุก";
            }

            //ลบก่อน
            lvSQL = "Delete From SysTempOilphp WHERE S_Fieid10 LIKE '" + txtDateS.Text + "' AND S_Fieid9 = '" + cmbType.Text + "'";
            string lvResult = GsysSQL.fncExecuteQueryData(lvSQL);
            
            for (int i = 0; i < lvNumRow; i++)
            {
                //ตัวแปร
                string lvDocChk = DT.Rows[i]["O_DocNo"].ToString(); //1
                string name = GsysSQL.fncFindQuotaName(DT.Rows[i]["O_Name"].ToString()); //2
                string quota = DT.Rows[i]["O_Quota"].ToString(); //3
                string billno = Gstr.fncToInt(DT.Rows[i]["O_CaneNo"].ToString()).ToString(); //4
                string litter = Gstr.fncToDouble(DT.Rows[i]["O_Litter"].ToString()).ToString(""); //5
                string price = Gstr.fncToDouble(DT.Rows[i]["O_Price"].ToString()).ToString(""); //6
                string total = Gstr.fncToDouble(DT.Rows[i]["O_Total"].ToString()).ToString(""); //7
                string plate1 = DT.Rows[i]["O_CarNum"].ToString(); //8
                string plate2 = DT.Rows[i]["Q_CarNum2"].ToString(); //9
                string year = txtYear.Text; //10
                string ka = txtKa.Text; //11
                string lvField10 = ""; //12
                string billnoq = DT.Rows[i]["O_CaneNo"].ToString(); //13
                string date = Gstr.fncChangeSDate(DT.Rows[i]["O_Date"].ToString()); //14
                string time = DT.Rows[i]["O_Time"].ToString(); //15
                string datetime = date + " " + time; //16
                string date10 = Gstr.fncChangeTDate(DT.Rows[i]["O_Date"].ToString());

                //บันทึกข้อมูลลงตาราง Oilphp
                lvSQL = "Insert Into SysTempOilphp (S_Fieid1, S_Fieid2, S_Fieid3, S_Fieid4, S_Fieid5, S_Fieid6, S_Fieid7, S_Fieid8, S_Fieid9, S_Fieid10, S_Fieid11) " +
                    "Values ('" + billno + "', '" + quota + "', '" + datetime + "', '" + litter + "', '" + total + "', '" + price + "', '" + plate1 + "', '" + plate2 + "', '" + lvType + "', '" + date10 + "', '" + time + "')";
                lvResult = GsysSQL.fncExecuteQueryData(lvSQL);

                io = i + 1;
            }
            
                MessageBox.Show("ส่งข้อมูลสำเร็จ!... '" + io.ToString() + "' รายการ", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void fncSendTxtFileExport()
        {
            //Get Data0
            string lvCarryStatus = "0";
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
                lvSQL += "And Cane_OilBillHD.O_DocNo not like 'A-%' And Cane_OilBillHD.O_DocNo not like 'C-%' ";
            }

            if (txtYear.Text != "")
            {
                lvSQL += "And Cane_OilBillHD.O_Year = ' ' ";
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
            lines[0] = "Period,Billno,Quota_no,Date,Amount,Cost";//,CarryStatus
            for (int i = 1; i < lvNumRow; i++)
            {
                //ตัวแปร
                string lvDocChk = DT.Rows[i - 1]["O_DocNo"].ToString();
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

                //เช็คบิลเรียกเก็บค่ารถบรรทุก
                //if(Gstr.Left(lvDocChk,2) == "A-")
                //{
                //    lvCarryStatus = "1";
                //}

                // 0 - บิลอ้อย - โควต้า - วันที่ - จำนวนลิตร - จำนวนเงิน
                lines[i] = "0" + "," + lvField3 + "," + lvField2 + "," + lvField12 + " " + lvField13 + "," + lvField4 + "," + lvField6;// + " ," + lvCarryStatus
            }

            string lvPath = "L:\\FuelData";

            string lvDay = DateTime.Now.ToString("dd");
            string lvMonth = DateTime.Now.ToString("MM");
            string lvYear = DateTime.Now.ToString("yyyy");
            if (Gstr.fncToInt(lvYear) > 2500) lvYear = (Gstr.fncToInt(lvYear) - 543).ToString();
            string lvAll = lvYear + lvMonth + lvDay;

            string lvPathFile = lvPath + "\\" + lvAll + "#1FuelData.txt";
            if (!Directory.Exists(lvPath))
            {
                Directory.CreateDirectory(lvPath);
            }

            System.IO.File.WriteAllLines(lvPathFile, lines);

            MessageBox.Show("Export ไฟล์เรียบร้อย", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtDocBillS.Text = "";
            txtDocBillE.Text = "";
            txtDocS.Enabled = true;
            txtDocE.Enabled = true;
            txtDocBillS.Enabled = true;
            txtDocBillE.Enabled = true;
        }

        private void txtDocS_Click(object sender, EventArgs e)
        {
            txtDocBillS.Enabled = false;
            txtDocBillE.Enabled = false;
        }

        private void txtDocBillS_Click(object sender, EventArgs e)
        {
            txtDocS.Enabled = false;
            txtDocE.Enabled = false;
        }
    }
}
