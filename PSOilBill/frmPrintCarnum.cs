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
    public partial class frmPrintCarnum : Form
    {
        public frmPrintCarnum()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lvSQL = "DELETE FROM SysTemp";
            string lvResult = GsysSQL.fncExecuteQueryData(lvSQL);
            
            DataTable DT = new DataTable();
            lvSQL = "SELECT * FROM MiniCane_OilCar WHERE 1=1 ";

            if(txtCarnum.Text != "")
            {
                string lvCarnum = txtCarnum.Text;
                lvSQL += "And M_CarNum = '" + lvCarnum + "' ";
            }

            if(txtDept.Text != "")
            {
                string lvDept = txtDept.Text;
                lvSQL += "And M_SecID = '" + lvDept + "' ";
            }

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;
            for (int i = 0; i < lvNumRow; i++)
            {
                string lvBudjet = DT.Rows[i]["M_Budjet"].ToString();
                string lvName = DT.Rows[i]["M_Name"].ToString();
                string lvAsset = DT.Rows[i]["M_Asset"].ToString();
                string lvCarName = DT.Rows[i]["M_CarName"].ToString();
                string lvRealNum = DT.Rows[i]["M_CarNum"].ToString();
                string lvNum = FncChangeThaiToEngCar(DT.Rows[i]["M_CarNum"].ToString());
                string lvShowNum = DT.Rows[i]["M_CarNum2"].ToString();
                string lvSecID = DT.Rows[i]["M_SecID"].ToString();
                string lvSecName = DT.Rows[i]["M_SecName"].ToString();
                string lvSecTotal = lvSecID + "-" + lvSecName;

                if (lvRealNum != "")
                {
                    lvSQL = "INSERT INTO SysTemp (S_Fieid1, S_Fieid2, S_Fieid3, S_Fieid4, S_Fieid5, S_Fieid6, S_Fieid7, S_Fieid8, S_Fieid9) VALUES ('" + lvBudjet + "', '" + lvName + "', '" + lvAsset + "', '" + lvCarName + "', '" + lvNum + "', '" + lvSecID + "', '" + lvSecTotal + "', '" + lvRealNum + "', '" + lvShowNum + "')";
                    lvResult = GsysSQL.fncExecuteQueryData(lvSQL);
                }
            }

            if(lvResult == "Success")
            {
                MessageBox.Show("สำเร็จ","แจ้งเตือน!", MessageBoxButtons.OK);
                rptCarnum Report = new rptCarnum();
                Report.CreateDocument();

                documentViewer1.DocumentSource = Report;
            }
            else
            {
                MessageBox.Show("ไม่สำเร็จ", "แจ้งเตือน!", MessageBoxButtons.OK);
                return;
            }
        }

        private string FncChangeThaiToEngCar(string lvTXT)
        {
            string lvReturn = "";

            //เปลี่ยนภาษาไทยเป็น Eng
            //แยกส่วน
            string[] lvArr = lvTXT.ToUpper().Split('.');
            string lvPCar = GsysSQL.fncFindShotEngCar(lvArr[0]);

            if (lvPCar != "")
            {
                //เช็คช่วงหลังว่ามีภาษาไทยอีกไหม
                int lvCount1 = lvArr[1].Length;
                string lvTXTChange = "";
                string lvTXTOLD = "";
                for (int i = 0; i < lvCount1; i++)
                {
                    string lvData = lvArr[1].Substring(i, 1).ToString();
                    string lvChkData = GsysSQL.fncFindShotEngCar(lvData);

                    if (lvChkData != "")
                    {
                        if (lvTXTChange != "") lvTXTChange += ",";
                        lvTXTChange += lvChkData;
                    }
                    else
                    {
                        if (lvTXTChange != "")
                        {
                            if (i > 1 && lvArr[1].Substring(i - 1, 1).ToString().All(char.IsLetter))
                                lvTXTChange += ",";
                        }

                        lvTXTChange += lvData;
                    }
                }

                //ถ้ามีข้อมูล
                lvReturn = lvPCar + "." + lvTXTChange;
            }
            else
            {
                //ถ้าไม่มี
                if (lvArr.Count() > 1)
                {
                    int lvCount0 = lvArr[0].Length;
                    string lvTXTChange = "";
                    //แยกส่วนแล้วแปลงทีละตัว
                    for (int i = 0; i < lvCount0; i++)
                    {
                        string lvData = lvArr[0].Substring(i, 1).ToString();
                        string lvChkData = GsysSQL.fncFindShotEngCar(lvData);

                        if (lvChkData != "")
                        {
                            if (lvTXTChange != "") lvTXTChange += ",";
                            lvTXTChange += lvChkData;
                        }
                    }

                    if (lvTXTChange == "") lvTXTChange = lvArr[0];

                    lvReturn = lvTXTChange + "." + lvArr[1];
                }
                else
                {
                    lvReturn = lvArr[0];
                }
            }
            return lvReturn;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCarnum.Text = "";
            txtDept.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lvSQL = "DELETE FROM SysTemp";
            string lvResult = GsysSQL.fncExecuteQueryData(lvSQL);

            DataTable DT = new DataTable();
            lvSQL = "SELECT * FROM MiniCane_OilCar WHERE 1=1 ";

            if (txtCarnum.Text != "")
            {
                string lvCarnum = txtCarnum.Text;
                lvSQL += "And M_CarNum = '" + lvCarnum + "' ";
            }

            if (txtDept.Text != "")
            {
                string lvDept = txtDept.Text;
                lvSQL += "And M_SecID = '" + lvDept + "' ";
            }

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;
            for (int i = 0; i < lvNumRow; i++)
            {
                string lvBudjet = DT.Rows[i]["M_Budjet"].ToString();
                string lvName = DT.Rows[i]["M_Name"].ToString();
                string lvAsset = DT.Rows[i]["M_Asset"].ToString();
                string lvCarName = DT.Rows[i]["M_CarName"].ToString();
                string lvRealNum = DT.Rows[i]["M_CarNum"].ToString();
                string lvNum = FncChangeThaiToEngCar(DT.Rows[i]["M_CarNum"].ToString());
                string lvShowNum = DT.Rows[i]["M_CarNum2"].ToString();
                string lvSecID = DT.Rows[i]["M_SecID"].ToString();
                string lvSecName = DT.Rows[i]["M_SecName"].ToString();
                string lvSecTotal = lvSecID + "-" + lvSecName;

                if (lvRealNum != "")
                {
                    lvSQL = "INSERT INTO SysTemp (S_Fieid1, S_Fieid2, S_Fieid3, S_Fieid4, S_Fieid5, S_Fieid6, S_Fieid7, S_Fieid8, S_Fieid9) VALUES ('" + lvBudjet + "', '" + lvName + "', '" + lvAsset + "', '" + lvCarName + "', '" + lvNum + "', '" + lvSecID + "', '" + lvSecTotal + "', '" + lvRealNum + "', '" + lvShowNum + "')";
                    lvResult = GsysSQL.fncExecuteQueryData(lvSQL);
                }
            }

            if (lvResult == "Success")
            {
                MessageBox.Show("สำเร็จ", "แจ้งเตือน!", MessageBoxButtons.OK);
                CarPrint Report = new CarPrint();
                Report.CreateDocument();

                documentViewer1.DocumentSource = Report;
            }
            else
            {
                MessageBox.Show("ไม่สำเร็จ", "แจ้งเตือน!", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
