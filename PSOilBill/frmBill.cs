using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PSOilBill
{
    public partial class frmBill : Form
    {
        string pvMode = "";
        string pvMode0 = "";
        string pvMode1 = "";
        string pvMode2 = "";
        string pvMode3 = "";
        string pvMode4 = "";
        string pvMode5 = "";
        string pvMode6 = "";

        public frmBill()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            pvMode = "";
            ShowBtn();
            txtType.Visible = false;

            this.WindowState = FormWindowState.Maximized;
        }

        public void LoadWeightData(string lvQ,string lvBill)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "";

            lvSQL += "Select * from Queue_Diary Where 1=1 ";

            if (lvQ != "")
            {
                lvSQL += "And Q_No = '"+ lvQ + "' ";
            }
            else if (lvBill != "")
            {
                lvSQL += "And Q_BillingNo = '" + lvBill + "' ";
            }

            lvSQL += "And Q_OilBillNo = '' ";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;
            sp1.ActiveSheet.RowCount = lvNumRow;
            //HD
            for (int i = 0; i < lvNumRow; i++)
            {
                //สถานะบิลเรียกเก็บ
                string lvStatus = DT.Rows[i]["Q_CarryPriceStatus"].ToString();
                if (lvStatus == "1")
                    rdCarry.Checked = true;
                else
                    rdOil.Checked = true;

                if (tabPageAll.SelectedIndex == 0)
                {
                    txtCaneNo.Text = DT.Rows[i]["Q_BillingNo"].ToString();
                    txtQ.Text = DT.Rows[i]["Q_No"].ToString();
                    txtQuota.Text = DT.Rows[i]["Q_Quota"].ToString();
                    txtName.Text = GsysSQL.fncFindQuotaName(DT.Rows[i]["Q_Quota"].ToString());

                    string[] lvArr = DT.Rows[i]["Q_CarNum"].ToString().Split('-');

                    if (lvArr.Count() > 1)
                    {
                        txtCarNumS.Text = lvArr[0];
                        txtCarNumE.Text = lvArr[1];
                    }
                    else
                    {
                        txtCarNumE.Text = lvArr[0];
                    }

                    txtCaneS.Text = DT.Rows[i]["Q_SampleNo"].ToString();
                    txtAmount.Focus();
                }
                else if (tabPageAll.SelectedIndex == 1)
                {
                    txtCaneNo1.Text = DT.Rows[i]["Q_BillingNo"].ToString();
                    txtQ1.Text = DT.Rows[i]["Q_No"].ToString();
                    txtQuota1.Text = DT.Rows[i]["Q_Quota"].ToString();
                    txtName1.Text = GsysSQL.fncFindQuotaName(DT.Rows[i]["Q_Quota"].ToString());

                    string[] lvArr = DT.Rows[i]["Q_CarNum"].ToString().Split('-');

                    if (lvArr.Count() > 1)
                    {
                        txtCarNumS1.Text = lvArr[0];
                        txtCarNumE1.Text = lvArr[1];
                    }
                    else
                    {
                        txtCarNumE1.Text = lvArr[0];
                    }

                    txtCaneS1.Text = DT.Rows[i]["Q_SampleNo"].ToString();
                    txtAmount1.Focus();
                }
                else if (tabPageAll.SelectedIndex == 2)
                {
                    txtCaneNo2.Text = DT.Rows[i]["Q_BillingNo"].ToString();
                    txtQ2.Text = DT.Rows[i]["Q_No"].ToString();
                    txtQuota2.Text = DT.Rows[i]["Q_Quota"].ToString();
                    txtName2.Text = GsysSQL.fncFindQuotaName(DT.Rows[i]["Q_Quota"].ToString());

                    string[] lvArr = DT.Rows[i]["Q_CarNum"].ToString().Split('-');

                    if (lvArr.Count() > 1)
                    {
                        txtCarNumS2.Text = lvArr[0];
                        txtCarNumE2.Text = lvArr[1];
                    }
                    else
                    {
                        txtCarNumE2.Text = lvArr[0];
                    }

                    txtCaneS2.Text = DT.Rows[i]["Q_SampleNo"].ToString();
                    txtAmount2.Focus();
                }
                else if (tabPageAll.SelectedIndex == 3)
                {
                    txtCaneNo3.Text = DT.Rows[i]["Q_BillingNo"].ToString();
                    txtQ3.Text = DT.Rows[i]["Q_No"].ToString();
                    txtQuota3.Text = DT.Rows[i]["Q_Quota"].ToString();
                    txtName3.Text = GsysSQL.fncFindQuotaName(DT.Rows[i]["Q_Quota"].ToString());

                    string[] lvArr = DT.Rows[i]["Q_CarNum"].ToString().Split('-');

                    if (lvArr.Count() > 1)
                    {
                        txtCarNumS3.Text = lvArr[0];
                        txtCarNumE3.Text = lvArr[1];
                    }
                    else
                    {
                        txtCarNumE3.Text = lvArr[0];
                    }

                    txtCaneS3.Text = DT.Rows[i]["Q_SampleNo"].ToString();
                    txtAmount3.Focus();
                }
                else if (tabPageAll.SelectedIndex == 4)
                {
                    txtCaneNo4.Text = DT.Rows[i]["Q_BillingNo"].ToString();
                    txtQ4.Text = DT.Rows[i]["Q_No"].ToString();
                    txtQuota4.Text = DT.Rows[i]["Q_Quota"].ToString();
                    txtName4.Text = GsysSQL.fncFindQuotaName(DT.Rows[i]["Q_Quota"].ToString());

                    string[] lvArr = DT.Rows[i]["Q_CarNum"].ToString().Split('-');

                    if (lvArr.Count() > 1)
                    {
                        txtCarNumS4.Text = lvArr[0];
                        txtCarNumE4.Text = lvArr[1];
                    }
                    else
                    {
                        txtCarNumE4.Text = lvArr[0];
                    }

                    txtCaneS4.Text = DT.Rows[i]["Q_SampleNo"].ToString();
                    txtAmount4.Focus();
                }
                else if (tabPageAll.SelectedIndex == 5)
                {
                    txtCaneNo5.Text = DT.Rows[i]["Q_BillingNo"].ToString();
                    txtQ5.Text = DT.Rows[i]["Q_No"].ToString();
                    txtQuota5.Text = DT.Rows[i]["Q_Quota"].ToString();
                    txtName5.Text = GsysSQL.fncFindQuotaName(DT.Rows[i]["Q_Quota"].ToString());

                    string[] lvArr = DT.Rows[i]["Q_CarNum"].ToString().Split('-');

                    if (lvArr.Count() > 1)
                    {
                        txtCarNumS5.Text = lvArr[0];
                        txtCarNumE5.Text = lvArr[1];
                    }
                    else
                    {
                        txtCarNumE5.Text = lvArr[0];
                    }

                    txtCaneS5.Text = DT.Rows[i]["Q_SampleNo"].ToString();
                    txtAmount5.Focus();
                }
            }

            if (lvNumRow == 0)
            {
                string lvData = "";
                if (lvBill != "") lvData = "เลขที่บิล";
                else if (lvQ != "") lvData = "เลขที่คิว";

                MessageBox.Show("ไม่พบข้อมูล" + lvData + " กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (tabPageAll.SelectedIndex == 0)
                {
                    if (lvBill != "")
                    {
                        txtCaneNo.Text = "";
                        txtCaneNo.Focus();
                    }
                    else if (lvQ != "")
                    {
                        txtQ.Text = "";
                        txtQ.Focus();
                    }
                }
                else if (tabPageAll.SelectedIndex == 1)
                {
                    if (lvBill != "")
                    {
                        txtCaneNo1.Text = "";
                        txtCaneNo1.Focus();
                    }
                    else if (lvQ != "")
                    {
                        txtQ1.Text = "";
                        txtQ1.Focus();
                    }
                }
                else if (tabPageAll.SelectedIndex == 2)
                {
                    if (lvBill != "")
                    {
                        txtCaneNo2.Text = "";
                        txtCaneNo2.Focus();
                    }
                    else if (lvQ != "")
                    {
                        txtQ2.Text = "";
                        txtQ2.Focus();
                    }
                }
                else if (tabPageAll.SelectedIndex == 3)
                {
                    if (lvBill != "")
                    {
                        txtCaneNo3.Text = "";
                        txtCaneNo3.Focus();
                    }
                    else if (lvQ != "")
                    {
                        txtQ3.Text = "";
                        txtQ3.Focus();
                    }
                }
                else if (tabPageAll.SelectedIndex == 4)
                {
                    if (lvBill != "")
                    {
                        txtCaneNo4.Text = "";
                        txtCaneNo4.Focus();
                    }
                    else if (lvQ != "")
                    {
                        txtQ4.Text = "";
                        txtQ4.Focus();
                    }
                }
                else if (tabPageAll.SelectedIndex == 5)
                {
                    if (lvBill != "")
                    {
                        txtCaneNo5.Text = "";
                        txtCaneNo5.Focus();
                    }
                    else if (lvQ != "")
                    {
                        txtQ5.Text = "";
                        txtQ5.Focus();
                    }
                }
            }
        }

        private void GridResize()
        {
            float lvWDesktop = sp1.Width;
  
            sp1.ActiveSheet.Columns[0].Width = Convert.ToSingle(lvWDesktop * 0.1);
            sp1.ActiveSheet.Columns[1].Width = Convert.ToSingle(lvWDesktop * 0.1);
            sp1.ActiveSheet.Columns[2].Width = Convert.ToSingle(lvWDesktop * 0.2);
            sp1.ActiveSheet.Columns[3].Width = Convert.ToSingle(lvWDesktop * 0.1);
            sp1.ActiveSheet.Columns[4].Width = Convert.ToSingle(lvWDesktop * 0.1);
            sp1.ActiveSheet.Columns[5].Width = Convert.ToSingle(lvWDesktop * 0.1);
            sp1.ActiveSheet.Columns[6].Width = Convert.ToSingle(lvWDesktop * 0.1);
            sp1.ActiveSheet.Columns[7].Width = Convert.ToSingle(lvWDesktop * 0.14);
        }

        private void sp1_Resize(object sender, EventArgs e)
        {
            GridResize();
        }

        private void ShowBtn()
        {
            if (pvMode == "")
            {
                btnAdd.Enabled = true;

                if (cmbDocNo.Text == "")
                    btnEdit.Enabled = false;
                else
                    btnEdit.Enabled = true;

                btnCancel.Enabled = false;
                btnSave.Enabled = false;

                if (cmbDocNo.Text != "" && pvMode == "")
                {
                    btnDelDoc.Enabled = true;
                    btnPrint.Enabled = true;
                    ใบเสรจToolStripMenuItem.Enabled = true;
                }
                else
                {
                    btnDelDoc.Enabled = false;
                    ใบเสรจToolStripMenuItem.Enabled = false;
                }

                //ล๊อคเอกสาร
                txtDocS.Enabled = true;
                cmbDocNo.Enabled = true;
            }
            else if (pvMode == "New")
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;

                if (cmbDocNo.Text != "" && pvMode == "")
                {
                    btnDelDoc.Enabled = true;
                    btnPrint.Enabled = true;
                    ใบเสรจToolStripMenuItem.Enabled = true;
                }
                else
                {
                    btnDelDoc.Enabled = false;
                    ใบเสรจToolStripMenuItem.Enabled = false;
                }

                //ล๊อคเอกสาร
                txtDocS.Enabled = false;
                cmbDocNo.Enabled = false;
            }
            else if (pvMode == "Edit")
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;

                if (cmbDocNo.Text != "" && pvMode == "")
                {
                    btnDelDoc.Enabled = true;
                    btnPrint.Enabled = true;
                    ใบเสรจToolStripMenuItem.Enabled = true;
                }
                else
                {
                    btnDelDoc.Enabled = false;
                    ใบเสรจToolStripMenuItem.Enabled = false;
                }

                //ล๊อคเอกสาร
                txtDocS.Enabled = false;
                cmbDocNo.Enabled = false;
            }
        }

        private void FncGetModeTab(string lvMode)
        {
            if (tabPageAll.SelectedIndex == 0)
            {
                pvMode0 = lvMode;
                pvMode = pvMode0;
            }
            else if (tabPageAll.SelectedIndex == 1)
            {
                pvMode1 = lvMode;
                pvMode = pvMode1;
            }
            else if (tabPageAll.SelectedIndex == 2)
            {
                pvMode2 = lvMode;
                pvMode = pvMode2;
            }
            else if (tabPageAll.SelectedIndex == 3)
            {
                pvMode3 = lvMode;
                pvMode = pvMode3;
            }
            else if (tabPageAll.SelectedIndex == 4)
            {
                pvMode4 = lvMode;
                pvMode = pvMode4;
            }
            else if (tabPageAll.SelectedIndex == 5)
            {
                pvMode5 = lvMode;
                pvMode = pvMode5;
            }
            else if (tabPageAll.SelectedIndex == 6)
            {
                pvMode6 = lvMode;
                pvMode = pvMode6;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FncGetModeTab("New");
            ShowBtn();

            txtDocS.Text = "";
            cmbDocNo.Text = "";
            string lvTabIndex = tabPageAll.SelectedIndex.ToString();

            DateTime DTBreak = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy") + " 15:00:00");
            DateTime DTNow = DateTime.Now;
            if (DTNow >= DTBreak)
            {
                DTNow = DTNow.AddDays(1);
                txtDate.Text = DTNow.ToString("dd/MM/yyyy");
            }

            string lvSQL = "Update SysDocNo SET S_RunNo = 0 WHERE S_MCode = 'OilBill_02' ";
            lvSQL = GsysSQL.fncExecuteQueryData(lvSQL);

            //ล้างข้อมูล ตาม Tab
            ClearData(lvTabIndex, pvMode);

            sp1.ActiveSheet.RowCount = 0;

            //GenDoc
            if (rdOil.Checked)
                cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_00");
            else if (rdCarry.Checked)
                cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_01");
            else
                //cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_02");
                cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_02");

            txtDocS.Enabled = false;
            cmbDocNo.Enabled = false;
            string lvd = "";
            GsysSQL.fncGetLastDocNoX(lvd);

            //โหลดราคาน้ำมัน
            string lvOilPrice = "";
            if (lvTabIndex == "0")
            {
                lvOilPrice = GsysSQL.fncFindOilPrice(Gstr.fncGetDataCode(txtOil.Text, ":"));
                txtlitter.Text = lvOilPrice;
                txtCaneNo.Focus();
            }
            else if (lvTabIndex == "1")
            {
                lvOilPrice = GsysSQL.fncFindOilPrice(Gstr.fncGetDataCode(txtOil1.Text, ":"));
                txtlitter1.Text = lvOilPrice;
                txtCaneNo1.Focus();
            }
            else if (lvTabIndex == "2")
            {
                lvOilPrice = GsysSQL.fncFindOilPrice(Gstr.fncGetDataCode(txtOil2.Text, ":"));
                txtlitter2.Text = lvOilPrice;
                txtCaneNo2.Focus();
            }
            else if (lvTabIndex == "3")
            {
                lvOilPrice = GsysSQL.fncFindOilPrice(Gstr.fncGetDataCode(txtOil3.Text, ":"));
                txtlitter3.Text = lvOilPrice;
                txtCaneNo3.Focus();
            }
            else if (lvTabIndex == "4")
            {
                lvOilPrice = GsysSQL.fncFindOilPrice(Gstr.fncGetDataCode(txtOil4.Text, ":"));
                txtlitter4.Text = lvOilPrice;
                txtCaneNo4.Focus();
            }
            else if (lvTabIndex == "5")
            {
                lvOilPrice = GsysSQL.fncFindOilPrice(Gstr.fncGetDataCode(txtOil5.Text, ":"));
                txtlitter5.Text = lvOilPrice;
                txtCaneNo5.Focus();
            }
            else if (lvTabIndex == "6")
            {
                lvOilPrice = GsysSQL.fncFindOilPrice(Gstr.fncGetDataCode(txtOil6.Text, ":"));
                txtLitter6.Text = lvOilPrice;
                txtDept.Focus();
            }

            //btnBill1_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pvMode = "Edit";
            ShowBtn();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData(tabPageAll.SelectedIndex.ToString() , "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pvMode == "New")
            {
                //GenDoc
                if (rdOil.Checked)
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_00");
                else if (rdCarry.Checked)
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_01");
                else
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_02");
            }


            //คำนวนยอดใหม่
            FncKeyDownLitAmountNoSave(txtAmount, txtlitter, txtTotal, txtMeterS, txtMeterE, txtFront);

            //เก็บข้อมูล
            string lvDocS = txtDocS.Text;
            string lvDocNo = cmbDocNo.Text;
            string lvDate = Gstr.fncChangeTDate(txtDate.Text);
            //string lvYear = Gstr.Left(lvDate, 4);
            string lvQuota = "";
            string lvCarNum = "";
            string lvName = "";
            string lvCaneS = "";
            string lvCaneNo = "";
            string lvFront = "";
            string lvMeterS = "";
            string lvMeterE = "";
            string lvDept = "";
            string lvIssue = "";
            string lvObjective = "";
            string lvBudjet = "";
            string lvAsset = "";
            string lvRemark = "";
            string lvQ = "";
            string lvAmountL = "";
            string lvOilType = "";
            string lvOilPrice = "";
            string lvDue = GsysSQL.fncFindDue(lvDate);
            string lvTime = DateTime.Now.ToString("HH:mm");
            string lvYear = "61/62";
            string lvEmpID = txtEmpID.Text;
            string lvEmpName = txtEmpName.Text;
            string lvType = "";
            string lvproductIn = "";
            string lvproductOut = "";
            string lvCarnumS6 = "";
            string lvCarnumE6 = "";

            #region เก็บค่า

            if (tabPageAll.SelectedIndex == 0)
            {
                lvQuota = txtQuota.Text;
                lvCarNum = txtCarNumS.Text + "-" + txtCarNumE.Text;
                lvName = txtName.Text;
                lvCaneS = txtCaneS.Text;
                lvCaneNo = txtCaneNo.Text;
                lvFront = txtFront.Text;
                lvMeterS = txtMeterS.Text;
                lvMeterE = txtMeterE.Text;
                lvRemark = txtRemark.Text;
                lvQ = txtQ.Text;
                lvAmountL = txtAmount.Text;
                lvOilType = txtOil.Text;
                lvOilPrice = txtlitter.Text;
                lvType = txtType.Text;
            }
            else if (tabPageAll.SelectedIndex == 1)
            {
                lvQuota = txtQuota1.Text;
                lvCarNum = txtCarNumS1.Text + "-" + txtCarNumE1.Text;
                lvName = txtName1.Text;
                lvCaneS = txtCaneS1.Text;
                lvCaneNo = txtCaneNo1.Text;
                lvFront = txtFront1.Text;
                lvMeterS = txtMeterS1.Text;
                lvMeterE = txtMeterE1.Text;
                lvRemark = txtRemark1.Text;
                lvQ = txtQ1.Text;
                lvAmountL = txtAmount1.Text;
                lvOilType = txtOil1.Text;
                lvOilPrice = txtlitter1.Text;
                //lvType = txtType1.Text;
            }
            else if(tabPageAll.SelectedIndex == 2)
            {
                lvQuota = txtQuota2.Text;
                lvCarNum = txtCarNumS2.Text + "-" + txtCarNumE2.Text;
                lvName = txtName2.Text;
                lvCaneS = txtCaneS2.Text;
                lvCaneNo = txtCaneNo2.Text;
                lvFront = txtFront2.Text;
                lvMeterS = txtMeterS2.Text;
                lvMeterE = txtMeterE2.Text;
                lvRemark = txtRemark2.Text;
                lvQ = txtQ2.Text;
                lvAmountL = txtAmount2.Text;
                lvOilType = txtOil2.Text;
                lvOilPrice = txtlitter2.Text;
                //lvType = txtType2.Text;
            }
            else if (tabPageAll.SelectedIndex == 3)
            {
                lvQuota = txtQuota3.Text;
                lvCarNum = txtCarNumS3.Text + "-" + txtCarNumE3.Text;
                lvName = txtName3.Text;
                lvCaneS = txtCaneS3.Text;
                lvCaneNo = txtCaneNo3.Text;
                lvFront = txtFront3.Text;
                lvMeterS = txtMeterS3.Text;
                lvMeterE = txtMeterE3.Text;
                lvRemark = txtRemark3.Text;
                lvAmountL = txtAmount3.Text;
                lvQ = txtQ3.Text;
                lvOilType = txtOil3.Text;
                lvOilPrice = txtlitter3.Text;
                //lvType = txtType3.Text;
            }
            else if (tabPageAll.SelectedIndex == 4)
            {
                lvQuota = txtQuota4.Text;
                lvCarNum = txtCarNumS4.Text + "-" + txtCarNumE4.Text;
                lvName = txtName4.Text;
                lvCaneS = txtCaneS4.Text;
                lvCaneNo = txtCaneNo4.Text;
                lvFront = txtFront4.Text;
                lvMeterS = txtMeterS4.Text;
                lvMeterE = txtMeterE4.Text;
                lvRemark = txtRemark4.Text;
                lvAmountL = txtAmount4.Text;
                lvQ = txtQ4.Text;
                lvOilType = txtOil4.Text;
                lvOilPrice = txtlitter4.Text;
                //lvType = txtType4.Text;
            }
            else if (tabPageAll.SelectedIndex == 5)
            {
                lvQuota = txtQuota5.Text;
                lvCarNum = txtCarNumS5.Text + "-" + txtCarNumE5.Text;
                lvName = txtName5.Text;
                lvCaneS = txtCaneS5.Text;
                lvCaneNo = txtCaneNo5.Text;
                lvFront = txtFront5.Text;
                lvMeterS = txtMeterS5.Text;
                lvMeterE = txtMeterE5.Text;
                lvRemark = txtRemark5.Text;
                lvAmountL = txtAmount5.Text;
                lvQ = txtQ5.Text;
                lvOilType = txtOil5.Text;
                lvOilPrice = txtlitter5.Text;
                //lvType = txtType5.Text;
            }
            else if (tabPageAll.SelectedIndex == 6)
            {
                lvCarNum = txtCarNumS6.Text + "-" + txtCarNumE6.Text;
                lvName = txtName6.Text;
                lvFront = txtFront6.Text;
                lvMeterS = txtMeterS6.Text;
                lvMeterE = txtMeterE6.Text;
                lvAmountL = txtAmount6.Text;
                lvDept = txtDept.Text;
                lvIssue = txtIssue.Text;
                lvObjective = txtObjective.Text;
                lvBudjet = txtBudjet.Text;
                lvAsset = txtAsset.Text;
                lvRemark = txtRemark6.Text;
                lvOilType = Gstr.fncGetDataCode(txtOil6.Text, ":");
                lvOilPrice = txtLitter6.Text;
                lvEmpID = txtEmpID.Text;
                lvproductIn = txtPdIn.Text;
                lvproductOut = txtPdOut.Text;
                lvCarnumS6 = txtCarNumS6.Text;
                lvCarnumE6 = txtCarNumE6.Text;
                lvType = txtType.Text;
            }
            #endregion  

            #region //เช็คข้อมูล            
            //if (lvDocS == "")
            //{
            //    MessageBox.Show("กรุณาระบุเล่มที่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtDocS.Focus();
            //    return;
            //}
            if (lvDocNo == "")
            {
                MessageBox.Show("กรุณาระบุเลขที่เอกสาร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbDocNo.Focus();
                return;
            }
            else if (lvDate == "")
            {
                MessageBox.Show("กรุณาระบุวันที่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDate.Focus();
                return;
            }
            else if (lvQuota == "" && !rdIssue.Checked)
            {
                MessageBox.Show("กรุณาระบุโควต้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuota.Focus();
                return;
            }
            else if (lvCarNum == ".")
            {
                MessageBox.Show("กรุณาระบุเลขทะเบียนรถ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCarNumS.Focus();
                return;
            }
            else if (lvName == "")
            {
                MessageBox.Show("กรุณาระบุชื่อ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            else if (lvCaneS == "" && !rdIssue.Checked)
            {
                MessageBox.Show("กรุณาระบุเลขที่ตัวอย่าง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCaneS.Focus();
                return;
            }
            else if (lvCaneNo == "" && !rdIssue.Checked)
            {
                MessageBox.Show("กรุณาระบุเลขที่ใบรับอ้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCaneNo.Focus();
                return;
            }
            else if (lvAmountL == "")
            {
                MessageBox.Show("กรุณาระบุจำนวนที่เติม", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Focus();
                return;
            }

            string lvChkBill = GsysSQL.fncCheckBillNo(lvCaneNo, lvDocNo);
            
            if (lvChkBill != "" && tabPageAll.SelectedTab != tabPage2)//pvMode == "New" && 
            {
                MessageBox.Show("เลขที่บิล " + lvCaneNo + " ซ้ำ กับเอกสารที่ " + lvChkBill + " กรุณาตรวจสอบใหม่อีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtType.Text == "")
            {
                MessageBox.Show("กรุณาเลือกประเภท", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtType.Focus();
                return;
            }

            //เช็ครายการ
            //for (int i = 0; i < sp1.ActiveSheet.RowCount; i++)
            //{
            //    string lvAmount = sp1.ActiveSheet.Cells[i,0].Text;
            //    string lvPrice = sp1.ActiveSheet.Cells[i, 3].Text;

            //    if (lvAmount == "" || lvAmount == "0.00")
            //    {
            //        MessageBox.Show("กรุณาระบุจำนวนลิตร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        sp1.ActiveSheet.SetActiveCell(i, 0);
            //        return;
            //    }
            //    else if (lvPrice == "" || lvPrice == "0.00")
            //    {
            //        MessageBox.Show("กรุณาระบุราคา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        sp1.ActiveSheet.SetActiveCell(i, 3);
            //        return;
            //    }
            //}
            #endregion

            //ยืนยัน
            DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            //บันทึก
            if (pvMode == "New")
            {
                //เช็คเลขที่ซ้ำ
                string lvDocChk = GsysSQL.fncCheckDocNo(lvDocS, lvDocNo);

                if (lvDocChk != "")
                {
                    MessageBox.Show("เลขที่เอกสารซ้ำ กรุณากดบันทึกอีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Update เลขที่เอกสาร
                    string lvSQLDoc = "";
                    if (rdOil.Checked)
                        lvSQLDoc = "Update SysDocNo set S_RunNo = S_RunNo + 1 Where S_MCode = 'OilBill_00' ";
                    else if (rdCarry.Checked)
                        lvSQLDoc = "Update SysDocNo set S_RunNo = S_RunNo + 1 Where S_MCode = 'OilBill_01' ";
                    else
                        lvSQLDoc = "Update SysDocNo set S_RunNo = S_RunNo + 1 Where S_MCode = 'OilBill_02' ";

                    GsysSQL.fncExecuteQueryData(lvSQLDoc);

                    //GenDoc
                    if (rdOil.Checked)
                        cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_00");
                    else if (rdCarry.Checked)
                        cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_01");
                    else
                        cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_02");

                    cmbDocNo.Focus();
                    return;
                }

                //ลบข้อมูล
                string lvSQL = "Delete From Cane_OilBillHD Where O_DocNo = '"+ lvDocNo +"' "; //HD
                string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                lvSQL = "Delete From Cane_OilBillDT Where O_DocNo = '" + lvDocNo + "' "; //DT
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                //เพิ่ม
                //HD
                lvSQL = "Insert into Cane_OilBillHD (O_DocS, O_DocNo, O_Date, O_Name, O_Quota, O_CarNum, O_CarFront, O_CaneS, O_CaneNo, O_MeterS, O_MeterE, O_QNo, O_Dept, O_Issue, O_Objective, O_Budjet, O_Asset, O_Remark, O_Due, O_Time, O_Year, O_EmpID, O_EmpName ,O_Type, O_PdIn, O_PdOut, O_CarnumS6, O_CarnumE6) ";
                lvSQL += "Values ('"+ lvDocS +"', '"+ lvDocNo +"', '"+ lvDate +"', '"+ lvName +"', '"+ lvQuota +"', '"+ lvCarNum +"', '"+ lvFront +"', '"+ lvCaneS +"', '"+ lvCaneNo + "', '" + lvMeterS + "', '" + lvMeterE + "', '" + lvQ + "', '" + lvDept + "', '" + lvIssue + "', '" + lvObjective + "', '" + lvBudjet + "', '" + lvAsset + "', '" + lvRemark + "', '" + lvDue + "', '" + lvTime + "', '" + lvYear + "', '" + lvEmpID + "', '" + lvEmpName + "','" + lvType + "', '" + lvproductIn + "', '"+ lvproductOut + "', '" + lvCarnumS6 + "', '" + lvCarnumE6 + "')";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                //DT
                double lvAmount = Gstr.fncToDouble(lvAmountL);
                string lvItem = Gstr.fncGetDataCode(lvOilType, ":");
                double lvPrice = Gstr.fncToDouble(lvOilPrice);
                double lvTotal = lvAmount * lvPrice;

                lvSQL = "Insert into Cane_OilBillDT (O_DocNo, O_Litter, O_Item, O_Price, O_Total, O_Remark) ";
                lvSQL += "Values ('" + lvDocNo + "', '" + lvAmount + "', '" + lvItem + "', '" + lvPrice + "', '" + lvTotal + "', '" + lvRemark + "')";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                //Update เลขที่เอกสาร
                if (rdOil.Checked)
                    lvSQL = "Update SysDocNo set S_RunNo = S_RunNo + 1 Where S_MCode = 'OilBill_00' ";
                else if(rdCarry.Checked)
                    lvSQL = "Update SysDocNo set S_RunNo = S_RunNo + 1 Where S_MCode = 'OilBill_01' ";
                else
                    lvSQL = "Update SysDocNo set S_RunNo = S_RunNo + 1 Where S_MCode = 'OilBill_02' ";

                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                //อัพเดทเลขที่บิล ในข้อมูลห้องชั่ง
                //clear อันเก่า
                lvSQL = "Update Queue_Diary Set Q_OilBillNo = '' Where Q_OilBillNo = '" + lvDocNo + "' ";
                if (lvDocNo != "") lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
                lvSQL = "Update Queue_Diary Set Q_OilBillNo = '"+ lvDocNo +"' Where Q_BillingNo = '" + lvCaneNo + "' "; 
                if (lvCaneNo != "") lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                lvSQL = "Update Cane_OilMeter Set M_RunMetter = '" + lvMeterE + "' Where M_ID = '" + lvFront + "' ";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

            }
            else if (pvMode == "Edit")
            {
                //Update
                string lvSQL = "Update Cane_OilBillHD set O_Date = '"+ lvDate +"', "; //DT
                lvSQL += "O_Name = '" + lvName + "', O_Quota = '" + lvQuota + "', O_CarNum = '" + lvCarNum + "', O_CarFront = '" + lvFront + "', O_CaneS = '" + lvCaneS + "', O_CaneNo = '" + lvCaneNo + "', ";
                lvSQL += "O_MeterS = '"+ lvMeterS + "', O_MeterE = '" + lvMeterE + "', O_QNo = '" + lvQ + "', ";
                lvSQL += "O_Dept = '" + lvDept + "', O_Issue = '" + lvIssue + "', O_Objective = '" + lvObjective + "', ";
                lvSQL += "O_Budjet = '" + lvBudjet + "', O_Asset = '" + lvAsset + "', O_Remark = '" + lvRemark + "', O_Due = '" + lvDue + "', O_Time = '" + lvTime + "', O_Year = '" + lvYear + "', O_EmpID = '"+ lvEmpID + "', O_EmpName = '" + lvEmpName + "', O_Type = '" + lvType + "', O_PdIn = '" + lvproductIn + "', O_PdOut = '" + lvproductOut + "' , O_CarnumS6 = '" + lvCarnumS6 + "' , O_CarnumE6 = '" + lvCarnumE6 + "' ";
                lvSQL += "Where O_DocNo = '"+ lvDocNo +"' "; //O_DocS = '"+ lvDocS +"' And 
                string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                //DT
                lvSQL = "Delete From Cane_OilBillDT Where O_DocNo = '" + lvDocNo + "' "; //DT
                GsysSQL.fncExecuteQueryData(lvSQL);

                double lvAmount = Gstr.fncToDouble(lvAmountL);
                string lvItem = Gstr.fncGetDataCode(lvOilType, ":");
                double lvPrice = Gstr.fncToDouble(lvOilPrice);
                double lvTotal = lvAmount * lvPrice;

                lvSQL = "Insert into Cane_OilBillDT (O_DocNo, O_Litter, O_Item, O_Price, O_Total, O_Remark) ";
                lvSQL += "Values ('" + lvDocNo + "', '" + lvAmount + "', '" + lvItem + "', '" + lvPrice + "', '" + lvTotal + "', '" + lvRemark + "')";
                lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                //อัพเดทเลขที่บิล ในข้อมูลห้องชั่ง
                //clear อันเก่า
                lvSQL = "Update Queue_Diary Set Q_OilBillNo = '' Where Q_OilBillNo = '" + lvDocNo + "' ";
                if (lvDocNo != "") lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

                lvSQL = "Update Queue_Diary Set Q_OilBillNo = '" + lvDocNo + "' Where Q_BillingNo = '" + lvCaneNo + "' ";
                if (lvCaneNo != "") lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
            }
            
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //พิมพ์อัตโนมัติ
            //ยืนยัน
            DialogResult dialogResultP = MessageBox.Show("ต้องการพิมพ์ใบเสร็จหรือไม่?", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResultP == DialogResult.Yes)
            {
                #region เก็บค่า
                if (tabPageAll.SelectedIndex == 0)
                {
                    FncPrint(txtName, txtQuota, txtCarNumS, txtCarNumE, txtCaneNo, txtAmount, txtlitter, txtTotal, txtRemark, txtMeterS, txtMeterE, txtFront);
                }
                else if (tabPageAll.SelectedIndex == 1)
                {
                    FncPrint(txtName1, txtQuota1, txtCarNumS1, txtCarNumE1, txtCaneNo1, txtAmount1, txtlitter1, txtTotal1, txtRemark1, txtMeterS1, txtMeterE1, txtFront1);
                }
                else if (tabPageAll.SelectedIndex == 2)
                {
                    FncPrint(txtName2, txtQuota2, txtCarNumS2, txtCarNumE2, txtCaneNo2, txtAmount2, txtlitter2, txtTotal2, txtRemark2, txtMeterS2, txtMeterE2, txtFront2);
                }
                else if (tabPageAll.SelectedIndex == 3)
                {
                    FncPrint(txtName3, txtQuota3, txtCarNumS3, txtCarNumE3, txtCaneNo3, txtAmount3, txtlitter3, txtTotal3, txtRemark3, txtMeterS3, txtMeterE3, txtFront3);
                }
                else if (tabPageAll.SelectedIndex == 4)
                {
                    FncPrint(txtName4, txtQuota4, txtCarNumS4, txtCarNumE4, txtCaneNo4, txtAmount4, txtlitter4, txtTotal4, txtRemark4, txtMeterS4, txtMeterE4, txtFront4);
                }
                else if (tabPageAll.SelectedIndex == 5)
                {
                    FncPrint(txtName5, txtQuota5, txtCarNumS5, txtCarNumE5, txtCaneNo5, txtAmount5, txtlitter5, txtTotal5, txtRemark5, txtMeterS5, txtMeterE5, txtFront5);
                }
                else if (tabPageAll.SelectedIndex == 6)
                {
                    //ใบเบิกไม่มี
                }

                GVar.gvCarryPriceStatus = "";
                if (rdCarry.Checked) GVar.gvCarryPriceStatus = "1";
                #endregion

                // แสดงก่อนพิมพ์
                frmPrint frm = new frmPrint();
                frm.documentViewer1.DocumentSource = typeof(PSOilBill.rptBill);
                frm.ShowDialog();

                ////PrinterSettings settings = new PrinterSettings();
                //rptBill Report = new rptBill();
                ////Report.PrinterName = settings.PrinterName;
                //Report.PrintingSystem.ShowMarginsWarning = false;
                //Report.ExportOptions.Pdf.ShowPrintDialogOnOpen = true;
                //Report.CreateDocument();

                //using (ReportPrintTool printTool = new ReportPrintTool(Report))
                //{
                //    printTool.ShowPreview();
                //}
                
            }

            FncGetModeTab("");
            ShowBtn();
            btnAdd_Click(sender, e); //Add Auto เมื่อบันทึกเสร็จ
        }

        private void btnDelDoc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ยืนยันการลบเอกสาร เลขที่ " + cmbDocNo.Text + " หรือไม่?" , "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            //ลบข้อมูล
            string lvSQL = "Update Cane_OilBillHD Set O_Status = 'Cancel' Where O_DocS = '" + txtDocS.Text + "' And O_DocNo = '" + cmbDocNo.Text + "' "; //HD
            GsysSQL.fncExecuteQueryData(lvSQL);
            lvSQL = "Update Queue_Diary Set Q_OilBillNo = '' Where Q_OilBillNo = '" + cmbDocNo.Text + "' "; //DT
            GsysSQL.fncExecuteQueryData(lvSQL);
            //lvSQL = "Delete From Cane_OilBillDT Where O_DocNo = '" + cmbDocNo.Text + "' "; //DT
            //GsysSQL.fncExecuteQueryData(lvSQL);

            MessageBox.Show("ลบข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData(tabPageAll.SelectedIndex.ToString(), "");
        }

        private void ClearData(string lvTab, string lvMode)
        {
            //txtDocS.Text = "";
            cmbDocNo.Text = "";
            //txtDate.Text = "";

            if (lvTab == "0" || lvTab == "ALL")
            {
                txtQuota.Text = "";
                txtCarNumS.Text = "";
                txtCarNumE.Text = "";
                txtName.Text = "";
                txtCaneS.Text = "";
                txtCaneNo.Text = "";
                txtOil.Text = "01 : โซล่า";
                txtlitter.Text = "";
                txtAmount.Text = "";
                txtTotal.Text = "";
                txtFront.Text = "1/1";
                txtMeterS.Text = "";
                txtMeterE.Text = "";
                txtRemark.Text = "";
                txtQ.Text = "";

                if (lvMode == "")
                {
                    FncGetModeTab("");
                    ShowBtn();
                    btnAdd.Focus();
                }
            }

            if (lvTab == "1" || lvTab == "ALL")
            {
                txtQuota1.Text = "";
                txtCarNumS1.Text = "";
                txtCarNumE1.Text = "";
                txtName1.Text = "";
                txtCaneS1.Text = "";
                txtCaneNo1.Text = "";
                txtOil1.Text = "01 : โซล่า";
                txtlitter1.Text = "";
                txtAmount1.Text = "";
                txtTotal1.Text = "";
                txtFront1.Text = "1/2";
                txtMeterS1.Text = "";
                txtMeterE1.Text = "";
                txtRemark1.Text = "";
                txtQ1.Text = "";

                if (lvMode == "")
                {
                    FncGetModeTab("");
                    ShowBtn();
                    btnAdd.Focus();
                }
            }

            if (lvTab == "2" || lvTab == "ALL")
            {
                txtQuota2.Text = "";
                txtCarNumS2.Text = "";
                txtCarNumE2.Text = "";
                txtName2.Text = "";
                txtCaneS2.Text = "";
                txtCaneNo2.Text = "";
                txtOil2.Text = "01 : โซล่า";
                txtlitter2.Text = "";
                txtAmount2.Text = "";
                txtTotal2.Text = "";
                txtFront2.Text = "2/1";
                txtMeterS2.Text = "";
                txtMeterE2.Text = "";
                txtRemark2.Text = "";
                txtQ2.Text = "";

                if (lvMode == "")
                {
                    FncGetModeTab("");
                    ShowBtn();
                    btnAdd.Focus();
                }
            }

            if (lvTab == "3" || lvTab == "ALL")
            {
                txtQuota3.Text = "";
                txtCarNumS3.Text = "";
                txtCarNumE3.Text = "";
                txtName3.Text = "";
                txtCaneS3.Text = "";
                txtCaneNo3.Text = "";
                txtOil3.Text = "01 : โซล่า";
                txtlitter3.Text = "";
                txtAmount3.Text = "";
                txtTotal3.Text = "";
                txtFront3.Text = "2/2";
                txtMeterS3.Text = "";
                txtMeterE3.Text = "";
                txtRemark3.Text = "";
                txtQ3.Text = "";

                if (lvMode == "")
                {
                    FncGetModeTab("");
                    ShowBtn();
                    btnAdd.Focus();
                }
            }

            if (lvTab == "4" || lvTab == "ALL")
            {
                txtQuota4.Text = "";
                txtCarNumS4.Text = "";
                txtCarNumE4.Text = "";
                txtName4.Text = "";
                txtCaneS4.Text = "";
                txtCaneNo4.Text = "";
                txtOil4.Text = "01 : โซล่า";
                txtlitter4.Text = "";
                txtAmount4.Text = "";
                txtTotal4.Text = "";
                txtFront4.Text = "3/1";
                txtMeterS4.Text = "";
                txtMeterE4.Text = "";
                txtRemark4.Text = "";
                txtQ4.Text = "";

                if (lvMode == "")
                {
                    FncGetModeTab("");
                    ShowBtn();
                    btnAdd.Focus();
                }
            }

            if (lvTab == "5" || lvTab == "ALL")
            {
                txtQuota5.Text = "";
                txtCarNumS5.Text = "";
                txtCarNumE5.Text = "";
                txtName5.Text = "";
                txtCaneS5.Text = "";
                txtCaneNo5.Text = "";
                txtOil5.Text = "01 : โซล่า";
                txtlitter5.Text = "";
                txtAmount5.Text = "";
                txtTotal5.Text = "";
                txtFront5.Text = "3/2";
                txtMeterS5.Text = "";
                txtMeterE5.Text = "";
                txtRemark5.Text = "";
                txtQ5.Text = "";

                if (lvMode == "")
                {
                    FncGetModeTab("");
                    ShowBtn();
                    btnAdd.Focus();
                }
            }

            if (lvTab == "6" || lvTab == "ALL")
            {
                txtDept.Text = "";
                //txtIssue.Text = "";
                txtObjective.Text = "";
                txtBudjet.Text = "";
                txtAsset.Text = "";
                txtCarNumS6.Text = "";
                txtCarNumE6.Text = "";
                txtName6.Text = "";
                txtOil6.Text = "01 : โซล่า";
                txtLitter6.Text = "";
                txtAmount6.Text = "";
                txtTotal6.Text = "";
                txtFront6.Text = "";
                txtMeterS6.Text = "";
                txtMeterE6.Text = "";
                txtRemark6.Text = "";
                txtEmpID.Text = "";
                txtEmpName.Text = "";
                txtPdIn.Text = "";
                txtPdOut.Text = "";
                txtTotal6.Text = "";
                txtType.Text = "";

                if (lvMode == "")
                {
                    FncGetModeTab("");
                    ShowBtn();
                    btnAdd.Focus();
                }
            }

            sp1.ActiveSheet.RowCount = 0;

        }

        private void sp1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int lvRowIndex = sp1.ActiveSheet.ActiveRowIndex;
                int lvColIndex = sp1.ActiveSheet.ActiveColumnIndex;

                if (lvColIndex == 0)
                {
                    if (sp1.ActiveSheet.Cells[lvRowIndex,lvColIndex].Text != "")
                        sp1.ActiveSheet.SetActiveCell(lvRowIndex, 3);
                }
                else if (lvColIndex == 3)
                {
                    try
                    {
                        if (sp1.ActiveSheet.Cells[lvRowIndex, lvColIndex].Text != "")
                        {
                            if (sp1.ActiveSheet.Cells[lvRowIndex + 1, 0].Text == "" || sp1.ActiveSheet.Cells[lvRowIndex + 1, 0].Text == "0")
                                sp1.ActiveSheet.SetActiveCell(lvRowIndex + 1, 0);
                            else
                                sp1.ActiveSheet.SetActiveCell(lvRowIndex + 1, 3);
                        }
                    }
                    catch
                    {
                        if (sp1.ActiveSheet.Cells[lvRowIndex, lvColIndex].Text != "")
                            sp1.ActiveSheet.SetActiveCell(lvRowIndex, 3);
                    }
                }
            }
        }

        private void cmbDocNo_QueryPopUp(object sender, CancelEventArgs e)
        {
            if (pvMode == "")
            {
                //Get Last Doc
                DataTable DT = new DataTable();
                string lvSQL = "Select Top 50 O_DocNo from Cane_OilBillHD where O_DocS = '" + txtDocS.Text + "' ";
                DT = GsysSQL.fncGetQueryData(lvSQL, DT);

                cmbDocNo.Properties.Items.Clear();
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    cmbDocNo.Properties.Items.Add(DT.Rows[i]["O_DocNo"].ToString());
                }

                DT.Dispose();
            }
        }

        private void LoadData(string lvDocNo, string lvBillNo, string lvQNo)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "Select * from Cane_OilBillHD where 1=1 ";

            if (lvDocNo != "")
                lvSQL += "And O_DocNo = '" + lvDocNo + "'";

            if (lvBillNo != "")
                lvSQL += "And O_CaneNo = '" + lvBillNo + "'";

            if (lvQNo != "")
                lvSQL += "And O_QNo = '" + lvQNo + "' And O_CloseStatus = '' ";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;
            //HD
            string lvFront = "";
            for (int i = 0; i < lvNumRow; i++)
            {
                lvFront = DT.Rows[i]["O_CarFront"].ToString();
                GVar.gvCarFront = lvFront;

                if (lvFront == "1/1")
                {
                    if (txtQuota.Text != "" && pvMode0 != "")
                    {
                        MessageBox.Show("ไม่สามารถโหลดข้อมูลได้ เนื่องจาก ยังมีเอกสารที่ยังไม่ได้บันทึก กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        tabPageAll.SelectedIndex = 0;
                        return;
                    }
                }
                else if (lvFront == "1/2")
                {
                    if (txtQuota1.Text != "" && pvMode1 != "")
                    {
                        MessageBox.Show("ไม่สามารถโหลดข้อมูลได้ เนื่องจาก ยังมีเอกสารที่ยังไม่ได้บันทึก กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabPageAll.SelectedIndex = 1;
                        return;
                    }
                }
                else if (lvFront == "2/1")
                {
                    if (txtQuota2.Text != "" && pvMode2 != "")
                    {
                        MessageBox.Show("ไม่สามารถโหลดข้อมูลได้ เนื่องจาก ยังมีเอกสารที่ยังไม่ได้บันทึก กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabPageAll.SelectedIndex = 2;
                        return;
                    }
                }
                else if (lvFront == "2/2")
                {
                    if (txtQuota3.Text != "" && pvMode3 != "")
                    {
                        MessageBox.Show("ไม่สามารถโหลดข้อมูลได้ เนื่องจาก ยังมีเอกสารที่ยังไม่ได้บันทึก กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabPageAll.SelectedIndex = 3;
                        return;
                    }
                }
                else if (lvFront == "3/1")
                {
                    if (txtQuota4.Text != "" && pvMode4 != "")
                    {
                        MessageBox.Show("ไม่สามารถโหลดข้อมูลได้ เนื่องจาก ยังมีเอกสารที่ยังไม่ได้บันทึก กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabPageAll.SelectedIndex = 4;
                        return;
                    }
                }
                else if (lvFront == "3/2")
                {
                    if (txtQuota5.Text != "" && pvMode5 != "")
                    {
                        MessageBox.Show("ไม่สามารถโหลดข้อมูลได้ เนื่องจาก ยังมีเอกสารที่ยังไม่ได้บันทึก กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabPageAll.SelectedIndex = 5;
                        return;
                    }
                }

                txtDocS.Text = DT.Rows[i]["O_DocS"].ToString();
                cmbDocNo.Text = DT.Rows[i]["O_DocNo"].ToString();
                txtDate.Text = Gstr.fncChangeSDate(DT.Rows[i]["O_Date"].ToString());

                //ถ้าเป็นใบเบิก
                if (cmbDocNo.Text.Contains("C-")) lvFront = "6/6";

                if (lvFront == "1/1")
                {
                    txtQuota.Text = DT.Rows[i]["O_Quota"].ToString();

                    try
                    {
                        string[] lvArr = DT.Rows[i]["O_CarNum"].ToString().Split('-');
                        txtCarNumS.Text = lvArr[0];
                        txtCarNumE.Text = lvArr[1];
                    }
                    catch
                    {
                        txtCarNumE.Text = DT.Rows[i]["O_CarNum"].ToString();
                    }

                    txtName.Text = DT.Rows[i]["O_Name"].ToString();
                    txtCaneS.Text = DT.Rows[i]["O_CaneS"].ToString();
                    txtCaneNo.Text = DT.Rows[i]["O_CaneNo"].ToString();
                    txtFront.Text = DT.Rows[i]["O_CarFront"].ToString();
                    txtMeterS.Text = DT.Rows[i]["O_MeterS"].ToString();
                    txtMeterE.Text = DT.Rows[i]["O_MeterE"].ToString();
                    txtQ.Text = DT.Rows[i]["O_QNo"].ToString();

                    if (txtCarNumS.Text.Contains("a"))
                    {
                        rdCarry.Checked = true;
                    }
                    else
                    {
                        rdCarry.Checked = false;
                    }

                    tabPageAll.SelectedIndex = 0;
                }
                else if (lvFront == "1/2")
                {
                    txtQuota1.Text = DT.Rows[i]["O_Quota"].ToString();

                    try
                    {
                        string[] lvArr = DT.Rows[i]["O_CarNum"].ToString().Split('-');
                        txtCarNumS1.Text = lvArr[0];
                        txtCarNumE1.Text = lvArr[1];
                    }
                    catch
                    {
                        txtCarNumE1.Text = DT.Rows[i]["O_CarNum"].ToString();
                    }

                    txtName1.Text = DT.Rows[i]["O_Name"].ToString();
                    txtCaneS1.Text = DT.Rows[i]["O_CaneS"].ToString();
                    txtCaneNo1.Text = DT.Rows[i]["O_CaneNo"].ToString();
                    txtFront1.Text = DT.Rows[i]["O_CarFront"].ToString();
                    txtMeterS1.Text = DT.Rows[i]["O_MeterS"].ToString();
                    txtMeterE1.Text = DT.Rows[i]["O_MeterE"].ToString();
                    txtQ1.Text = DT.Rows[i]["O_QNo"].ToString();

                    if (txtCarNumS1.Text.Contains("a"))
                    {
                        rdCarry.Checked = true;
                    }
                    else
                    {
                        rdCarry.Checked = false;
                    }

                    tabPageAll.SelectedIndex = 1;
                }
                else if (lvFront == "2/1")
                {
                    txtQuota2.Text = DT.Rows[i]["O_Quota"].ToString();

                    try
                    {
                        string[] lvArr = DT.Rows[i]["O_CarNum"].ToString().Split('-');
                        txtCarNumS2.Text = lvArr[0];
                        txtCarNumE2.Text = lvArr[1];
                    }
                    catch
                    {
                        txtCarNumE2.Text = DT.Rows[i]["O_CarNum"].ToString();
                    }

                    txtName2.Text = DT.Rows[i]["O_Name"].ToString();
                    txtCaneS2.Text = DT.Rows[i]["O_CaneS"].ToString();
                    txtCaneNo2.Text = DT.Rows[i]["O_CaneNo"].ToString();
                    txtFront2.Text = DT.Rows[i]["O_CarFront"].ToString();
                    txtMeterS2.Text = DT.Rows[i]["O_MeterS"].ToString();
                    txtMeterE2.Text = DT.Rows[i]["O_MeterE"].ToString();
                    txtQ2.Text = DT.Rows[i]["O_QNo"].ToString();

                    if (txtCarNumS2.Text.Contains("a"))
                    {
                        rdCarry.Checked = true;
                    }
                    else
                    {
                        rdCarry.Checked = false;
                    }

                    tabPageAll.SelectedIndex = 2;
                }
                else if (lvFront == "2/2")
                {
                    txtQuota3.Text = DT.Rows[i]["O_Quota"].ToString();

                    try
                    {
                        string[] lvArr = DT.Rows[i]["O_CarNum"].ToString().Split('-');
                        txtCarNumS3.Text = lvArr[0];
                        txtCarNumE3.Text = lvArr[1];
                    }
                    catch
                    {
                        txtCarNumE3.Text = DT.Rows[i]["O_CarNum"].ToString();
                    }

                    txtName3.Text = DT.Rows[i]["O_Name"].ToString();
                    txtCaneS3.Text = DT.Rows[i]["O_CaneS"].ToString();
                    txtCaneNo3.Text = DT.Rows[i]["O_CaneNo"].ToString();
                    txtFront3.Text = DT.Rows[i]["O_CarFront"].ToString();
                    txtMeterS3.Text = DT.Rows[i]["O_MeterS"].ToString();
                    txtMeterE3.Text = DT.Rows[i]["O_MeterE"].ToString();
                    txtQ3.Text = DT.Rows[i]["O_QNo"].ToString();

                    if (txtCarNumS3.Text.Contains("a"))
                    {
                        rdCarry.Checked = true;
                    }
                    else
                    {
                        rdCarry.Checked = false;
                    }

                    tabPageAll.SelectedIndex = 3;
                }
                else if (lvFront == "3/1")
                {
                    txtQuota4.Text = DT.Rows[i]["O_Quota"].ToString();

                    try
                    {
                        string[] lvArr = DT.Rows[i]["O_CarNum"].ToString().Split('-');
                        txtCarNumS4.Text = lvArr[0];
                        txtCarNumE4.Text = lvArr[1];
                    }
                    catch
                    {
                        txtCarNumE4.Text = DT.Rows[i]["O_CarNum"].ToString();
                    }

                    txtName4.Text = DT.Rows[i]["O_Name"].ToString();
                    txtCaneS4.Text = DT.Rows[i]["O_CaneS"].ToString();
                    txtCaneNo4.Text = DT.Rows[i]["O_CaneNo"].ToString();
                    txtFront4.Text = DT.Rows[i]["O_CarFront"].ToString();
                    txtMeterS4.Text = DT.Rows[i]["O_MeterS"].ToString();
                    txtMeterE4.Text = DT.Rows[i]["O_MeterE"].ToString();
                    txtQ4.Text = DT.Rows[i]["O_QNo"].ToString();

                    if (txtCarNumS4.Text.Contains("a"))
                    {
                        rdCarry.Checked = true;
                    }
                    else
                    {
                        rdCarry.Checked = false;
                    }

                    tabPageAll.SelectedIndex = 4;
                }
                else if (lvFront == "3/2")
                {
                    txtQuota5.Text = DT.Rows[i]["O_Quota"].ToString();

                    try
                    {
                        string[] lvArr = DT.Rows[i]["O_CarNum"].ToString().Split('-');
                        txtCarNumS5.Text = lvArr[0];
                        txtCarNumE5.Text = lvArr[1];
                    }
                    catch
                    {
                        txtCarNumE5.Text = DT.Rows[i]["O_CarNum"].ToString();
                    }

                    txtName5.Text = DT.Rows[i]["O_Name"].ToString();
                    txtCaneS5.Text = DT.Rows[i]["O_CaneS"].ToString();
                    txtCaneNo5.Text = DT.Rows[i]["O_CaneNo"].ToString();
                    txtFront5.Text = DT.Rows[i]["O_CarFront"].ToString();
                    txtMeterS5.Text = DT.Rows[i]["O_MeterS"].ToString();
                    txtMeterE5.Text = DT.Rows[i]["O_MeterE"].ToString();
                    txtQ5.Text = DT.Rows[i]["O_QNo"].ToString();

                    if (txtCarNumS5.Text.Contains("a"))
                    {
                        rdCarry.Checked = true;
                    }
                    else
                    {
                        rdCarry.Checked = false;
                    }

                    tabPageAll.SelectedIndex = 5;
                }
                else if (lvFront == "6/6")
                {
                    try
                    {
                        string[] lvArr = DT.Rows[i]["O_CarNum"].ToString().Split('-');
                        txtCarNumS6.Text = lvArr[0];
                        txtCarNumE6.Text = lvArr[1];
                    }
                    catch
                    {
                        txtCarNumE6.Text = DT.Rows[i]["O_CarNum"].ToString();
                    }

                    txtName6.Text = DT.Rows[i]["O_Name"].ToString();
                    txtFront6.Text = DT.Rows[i]["O_CarFront"].ToString();
                    txtMeterS6.Text = DT.Rows[i]["O_MeterS"].ToString();
                    txtMeterE6.Text = DT.Rows[i]["O_MeterE"].ToString();

                    txtDept.Text = DT.Rows[i]["O_Dept"].ToString();
                    txtIssue.Text = DT.Rows[i]["O_Issue"].ToString();
                    txtObjective.Text = DT.Rows[i]["O_Objective"].ToString();
                    txtBudjet.Text = DT.Rows[i]["O_Budjet"].ToString();
                    txtAsset.Text = DT.Rows[i]["O_Asset"].ToString();
                    txtRemark6.Text = DT.Rows[i]["O_Remark"].ToString();
                    txtEmpID.Text = DT.Rows[i]["O_EmpID"].ToString();
                    if (txtEmpID.Text != "")
                        txtEmpName.Text = GsysSQL.fncFindEmpFullName(DT.Rows[i]["O_EmpID"].ToString());
                    else
                        txtEmpName.Text = DT.Rows[i]["O_EmpName"].ToString();
                    txtPdIn.Text = DT.Rows[i]["O_PdIn"].ToString();
                    txtPdOut.Text = DT.Rows[i]["O_PdOut"].ToString();
                    txtCarNumS6.Text = DT.Rows[i]["O_CarnumS6"].ToString();
                    txtCarNumE6.Text = DT.Rows[i]["O_CarnumE6"].ToString();

                    rdIssue.Checked = true;
                    tabPageAll.SelectedIndex = 6;
                }
                
            }
            
            //สถานะบิล
            //if (cmbDocNo.Text.Contains("C-")) rdIssue.Checked = true;
            //else if (cmbDocNo.Text.Contains("A-")) rdCarry.Checked = true;
            //else rdOil.Checked = true;

            DT.Dispose();
            //DT
            DataTable DT1 = new DataTable();
            lvSQL = "Select * from Cane_OilBillDT Inner Join Cane_OillItem on O_Item = C_Item where O_DocNo = '" + cmbDocNo.Text + "' ";
            DT1 = GsysSQL.fncGetQueryData(lvSQL, DT1);

            if (DT1.Rows.Count > 0)
            {
                if (lvFront == "1/1")
                {
                    txtAmount.Text = DT1.Rows[0]["O_Litter"].ToString();
                    txtOil.Text = DT1.Rows[0]["O_Item"].ToString() + " : " + DT1.Rows[0]["C_ItemName"].ToString();
                    txtlitter.Text = DT1.Rows[0]["O_Price"].ToString();
                    txtRemark.Text = DT1.Rows[0]["O_Remark"].ToString();
                    txtTotal.Text = Gstr.fncToDouble(DT1.Rows[0]["O_Total"].ToString()).ToString("#,###.#0");
                }
                else if (lvFront == "1/2")
                {
                    txtAmount1.Text = DT1.Rows[0]["O_Litter"].ToString();
                    txtOil1.Text = DT1.Rows[0]["O_Item"].ToString() + " : " + DT1.Rows[0]["C_ItemName"].ToString();
                    txtlitter1.Text = DT1.Rows[0]["O_Price"].ToString();
                    txtRemark1.Text = DT1.Rows[0]["O_Remark"].ToString();
                    txtTotal1.Text = Gstr.fncToDouble(DT1.Rows[0]["O_Total"].ToString()).ToString("#,###.#0");
                }
                else if (lvFront == "2/1")
                {
                    txtAmount2.Text = DT1.Rows[0]["O_Litter"].ToString();
                    txtOil2.Text = DT1.Rows[0]["O_Item"].ToString() + " : " + DT1.Rows[0]["C_ItemName"].ToString();
                    txtlitter2.Text = DT1.Rows[0]["O_Price"].ToString();
                    txtRemark2.Text = DT1.Rows[0]["O_Remark"].ToString();
                    txtTotal2.Text = Gstr.fncToDouble(DT1.Rows[0]["O_Total"].ToString()).ToString("#,###.#0");
                }
                else if (lvFront == "2/2")
                {
                    txtAmount3.Text = DT1.Rows[0]["O_Litter"].ToString();
                    txtOil3.Text = DT1.Rows[0]["O_Item"].ToString() + " : " + DT1.Rows[0]["C_ItemName"].ToString();
                    txtlitter3.Text = DT1.Rows[0]["O_Price"].ToString();
                    txtRemark3.Text = DT1.Rows[0]["O_Remark"].ToString();
                    txtTotal3.Text = Gstr.fncToDouble(DT1.Rows[0]["O_Total"].ToString()).ToString("#,###.#0");
                }
                else if (lvFront == "3/1")
                {
                    txtAmount4.Text = DT1.Rows[0]["O_Litter"].ToString();
                    txtOil4.Text = DT1.Rows[0]["O_Item"].ToString() + " : " + DT1.Rows[0]["C_ItemName"].ToString();
                    txtlitter4.Text = DT1.Rows[0]["O_Price"].ToString();
                    txtRemark4.Text = DT1.Rows[0]["O_Remark"].ToString();
                    txtTotal4.Text = Gstr.fncToDouble(DT1.Rows[0]["O_Total"].ToString()).ToString("#,###.#0");
                }
                else if (lvFront == "3/2")
                {
                    txtAmount5.Text = DT1.Rows[0]["O_Litter"].ToString();
                    txtOil5.Text = DT1.Rows[0]["O_Item"].ToString() + " : " + DT1.Rows[0]["C_ItemName"].ToString();
                    txtlitter5.Text = DT1.Rows[0]["O_Price"].ToString();
                    txtRemark5.Text = DT1.Rows[0]["O_Remark"].ToString();
                    txtTotal5.Text = Gstr.fncToDouble(DT1.Rows[0]["O_Total"].ToString()).ToString("#,###.#0");
                }
                else if (lvFront == "6/6")
                {
                    txtAmount6.Text = DT1.Rows[0]["O_Litter"].ToString();
                    txtOil6.Text = DT1.Rows[0]["O_Item"].ToString() + " : " + DT1.Rows[0]["C_ItemName"].ToString();
                    txtLitter6.Text = DT1.Rows[0]["O_Price"].ToString();
                    txtRemark6.Text = DT1.Rows[0]["O_Remark"].ToString();
                    txtTotal6.Text = Gstr.fncToDouble(DT1.Rows[0]["O_Total"].ToString()).ToString("#,###.#0");
                }
            }

            DT1.Dispose();

            pvMode = "";
            ShowBtn();
        }

        private void cmbDocNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pvMode == "")
                LoadData(cmbDocNo.Text,"", "");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (pvMode == "")
            {
                GVar.gvDocNo = "";
                GVar.gvDocS = "";
                GVar.gvCarFront = "";

                frmBrowse frm = new frmBrowse();
                frm.LoadData();
                frm.ShowDialog();

                if (GVar.gvDocNo != "")
                {
                    txtDocS.Text = GVar.gvDocS;
                    cmbDocNo.Text = GVar.gvDocNo;
                    LoadData(cmbDocNo.Text, "", "");
                    //LoadDataDetail();
                }
            }
        }

        private void txtDocS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbDocNo.Focus();
            }
        }

        private void cmbDocNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDate.Focus();
            }
        }

        private void txtDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQuota.Focus();
            }
        }

        private void txtQuota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQuota(txtQuota, txtName, txtCarNumS);
            }
        }

        private void txtCarNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCarNumS.Text != "")
                    txtCarNumE.Focus();
                else
                    txtCarNumS.Focus();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCaneS.Focus();
            }
        }

        private void txtCaneS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCaneNo.Focus();
            }
        }

        private void txtFront_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMeterS.Text = GsysSQL.fncFindMeterOil(txtFront.Text);

                if (txtMeterS.Text != "")
                {
                    int lvMeterS = Gstr.fncToInt(txtMeterS.Text);
                    int lvLitter = Gstr.fncToInt(txtAmount.Text);
                    int lvMeterE = lvMeterS + lvLitter;
                    txtMeterE.Text = lvMeterE.ToString();
                    btnSave_Click(sender, e);
                }
                else
                {
                    txtMeterE.Text = "";
                    txtMeterS.Focus();
                }
            
            }
        }

        private void txtCaneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownBill(txtCaneNo);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            CPrint.Show(Cursor.Position);
        }

        private void ใบเสรจToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region เก็บค่า
            if (tabPageAll.SelectedIndex == 0)
            {
                FncPrint(txtName,txtQuota,txtCarNumS,txtCarNumE, txtCaneNo,txtAmount,txtlitter,txtTotal,txtRemark, txtMeterS, txtMeterE, txtFront);
            }
            else if (tabPageAll.SelectedIndex == 1)
            {
                FncPrint(txtName1, txtQuota1, txtCarNumS1, txtCarNumE1, txtCaneNo1, txtAmount1, txtlitter1, txtTotal1, txtRemark1, txtMeterS1, txtMeterE1, txtFront1);
            }
            else if (tabPageAll.SelectedIndex == 2)
            {
                FncPrint(txtName2, txtQuota2, txtCarNumS2, txtCarNumE2, txtCaneNo2, txtAmount2, txtlitter2, txtTotal2, txtRemark2, txtMeterS2, txtMeterE2, txtFront2);
            }
            else if (tabPageAll.SelectedIndex == 3)
            {
                FncPrint(txtName3, txtQuota3, txtCarNumS3, txtCarNumE3, txtCaneNo3, txtAmount3, txtlitter3, txtTotal3, txtRemark3, txtMeterS3, txtMeterE3, txtFront3);
            }
            else if (tabPageAll.SelectedIndex == 4)
            {
                FncPrint(txtName4, txtQuota4, txtCarNumS4, txtCarNumE4, txtCaneNo4, txtAmount4, txtlitter4, txtTotal4, txtRemark4, txtMeterS4, txtMeterE4, txtFront4);
            }
            else if (tabPageAll.SelectedIndex == 5)
            {
                FncPrint(txtName5, txtQuota5, txtCarNumS5, txtCarNumE5, txtCaneNo5, txtAmount5, txtlitter5, txtTotal5, txtRemark5, txtMeterS5, txtMeterE5, txtFront5);
            }
            else if (tabPageAll.SelectedIndex == 6)
            {
                //ใบเบิกไม่มี
            }
            #endregion  

            frmPrint frm = new frmPrint();
            frm.ShowDialog();
        }

        private void พิมพ์ต่อเนื่องToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrintMulti frm = new frmPrintMulti();
            frm.ShowDialog();

            if (GVar.gvDocS != "")
            {
                FncPrintMulti(GVar.gvDocS, GVar.gvDocE);

                frmPrint frmP = new frmPrint();
                frmP.ShowDialog();
            }
        }

        private void FncPrint(TextEdit tName,TextEdit tQouta,TextEdit tCarNumS, TextEdit tCarNumE, TextEdit tBillno, TextEdit tLitter, TextEdit tPricePer, TextEdit tPrice, TextEdit tRemark, TextEdit tMeterS, TextEdit tMeterE, TextEdit tFront)
        {
            //ลบข้อมูล
            string lvSQL = "Delete From SysTemp ";
            string lvResault = GsysSQL.fncExecuteQueryDataAccess(lvSQL);

            //ตัวแปร
            string lvDocNo = cmbDocNo.Text;
            string[] lvArr = txtDate.Text.Split('/');
            string lvDay = lvArr[0];
            string lvMonth = lvArr[1];
            string lvYear = lvArr[2];
            string lvName = tName.Text;
            string lvQuota = tQouta.Text;
            string lvCarNum = tCarNumS.Text + "." + tCarNumE.Text;
            string lvBillNo = tBillno.Text;
            string lvLitter = tLitter.Text;
            string lvPricePer = tPricePer.Text;

            string[] lvPArr = tPrice.Text.Split('.');
            string lvPrice = lvPArr[0];
            string lvPrice2 = lvPArr[1];
            string lvRemark = tRemark.Text;

            string lvMeterS = tMeterS.Text;
            string lvMeterE = tMeterE.Text;

            string lvFront = tFront.Text;

            string lvproductIn = txtPdIn.Text;
            string lvproductOut = txtPdOut.Text;

            string lvCarnumS6 = txtCarNumS6.Text;
            string lvCarnumE6 = txtCarNumE6.Text;

            string lvTotal6 = txtTotal6.Text;

            //เพิ่ม
            lvSQL = "Insert into SysTemp (Field1, Field2, Field3, Field4, Field5, Field6, Field7, Field8, Field9, Num1, Num2, Num3, Num4, Field10, Field11, Field12, Field13, Field14, Field15, Field16, Field17) ";//
            lvSQL += "Values ('" + lvDocNo + "', '" + lvDay + "', '" + lvMonth + "', '" + lvYear + "', '" + lvName + "', '" + lvQuota + "', '" + lvCarNum + "', '" + lvBillNo + "', '" + lvRemark + "', '" + lvLitter + "', '" + lvPricePer + "', '" + lvPrice + "', '" + lvPrice2 + "', '" + lvMeterS + "', '" + lvMeterE + "', '" + lvFront + "', '" + lvproductIn + "', '" + lvproductOut + "', '" + lvCarnumS6 + "', '" + lvCarnumE6 + "', '" + lvTotal6 + "') ";
            lvResault = GsysSQL.fncExecuteQueryDataAccess(lvSQL);
            
        }

        private void FncPrintMulti(string lvDocS,string lvDocE)
        {
            //ลบข้อมูล
            string lvSQL = "Delete From SysTempOilBill ";
            string lvResault = GsysSQL.fncExecuteQueryData(lvSQL);
            //ลบข้อมูล
            lvSQL = "Delete From SysTempOilBill_DT ";
            lvResault = GsysSQL.fncExecuteQueryData(lvSQL);

            //ตัวแปร
            string lvFieldHD1 = "";
            string lvFieldHD2 = "";
            string lvFieldHD3 = "";
            string lvFieldHD4 = "";
            string lvFieldHD5 = "";
            string lvFieldHD6 = "";
            string lvFieldHD7 = "";
            string lvFieldHD8 = "";
            string lvFieldHD9 = "";
            string lvFieldHD10 = "";
            string lvFieldHD11 = "";
            string lvFieldHD12 = "";
            string lvFieldHD13 = "";
            string lvFieldHD14 = "";
            string lvFieldHD15 = "";
            string lvFieldHD16 = "";

            //Get Data
            DataTable DT = new DataTable();
            lvSQL = "Select * from Cane_OilBillHD where O_DocNo >= '" + lvDocS + "' And O_DocNo <= '" + lvDocE + "' ";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;

            //progressBar1.Maximum = lvNumRow + 1;
            //progressBar1.Value = 1;
            //pnStatus.Visible = true;

            for (int i = 0; i < lvNumRow; i++)
            {
                lvFieldHD1 = DT.Rows[i]["O_DocS"].ToString();
                lvFieldHD2 = DT.Rows[i]["O_DocNo"].ToString();

                try
                {
                    string[] lvDate = Gstr.fncChangeSDate(DT.Rows[i]["O_Date"].ToString()).Split('/');
                    lvFieldHD3 = lvDate[0];
                    lvFieldHD4 = lvDate[1];
                    lvFieldHD5 = lvDate[2];
                }
                catch
                {
                    lvFieldHD3 = "";
                    lvFieldHD4 = "";
                    lvFieldHD5 = "";
                }

                lvFieldHD6 = DT.Rows[i]["O_Name"].ToString();
                lvFieldHD7 = DT.Rows[i]["O_Quota"].ToString();
                lvFieldHD8 = DT.Rows[i]["O_CarNum"].ToString();
                lvFieldHD9 = DT.Rows[i]["O_CarFront"].ToString();
                lvFieldHD10 = DT.Rows[i]["O_CaneS"].ToString();
                lvFieldHD11 = DT.Rows[i]["O_CaneNo"].ToString();
                lvFieldHD12 = DT.Rows[i]["O_PdIn"].ToString();
                lvFieldHD13 = DT.Rows[i]["O_PdOut"].ToString();
                lvFieldHD14 = DT.Rows[i]["O_CarnumS6"].ToString();
                lvFieldHD15 = DT.Rows[i]["O_CarnumE6"].ToString();


                //เพิ่ม HD
                lvSQL = "Insert into SysTempOilBill (S_Fieid1, S_Fieid2, S_Fieid3, S_Fieid4, S_Fieid5, S_Fieid6, S_Fieid7, S_Fieid8, S_Fieid9, S_Fieid10, S_Fieid11, S_Field12, S_Field13, S_Field14, S_Field15) ";
                lvSQL += "Values ('" + lvFieldHD1 + "', '" + lvFieldHD2 + "', '" + lvFieldHD3 + "', '" + lvFieldHD4 + "', '" + lvFieldHD5 + "', '" + lvFieldHD6 + "', '" + lvFieldHD7 + "', '" + lvFieldHD8 + "', '" + lvFieldHD9 + "', '" + lvFieldHD10 + "', '" + lvFieldHD11 + "', '" + lvFieldHD12 + "', '" + lvFieldHD13 + "', '" + lvFieldHD14 + "', '" + lvFieldHD15 + "')";
                GsysSQL.fncExecuteQueryData(lvSQL);

                //DT
                //Get Data
                DataTable DT_Detail = new DataTable();
                lvSQL = "Select * from Cane_OilBillDT Inner Join Cane_OillItem on O_Item = C_Item where O_DocNo = '" + DT.Rows[i]["O_DocNo"].ToString() + "' ";
                DT_Detail = GsysSQL.fncGetQueryData(lvSQL, DT_Detail);

                int lvRowCount = DT_Detail.Rows.Count;
                for (int l = 0; l < lvRowCount; l++)
                {
                    string lvField1 = DT_Detail.Rows[l]["O_Litter"].ToString();
                    string lvField2 = DT_Detail.Rows[l]["C_ItemName"].ToString();
                    string lvField3 = DT_Detail.Rows[l]["O_Price"].ToString();

                    string[] lvArr = DT_Detail.Rows[l]["O_Price"].ToString().Split('.');
                    string lv1 = "";
                    string lv2 = "";

                    try
                    {
                        lv1 = lvArr[0];
                        lv2 = lvArr[1];
                    }
                    catch
                    {

                    }

                    string lvField4 = lv1; //บาท
                    string lvField5 = lv2; //สตางค์
                    string lvField6 = DT_Detail.Rows[l]["O_Remark"].ToString(); //หมายเหตุ
                    string lvField7 = DT.Rows[i]["O_DocNo"].ToString();

                    //เพิ่ม
                    lvSQL = "Insert into SysTempOilBill_DT (S_Fieid1, S_Fieid2, S_Fieid3, S_Fieid4, S_Fieid5, S_Fieid6, S_Fieid7) ";
                    lvSQL += "Values ('" + lvField1 + "', '" + lvField2 + "', '" + lvField3 + "', '" + lvField4 + "', '" + lvField5 + "', '" + lvField6 + "', '" + lvField7 + "')";
                    GsysSQL.fncExecuteQueryData(lvSQL);
                }

                //progressBar1.Value += 1;
                //Application.DoEvents();
            }

            //pnStatus.Visible = false;

        }

        private void txtlitter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAmount.Focus();
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownLitAmount(txtAmount, txtlitter, txtTotal, txtMeterS, txtMeterE, txtFront);
            }
        }

        private void txtOil_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "Select C_Item, C_ItemName from Cane_OillItem ";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            txtOil.Properties.Items.Clear();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string lvData = DT.Rows[i]["C_Item"].ToString() + " : " + DT.Rows[i]["C_ItemName"].ToString();
                txtOil.Properties.Items.Add(lvData);
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            txtQuota.Focus();
        }

        private void btnEditPrice_Click(object sender, EventArgs e)
        {
            if (txtlitter.Text == "")
            {
                MessageBox.Show("กรุณาระบุราคาต่อลิตร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlitter.Focus();
                return;
            }

            //ยืนยัน
            DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string lvItem = Gstr.fncGetDataCode(txtOil.Text, ":");

            //Update ราคา
            string lvSQL = "Update Cane_OillItem set C_ItemPrice = '"+ txtlitter.Text +"' Where C_Item = '" + lvItem + "' ";
            GsysSQL.fncExecuteQueryData(lvSQL);

            string lvTXT = "แก้ไขราคาน้ำมัน เป็น " + txtlitter.Text + " บาท/ลิตร";
            GsysSQL.fncKeepLogData("ป้อมน้ำมัน", "บิลน้ำมัน", lvTXT); 

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadDataDetail(string lvCarFront)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "select Top 50 O_Name,O_Quota,O_DocS,Cane_OilBillHD.O_DocNo ,O_Litter,O_Price,O_Total,O_CarNum,O_Date,C_ItemName ";
            lvSQL += "from Cane_OilBillHD ";
            lvSQL += "inner join Cane_OilBillDT on Cane_OilBillHD.O_DocNo = Cane_OilBillDT.O_DocNo ";
            lvSQL += "inner join Cane_OillItem on Cane_OilBillDT.O_Item = Cane_OillItem.C_Item ";
            lvSQL += "where O_CarFront = '" + lvCarFront + "' ";

            if (rdCarry.Checked)
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo like 'A-%' ";
            }
            else
            {
                lvSQL += "And Cane_OilBillHD.O_DocNo not like 'A-%' ";
            }

            lvSQL += "And O_Status = '' ";
            lvSQL += "Order by O_DocNo Desc ";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);
            int lvNumRow = DT.Rows.Count;

            sp1.ActiveSheet.RowCount = lvNumRow;
            for (int i = 0; i < lvNumRow ; i++)
            {
                sp1.ActiveSheet.Cells[i, 0].Text = Gstr.fncChangeSDate(DT.Rows[i]["O_Date"].ToString());
                sp1.ActiveSheet.Cells[i, 1].Text = DT.Rows[i]["O_DocNo"].ToString();
                sp1.ActiveSheet.Cells[i, 2].Text = DT.Rows[i]["C_ItemName"].ToString();
                sp1.ActiveSheet.Cells[i, 3].Text = DT.Rows[i]["O_Litter"].ToString();
                sp1.ActiveSheet.Cells[i, 4].Text = DT.Rows[i]["O_Price"].ToString();

                string[] lvArr = DT.Rows[i]["O_Total"].ToString().Split('.');
                sp1.ActiveSheet.Cells[i, 5].Text = lvArr[0];
                try
                {
                    sp1.ActiveSheet.Cells[i, 6].Text = lvArr[1];
                }
                catch
                {
                    sp1.ActiveSheet.Cells[i, 6].Text = "";
                }
                sp1.ActiveSheet.Cells[i, 7].Text = DT.Rows[i]["O_CarNum"].ToString();
            }
        }

        private void รายงานสรปToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchPrint frm = new frmSearchPrint();
            frm.ShowDialog();
        }
        
        private void frmBill_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && pvMode == "" && btnAdd.Enabled)
            {
                btnAdd_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F2 && pvMode == "" && btnEdit.Enabled)
            {
                btnEdit_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F3 && pvMode != "" && btnSave.Enabled)
            {
                btnSave_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F4 && pvMode != "" && btnCancel.Enabled)
            {
                btnCancel_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5 && cmbDocNo.Text != "")
            {
                ใบเสรจToolStripMenuItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F6)
            {
                รายงานสรปToolStripMenuItem_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F12)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void rdOil_CheckedChanged(object sender, EventArgs e)
        {
            if (pvMode == "New")
            {
                //GenDoc
                if (rdOil.Checked)
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_00");
                else if (rdCarry.Checked)
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_01");
                else
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_02");
            }

            string lvTabIndex = tabPageAll.SelectedIndex.ToString();

            if (lvTabIndex == "0")
            {
                LoadDataDetail("1/1");
            }
            else if (lvTabIndex == "1")
            {
                LoadDataDetail("1/2");
            }
            else if (lvTabIndex == "2")
            {
                LoadDataDetail("2/1");
            }
            else if (lvTabIndex == "3")
            {
                LoadDataDetail("2/2");
            }
            else if (lvTabIndex == "4")
            {
                LoadDataDetail("3/1");
            }
            else if (lvTabIndex == "5")
            {
                LoadDataDetail("3/2");
            }
            else if (lvTabIndex == "6")
            {
                //pvMode = pvMode6;
            }

            txtQuota.Focus();
        }

        private void rdCarry_CheckedChanged(object sender, EventArgs e)
        {
            if (pvMode == "New")
            {
                //GenDoc
                if (rdOil.Checked)
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_00");
                else if (rdCarry.Checked)
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_01");
                else
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_02");
            }

            string lvTabIndex = tabPageAll.SelectedIndex.ToString();

            if (lvTabIndex == "0")
            {
                LoadDataDetail("1/1");
            }
            else if (lvTabIndex == "1")
            {
                LoadDataDetail("1/2");
            }
            else if (lvTabIndex == "2")
            {
                LoadDataDetail("2/1");
            }
            else if (lvTabIndex == "3")
            {
                LoadDataDetail("2/2");
            }
            else if (lvTabIndex == "4")
            {
                LoadDataDetail("3/1");
            }
            else if (lvTabIndex == "5")
            {
                LoadDataDetail("3/2");
            }
            else if (lvTabIndex == "6")
            {
                //pvMode = pvMode6;
            }

            txtQuota.Focus();
        }

        private void txtMeterS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownMeterS(txtAmount, txtMeterS, txtMeterE);
            }
        }

        private void txtMeterE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAmount.Focus();
            }
        }

        private void rdIssue_CheckedChanged(object sender, EventArgs e)
        {
            if (pvMode == "New")
            {
                //GenDoc
                if (rdOil.Checked)
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_00");
                else if (rdCarry.Checked)
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_01");
                else
                    cmbDocNo.Text = GsysSQL.fncGenDocNo("OilBill_02");
            }

            //LoadDataDetail();

            if (rdIssue.Checked)
                tabPageAll.SelectedTab = tabPage2;
            else
                tabPageAll.SelectedTab = tabPage1;

            if (rdIssue.Checked)
                txtDept.Focus();
            else
                txtQuota.Focus();

            if (rdIssue.Checked)
                txtType.Visible = true;
            else
                txtType.Visible = false;
        }

        private void txtCarNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCaneS.Focus();
        }

        private void txtDept_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (pvMode != "New" && pvMode != "Edit")
                {
                    MessageBox.Show("กรุณากดเพิ่มข้อมูลก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                txtName6.Text = GsysSQL.fncFindFactionName(txtDept.Text);

                if (txtName6.Text != "")
                {
                    txtObjective.Focus();
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลหน่วยงาน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDept.Text = "";
                    txtDept.Focus();
                }
            }
        }

        private void txtIssue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtObjective.Focus();
            }
        }

        private void txtObjective_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCarNumS6.Focus();
            }
        }

        private void txtSCar1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCarNumE6.Focus();
            }
        }

        private void txtSCar2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmpID.Focus();
            }
        }

        private void txtBudjet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAsset.Focus();
            }
        }

        private void txtAsset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAmount6.Focus();
            }
        }

        private void txtAmount2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownLitAmount(txtAmount2, txtlitter2, txtTotal2, txtMeterS2, txtMeterE2, txtFront2);
            }
        }

        private void txtFront2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMeterS6.Text = GsysSQL.fncFindMeterOil(txtFront6.Text);

                if (txtMeterS6.Text != "")
                {
                    int lvMeterS = Gstr.fncToInt(txtMeterS6.Text);
                    int lvLitter = Gstr.fncToInt(txtAmount6.Text);
                    int lvMeterE = lvMeterS + lvLitter;
                    txtMeterE6.Text = lvMeterE.ToString();
                    btnSave_Click(sender, e);
                }
                else
                {
                    txtMeterE6.Text = "";
                    txtMeterS6.Focus();
                }
            }
        }

        private void txtMeterS2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMeterS6.Text != "")
                {
                    int lvMeterS = Gstr.fncToInt(txtMeterS6.Text);
                    int lvLitter = Gstr.fncToInt(txtAmount6.Text);
                    int lvMeterE = lvMeterS + lvLitter;
                    txtMeterE6.Text = lvMeterE.ToString();
                    btnSave_Click(sender, e);
                }
                else
                {
                    txtMeterS6.Focus();
                }
            }
        }

        private void txtMeterE2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRemark6.Focus();
            }
        }

        private void tabPageAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lvTabIndex = tabPageAll.SelectedIndex.ToString();

            if (lvTabIndex == "0")
            {
                pvMode = pvMode0;
                LoadDataDetail("1/1");
            }
            else if (lvTabIndex == "1")
            {
                pvMode = pvMode1;
                LoadDataDetail("1/2");
            }
            else if (lvTabIndex == "2")
            {
                pvMode = pvMode2;
                LoadDataDetail("2/1");
            }
            else if (lvTabIndex == "3")
            {
                pvMode = pvMode3;
                LoadDataDetail("2/2");
            }
            else if (lvTabIndex == "4")
            {
                pvMode = pvMode4;
                LoadDataDetail("3/1");
            }
            else if (lvTabIndex == "5")
            {
                pvMode = pvMode5;
                LoadDataDetail("3/2");
            }
            else if (lvTabIndex == "6")
            {
                pvMode = pvMode6;
            }

            ShowBtn();

            
        }

        private void txtQuota1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQuota(txtQuota1, txtName1, txtCarNumS1);
            }
        }

        private void txtCarNumS1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCarNumS1.Text != "")
                    txtCarNumE1.Focus();
                else
                    txtCarNumS1.Focus();
            }
        }

        private void txtCarNumE1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCaneS1.Focus();
        }

        private void txtCaneS1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCaneNo1.Focus();
            }
        }

        private void txtCaneNo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownBill(txtCaneNo1);
            }
        }

        private void txtAmount1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownLitAmount(txtAmount1, txtlitter1, txtTotal1, txtMeterS1, txtMeterE1, txtFront1);
            }
        }

        private void txtMeterS1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownMeterS(txtAmount1, txtMeterS1, txtMeterE1);
            }
        }

        private void txtQuota2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQuota(txtQuota2, txtName2, txtCarNumS2);
            }
        }

        private void txtCarNumS2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCarNumS2.Text != "")
                    txtCarNumE2.Focus();
                else
                    txtCarNumS2.Focus();
            }
        }

        private void txtCarNumE2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCaneS2.Focus();
        }

        private void txtCaneS2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCaneNo2.Focus();
            }
        }

        private void txtCaneNo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownBill(txtCaneNo2);
            }
        }

        private void txtMeterS2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownMeterS(txtAmount2, txtMeterS2, txtMeterE2);
            }
        }

        private void txtQuota3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQuota(txtQuota3, txtName3, txtCarNumS3);
            }
        }

        private void txtCarNumS3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCarNumS3.Text != "")
                    txtCarNumE3.Focus();
                else
                    txtCarNumS3.Focus();
            }
        }

        private void txtCarNumE3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCaneS3.Focus();
        }

        private void txtCaneS3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCaneNo3.Focus();
            }
        }

        private void txtCaneNo3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownBill(txtCaneNo3);
            }
        }

        private void txtAmount3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownLitAmount(txtAmount3, txtlitter3, txtTotal3, txtMeterS3, txtMeterE3, txtFront3);
            }
        }

        private void txtMeterS3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownMeterS(txtAmount3, txtMeterS3, txtMeterE3);
            }
        }

        private void txtQuota4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQuota(txtQuota4, txtName4, txtCarNumS4);
            }
        }

        private void txtCarNumS4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCarNumS4.Text != "")
                    txtCarNumE4.Focus();
                else
                    txtCarNumS4.Focus();
            }
        }

        private void txtCarNumE4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCaneS4.Focus();
        }

        private void txtCaneS4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCaneNo4.Focus();
            }
        }

        private void txtCaneNo4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownBill(txtCaneNo4);
            }
        }

        private void txtAmount4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownLitAmount(txtAmount4, txtlitter4, txtTotal4, txtMeterS4, txtMeterE4, txtFront4);
            }
        }

        private void txtMeterS4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownMeterS(txtAmount4, txtMeterS4, txtMeterE4);
            }
        }

        private void txtQuota5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQuota(txtQuota5, txtName5, txtCarNumS5);
            }
        }

        private void txtCarNumS5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCarNumS5.Text != "")
                    txtCarNumE5.Focus();
                else
                    txtCarNumS5.Focus();
            }
        }

        private void txtCarNumE5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCaneS5.Focus();
        }

        private void txtCaneS5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCaneNo5.Focus();
            }
        }

        private void txtCaneNo5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownBill(txtCaneNo5);
            }
        }

        private void txtAmount5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownLitAmount(txtAmount5, txtlitter5, txtTotal5, txtMeterS5, txtMeterE5, txtFront5);
            }
        }

        private void txtMeterS5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownMeterS(txtAmount5, txtMeterS5, txtMeterE5);
            }
        }

        private void frmBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            //เช็คว่าบันทึกเอกสารหมดแล้วหรือยัง
            string lvAlert = "";
            if (pvMode0 != "") lvAlert += "หัวจ่าย 1/1" + Environment.NewLine;
            if (pvMode1 != "") lvAlert += "หัวจ่าย 1/2" + Environment.NewLine;
            if (pvMode2 != "") lvAlert += "หัวจ่าย 2/1" + Environment.NewLine;
            if (pvMode3 != "") lvAlert += "หัวจ่าย 2/2" + Environment.NewLine;
            if (pvMode4 != "") lvAlert += "หัวจ่าย 3/1" + Environment.NewLine;
            if (pvMode5 != "") lvAlert += "หัวจ่าย 3/2" + Environment.NewLine;

            if (lvAlert != "")
            {
                //ยืนยัน
                DialogResult dialogResultP = MessageBox.Show(lvAlert+ Environment.NewLine + "ยังไม่บันทึกข้อมูล ต้องการออกหรือไม่?", "Confirm?", MessageBoxButtons.YesNo);
                if (dialogResultP == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtOil1_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "Select C_Item, C_ItemName from Cane_OillItem ";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            txtOil1.Properties.Items.Clear();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string lvData = DT.Rows[i]["C_Item"].ToString() + " : " + DT.Rows[i]["C_ItemName"].ToString();
                txtOil1.Properties.Items.Add(lvData);
            }
        }

        private void txtOil2_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "Select C_Item, C_ItemName from Cane_OillItem ";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            txtOil2.Properties.Items.Clear();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string lvData = DT.Rows[i]["C_Item"].ToString() + " : " + DT.Rows[i]["C_ItemName"].ToString();
                txtOil2.Properties.Items.Add(lvData);
            }
        }

        private void txtOil3_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "Select C_Item, C_ItemName from Cane_OillItem ";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            txtOil3.Properties.Items.Clear();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string lvData = DT.Rows[i]["C_Item"].ToString() + " : " + DT.Rows[i]["C_ItemName"].ToString();
                txtOil3.Properties.Items.Add(lvData);
            }
        }

        private void txtOil4_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "Select C_Item, C_ItemName from Cane_OillItem ";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            txtOil4.Properties.Items.Clear();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string lvData = DT.Rows[i]["C_Item"].ToString() + " : " + DT.Rows[i]["C_ItemName"].ToString();
                txtOil4.Properties.Items.Add(lvData);
            }
        }

        private void txtOil5_QueryPopUp(object sender, CancelEventArgs e)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "Select C_Item, C_ItemName from Cane_OillItem ";
            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            txtOil5.Properties.Items.Clear();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string lvData = DT.Rows[i]["C_Item"].ToString() + " : " + DT.Rows[i]["C_ItemName"].ToString();
                txtOil5.Properties.Items.Add(lvData);
            }
        }

        private void btnBill1_Click(object sender, EventArgs e)
        {
            GVar.gvSCode = "";
            GVar.gvSName = "";
            GVar.gvQuota = "";
            GVar.gvCarNum = "";
            GVar.gvSampleNo = "";

            if (pvMode != "")
            {
                frmSearchBill frm = new frmSearchBill();
                frm.LoadData();
                frm.ShowDialog();

                if (GVar.gvSCode != "")
                {
                    txtCaneNo.Text = GVar.gvSCode;
                    txtQ.Text = GVar.gvSName;
                    txtQuota.Text = GVar.gvQuota;
                    txtName.Text = GsysSQL.fncFindQuotaName(GVar.gvQuota);

                    if (GVar.gvCarNum != "")
                    {
                        string[] lvArr = GVar.gvCarNum.Split('-');

                        if (lvArr.Count() > 1)
                        {
                            txtCarNumS.Text = lvArr[0];
                            txtCarNumE.Text = lvArr[1];
                        }
                        else
                        {
                            txtCarNumE.Text = lvArr[0];
                        }
                    }

                    txtCaneS.Text = GVar.gvSampleNo;
                }

                //สถานะบิลเรียกเก็บ
                string lvStatus = GsysSQL.fncFindCarryStatus(txtCaneNo.Text);
                if (lvStatus == "1")
                    rdCarry.Checked = true;
                else
                    rdOil.Checked = true;
            }

            //LoadDataDetail();
            txtAmount.Focus();
        }

        private void btnBill2_Click(object sender, EventArgs e)
        {
            GVar.gvSCode = "";
            GVar.gvSName = "";
            GVar.gvQuota = "";
            GVar.gvCarNum = "";
            GVar.gvSampleNo = "";

            if (pvMode != "")
            {
                frmSearchBill frm = new frmSearchBill();
                frm.LoadData();
                frm.ShowDialog();

                if (GVar.gvSCode != "")
                {
                    txtCaneNo1.Text = GVar.gvSCode;
                    txtQ1.Text = GVar.gvSName;
                    txtQuota1.Text = GVar.gvQuota;
                    txtName1.Text = GsysSQL.fncFindQuotaName(GVar.gvQuota);

                    if (GVar.gvCarNum != "")
                    {
                        string[] lvArr = GVar.gvCarNum.Split('-');

                        txtCarNumS1.Text = lvArr[0];
                        txtCarNumE1.Text = lvArr[1];
                    }

                    txtCaneS1.Text = GVar.gvSampleNo;
                }
            }

            //LoadDataDetail();
            txtAmount1.Focus();
        }

        private void btnBill3_Click(object sender, EventArgs e)
        {
            GVar.gvSCode = "";
            GVar.gvSName = "";
            GVar.gvQuota = "";
            GVar.gvCarNum = "";
            GVar.gvSampleNo = "";

            if (pvMode != "")
            {
                frmSearchBill frm = new frmSearchBill();
                frm.LoadData();
                frm.ShowDialog();

                if (GVar.gvSCode != "")
                {
                    txtCaneNo2.Text = GVar.gvSCode;
                    txtQ2.Text = GVar.gvSName;
                    txtQuota2.Text = GVar.gvQuota;
                    txtName2.Text = GsysSQL.fncFindQuotaName(GVar.gvQuota);

                    if (GVar.gvCarNum != "")
                    {
                        string[] lvArr = GVar.gvCarNum.Split('-');

                        txtCarNumS2.Text = lvArr[0];
                        txtCarNumE2.Text = lvArr[1];
                    }

                    txtCaneS2.Text = GVar.gvSampleNo;
                }
            }

            //LoadDataDetail();
            txtAmount2.Focus();
        }

        private void btnBill4_Click(object sender, EventArgs e)
        {
            GVar.gvSCode = "";
            GVar.gvSName = "";
            GVar.gvQuota = "";
            GVar.gvCarNum = "";
            GVar.gvSampleNo = "";

            if (pvMode != "")
            {
                frmSearchBill frm = new frmSearchBill();
                frm.LoadData();
                frm.ShowDialog();

                if (GVar.gvSCode != "")
                {
                    txtCaneNo3.Text = GVar.gvSCode;
                    txtQ3.Text = GVar.gvSName;
                    txtQuota3.Text = GVar.gvQuota;
                    txtName3.Text = GsysSQL.fncFindQuotaName(GVar.gvQuota);

                    if (GVar.gvCarNum != "")
                    {
                        string[] lvArr = GVar.gvCarNum.Split('-');

                        txtCarNumS3.Text = lvArr[0];
                        txtCarNumE3.Text = lvArr[1];
                    }

                    txtCaneS3.Text = GVar.gvSampleNo;
                }
            }

            //LoadDataDetail();
            txtAmount3.Focus();
        }

        private void btnBill5_Click(object sender, EventArgs e)
        {
            GVar.gvSCode = "";
            GVar.gvSName = "";
            GVar.gvQuota = "";
            GVar.gvCarNum = "";
            GVar.gvSampleNo = "";

            if (pvMode != "")
            {
                frmSearchBill frm = new frmSearchBill();
                frm.LoadData();
                frm.ShowDialog();

                if (GVar.gvSCode != "")
                {
                    txtCaneNo4.Text = GVar.gvSCode;
                    txtQ4.Text = GVar.gvSName;
                    txtQuota4.Text = GVar.gvQuota;
                    txtName4.Text = GsysSQL.fncFindQuotaName(GVar.gvQuota);

                    if (GVar.gvCarNum != "")
                    {
                        string[] lvArr = GVar.gvCarNum.Split('-');

                        txtCarNumS4.Text = lvArr[0];
                        txtCarNumE4.Text = lvArr[1];
                    }

                    txtCaneS4.Text = GVar.gvSampleNo;
                }
            }

            //LoadDataDetail();
            txtAmount4.Focus();
        }

        private void btnBill6_Click(object sender, EventArgs e)
        {
            GVar.gvSCode = "";
            GVar.gvSName = "";
            GVar.gvQuota = "";
            GVar.gvCarNum = "";
            GVar.gvSampleNo = "";

            if (pvMode != "")
            {
                frmSearchBill frm = new frmSearchBill();
                frm.LoadData();
                frm.ShowDialog();

                if (GVar.gvSCode != "")
                {
                    txtCaneNo5.Text = GVar.gvSCode;
                    txtQ5.Text = GVar.gvSName;
                    txtQuota5.Text = GVar.gvQuota;
                    txtName5.Text = GsysSQL.fncFindQuotaName(GVar.gvQuota);

                    if (GVar.gvCarNum != "")
                    {
                        string[] lvArr = GVar.gvCarNum.Split('-');

                        txtCarNumS5.Text = lvArr[0];
                        txtCarNumE5.Text = lvArr[1];
                    }

                    txtCaneS5.Text = GVar.gvSampleNo;
                }
            }

            //LoadDataDetail();
            txtAmount5.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string lvItem = Gstr.fncGetDataCode(txtOil1.Text, ":");
            string lvOilPrice = txtlitter1.Text;

            if (lvOilPrice == "")
            {
                MessageBox.Show("กรุณาระบุราคาต่อลิตร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlitter.Focus();
                return;
            }

            //ยืนยัน
            DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }


            //Update ราคา
            string lvSQL = "Update Cane_OillItem set C_ItemPrice = '" + lvOilPrice + "' Where C_Item = '" + lvItem + "' ";
            GsysSQL.fncExecuteQueryData(lvSQL);

            string lvTXT = "แก้ไขราคาน้ำมัน เป็น " + lvOilPrice + " บาท/ลิตร";
            GsysSQL.fncKeepLogData("ป้อมน้ำมัน", "บิลน้ำมัน", lvTXT);

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditPrice2_Click(object sender, EventArgs e)
        {
            string lvItem = Gstr.fncGetDataCode(txtOil2.Text, ":");
            string lvOilPrice = txtlitter2.Text;

            if (lvOilPrice == "")
            {
                MessageBox.Show("กรุณาระบุราคาต่อลิตร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlitter.Focus();
                return;
            }

            //ยืนยัน
            DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }


            //Update ราคา
            string lvSQL = "Update Cane_OillItem set C_ItemPrice = '" + lvOilPrice + "' Where C_Item = '" + lvItem + "' ";
            GsysSQL.fncExecuteQueryData(lvSQL);

            string lvTXT = "แก้ไขราคาน้ำมัน เป็น " + lvOilPrice + " บาท/ลิตร";
            GsysSQL.fncKeepLogData("ป้อมน้ำมัน", "บิลน้ำมัน", lvTXT);

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditPrice3_Click(object sender, EventArgs e)
        {
            string lvItem = Gstr.fncGetDataCode(txtOil3.Text, ":");
            string lvOilPrice = txtlitter3.Text;

            if (lvOilPrice == "")
            {
                MessageBox.Show("กรุณาระบุราคาต่อลิตร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlitter.Focus();
                return;
            }

            //ยืนยัน
            DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }


            //Update ราคา
            string lvSQL = "Update Cane_OillItem set C_ItemPrice = '" + lvOilPrice + "' Where C_Item = '" + lvItem + "' ";
            GsysSQL.fncExecuteQueryData(lvSQL);

            string lvTXT = "แก้ไขราคาน้ำมัน เป็น " + lvOilPrice + " บาท/ลิตร";
            GsysSQL.fncKeepLogData("ป้อมน้ำมัน", "บิลน้ำมัน", lvTXT);

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditPrice4_Click(object sender, EventArgs e)
        {
            string lvItem = Gstr.fncGetDataCode(txtOil4.Text, ":");
            string lvOilPrice = txtlitter4.Text;

            if (lvOilPrice == "")
            {
                MessageBox.Show("กรุณาระบุราคาต่อลิตร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlitter.Focus();
                return;
            }

            //ยืนยัน
            DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }


            //Update ราคา
            string lvSQL = "Update Cane_OillItem set C_ItemPrice = '" + lvOilPrice + "' Where C_Item = '" + lvItem + "' ";
            GsysSQL.fncExecuteQueryData(lvSQL);

            string lvTXT = "แก้ไขราคาน้ำมัน เป็น " + lvOilPrice + " บาท/ลิตร";
            GsysSQL.fncKeepLogData("ป้อมน้ำมัน", "บิลน้ำมัน", lvTXT);

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditPrice5_Click(object sender, EventArgs e)
        {
            string lvItem = Gstr.fncGetDataCode(txtOil5.Text, ":");
            string lvOilPrice = txtlitter5.Text;

            if (lvOilPrice == "")
            {
                MessageBox.Show("กรุณาระบุราคาต่อลิตร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlitter.Focus();
                return;
            }

            //ยืนยัน
            DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            //Update ราคา
            string lvSQL = "Update Cane_OillItem set C_ItemPrice = '" + lvOilPrice + "' Where C_Item = '" + lvItem + "' ";
            GsysSQL.fncExecuteQueryData(lvSQL);

            string lvTXT = "แก้ไขราคาน้ำมัน เป็น " + lvOilPrice + " บาท/ลิตร";
            GsysSQL.fncKeepLogData("ป้อมน้ำมัน", "บิลน้ำมัน", lvTXT);

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditPrice6_Click(object sender, EventArgs e)
        {
            string lvItem = Gstr.fncGetDataCode(txtOil6.Text, ":");
            string lvOilPrice = txtLitter6.Text;

            if (lvOilPrice == "")
            {
                MessageBox.Show("กรุณาระบุราคาต่อลิตร", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtlitter.Focus();
                return;
            }

            //ยืนยัน
            DialogResult dialogResult = MessageBox.Show("ยืนยันการทำรายการ", "Confirm?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }


            //Update ราคา
            string lvSQL = "Update Cane_OillItem set C_ItemPrice = '" + lvOilPrice + "' Where C_Item = '" + lvItem + "' ";
            GsysSQL.fncExecuteQueryData(lvSQL);

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQueue(txtQ);
            }
        }

        private void txtQ1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQueue(txtQ1);
            }
        }

        private void txtQ2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQueue(txtQ2);
            }
        }

        private void txtQ3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQueue(txtQ3);
            }
        }

        private void txtQ4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQueue(txtQ4);
            }
        }

        private void txtQ5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownQueue(txtQ5);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tabPageAll.SelectedTab = tabPage1;

            string lvStatus = GsysSQL.fncFindCarryStatus(txtCaneNo.Text);
            if (lvStatus == "1" && lvStatus != "")
                rdCarry.Checked = true;
            else
                rdOil.Checked = true;
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            tabPageAll.SelectedTab = tabPage3;

            string lvStatus = GsysSQL.fncFindCarryStatus(txtCaneNo1.Text);
            if (lvStatus == "1" && lvStatus != "")
                rdCarry.Checked = true;
            else
                rdOil.Checked = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            tabPageAll.SelectedTab = tabPage4;

            string lvStatus = GsysSQL.fncFindCarryStatus(txtCaneNo2.Text);
            if (lvStatus == "1" && lvStatus != "")
                rdCarry.Checked = true;
            else
                rdOil.Checked = true;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            tabPageAll.SelectedTab = tabPage5;

            string lvStatus = GsysSQL.fncFindCarryStatus(txtCaneNo3.Text);
            if (lvStatus == "1" && lvStatus != "")
                rdCarry.Checked = true;
            else
                rdOil.Checked = true;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            tabPageAll.SelectedTab = tabPage6;

            string lvStatus = GsysSQL.fncFindCarryStatus(txtCaneNo4.Text);
            if (lvStatus == "1" && lvStatus != "")
                rdCarry.Checked = true;
            else
                rdOil.Checked = true;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            tabPageAll.SelectedTab = tabPage7;

            string lvStatus = GsysSQL.fncFindCarryStatus(txtCaneNo5.Text);
            if (lvStatus == "1" && lvStatus != "")
                rdCarry.Checked = true;
            else
                rdOil.Checked = true;
        }

        //KeyDown Event
        private void FncKeyDownQuota(TextEdit TQouta, TextEdit TName, TextEdit TCarNumS)
        {
            if (btnAdd.Enabled)
            {
                MessageBox.Show("กรุณากดเพิ่มข้อมูลก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //TQouta.Text = "";
                return;
            }

            TName.Text = GsysSQL.fncFindQuotaName(TQouta.Text);

            if (TName.Text == "")
            {
                MessageBox.Show("ไม่พบข้อมูล โควต้า กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TQouta.Text = "";
                TQouta.Focus();
                return;
            }

            if (txtName.Text != "")
            {
                TCarNumS.Focus();
            }
            else
            {
                TName.Focus();
            }
        }

        private void FncKeyDownQueue(TextEdit TQueue)
        {
            if (TQueue.Text != "" && pvMode == "New")
            {
                LoadWeightData(TQueue.Text, "");
            }
            else
            {
                MessageBox.Show("กรุณากดเพิ่มข้อมูลก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TQueue.Focus();
            }
        }

        private void FncKeyDownBill(TextEdit TCaneNo)
        {
            string lvBillNo = TCaneNo.Text;
            if (lvBillNo != "" && (pvMode == "New" || pvMode == "Edit"))
            {
                LoadWeightData("", lvBillNo);
            }
            else
            {
                MessageBox.Show("กรุณากดเพิ่มข้อมูลก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TCaneNo.Focus();
            }
        }

        private void FncKeyDownLitAmount(TextEdit TAmount, TextEdit Tlitter, TextEdit TTotal, TextEdit TMeterS, TextEdit TMeterE, TextEdit TFront)
        {
            double lvAmount = Gstr.fncToDouble(TAmount.Text);
            double lvPrice = Gstr.fncToDouble(Tlitter.Text);
            double lvTotal = lvAmount * lvPrice;

            TTotal.Text = lvTotal.ToString("#,##0.00");

            if (pvMode != "Edit")
                TMeterS.Text = GsysSQL.fncFindMeterOil(TFront.Text);
            if (TMeterS.Text != "")
            {
                if (pvMode == "Edit")
                {
                    int lvMeterS = Gstr.fncToInt(TMeterS.Text);
                    int lvMeterE = Gstr.fncToInt(TMeterE.Text);
                    int lvLitter = lvMeterE - lvMeterS;

                    if (lvLitter != lvAmount)
                    {
                        MessageBox.Show("จำนวนลิตร กับ เลขมิเตอร์ ไม่ตรงกัน กรุณาตรวจสอบใหม่อีกครั้ง !!", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Tlitter.Focus();
                        return;
                    }
                }
                else
                {
                    int lvMeterS = Gstr.fncToInt(TMeterS.Text);
                    int lvLitter = Gstr.fncToInt(TAmount.Text);
                    int lvMeterE = lvMeterS + lvLitter;
                    TMeterE.Text = lvMeterE.ToString();
                    btnSave.PerformClick();
                }
            }
            else
            {
                TMeterE.Text = "";
                TMeterS.Focus();
            }
        }

        private void FncKeyDownLitAmountNoSave(TextEdit TAmount, TextEdit Tlitter, TextEdit TTotal, TextEdit TMeterS, TextEdit TMeterE, TextEdit TFront)
        {
            double lvAmount = Gstr.fncToDouble(TAmount.Text);
            double lvPrice = Gstr.fncToDouble(Tlitter.Text);
            double lvTotal = lvAmount * lvPrice;

            TTotal.Text = lvTotal.ToString("#,##0.00");
        }

        private void FncKeyDownMeterS(TextEdit TAmount, TextEdit TMeterS, TextEdit TMeterE)
        {
            if (TMeterS.Text != "")
            {
                int lvMeterS = Gstr.fncToInt(TMeterS.Text);
                int lvLitter = Gstr.fncToInt(TAmount.Text);
                int lvMeterE = lvMeterS + lvLitter;
                TMeterE.Text = lvMeterE.ToString();
                btnSave.PerformClick();
            }
            else
            {
                TMeterS.Focus();
            }
        }

        private void txtAmount6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FncKeyDownLitAmount(txtAmount6, txtLitter6, txtTotal6, txtMeterS6, txtMeterE6, txtFront6);

                txtFront6.Focus();
            }
        }

        private void txtFront6_SelectedIndexChanged(object sender, EventArgs e)
        {
            FncKeyDownLitAmount(txtAmount6, txtLitter6, txtTotal6, txtMeterS6, txtMeterE6, txtFront6);
        }

        private void txtEmpID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string lvName = GsysSQL.fncFindEmpFullName(txtEmpID.Text);
                if (lvName != "")
                {
                    txtEmpName.Text = lvName;
                    txtBudjet.Focus();
                }
                else
                {
                    MessageBox.Show("ไม่พบรหัสพนักงาน กรุณาตรวจสอบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmpID.Text = "";
                    txtEmpID.Focus();
                }
            }
        }

        private void txtEmpName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBudjet.Focus();
            }
        }

        private void txtDocS_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
        private void LoadData(string lvDocNo)
        {
            string lvDate2 = Gstr.fncChangeTDate(lvDocNo);
            string lvResult = GsysSQL.fncGetLastDocNoX(lvDate2);


        }

        private void txtDate_EditValueChanged(object sender, EventArgs e)
        {
           

        }

        private void btnPast_Click(object sender, EventArgs e)
        {
            string lvDate2 = Gstr.fncChangeTDate(txtDate.Text);
            long lvstm = Convert.ToInt64(GsysSQL.fncGetLastDocNoX(lvDate2));

            if (pvMode == "New")
            {
                string lvDoc = (lvstm + 1).ToString();
                cmbDocNo.Text = "C-" + lvDoc;
            }
        }
    }
}
