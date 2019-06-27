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
    public partial class frmCar : Form
    {
        public frmCar()
        {
            InitializeComponent();
        }

        private void sp1_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            int lvRowIndex = e.Row;
            int lvColIndex = e.Column;

            if (lvColIndex == 0 || lvColIndex == 1)
            {
                GVar.gvSCode = sp1.ActiveSheet.Cells[lvRowIndex, 1].Text;
                GVar.gvSName = sp1.ActiveSheet.Cells[lvRowIndex, 0].Text;
            }
            else
            {
                GVar.gvSCode = sp1.ActiveSheet.Cells[lvRowIndex, 2].Text;
                GVar.gvSName = sp1.ActiveSheet.Cells[lvRowIndex, 0].Text;
            }

            this.Close();
        }

        public void LoadData(string lvQuota)
        {
            //Get Data
            DataTable DT = new DataTable();
            string lvSQL = "Select * from Cane_CarOwner Where Car_Quota = '"+ lvQuota +"' ";        
            lvSQL += "Order by Car_Number";

            DT = GsysSQL.fncGetQueryData(lvSQL, DT);

            int lvNumRow = DT.Rows.Count;
            sp1.ActiveSheet.RowCount = lvNumRow;
            //HD
            for (int i = 0; i < lvNumRow; i++)
            {
                string lvName = DT.Rows[i]["Car_Prefix"].ToString() + " " + DT.Rows[i]["Car_FirstName"].ToString() + " " + DT.Rows[i]["Car_LastName"].ToString();
                sp1.ActiveSheet.Cells[i, 0].Text = lvName;
                sp1.ActiveSheet.Cells[i, 1].Text = DT.Rows[i]["Car_Number"].ToString();
                sp1.ActiveSheet.Cells[i, 2].Text = DT.Rows[i]["Car_Truck"].ToString();
            }
            
        }
    }
}
