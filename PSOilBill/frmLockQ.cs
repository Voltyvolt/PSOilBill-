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
    public partial class frmLockQ : Form
    {
        public frmLockQ()
        {
            InitializeComponent();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            GVar.gvLockE = txtLockE.Text;
            txtLockE.Text = "";

            MessageBox.Show("ล็อคคิวที่ 0 ถึง '" + GVar.gvLockE + "' เรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GVar.gvLockS = "";
            GVar.gvLockE = "";

            MessageBox.Show("ล้างคิวเรียบร้อยแล้ว", "แจ้งเตือน", MessageBoxButtons.OK);
        }

        private void frmLockQ_Load(object sender, EventArgs e)
        {
            txtLockE.Focus();
        }

        private void txtLockE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLock.PerformClick();
            }
        }
    }
}
