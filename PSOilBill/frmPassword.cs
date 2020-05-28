using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PSOilBill
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string lvPSCheck = txtPswd.Text;
            frmBill frm = new frmBill();

            if(lvPSCheck == "sugarPS88")
            {
                GVar.gvPass = "sugarPS88";
                this.DialogResult = DialogResult.OK;

                MessageBox.Show("สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK);
                this.Hide();
            }
            else
            {
                MessageBox.Show("รหัสไม่ถูกต้อง โปรดลองใหม่อีกครั้ง", "แจ้งเตือน", MessageBoxButtons.OK);
                txtPswd.Focus();
                return;
            }
        }
    }
}
