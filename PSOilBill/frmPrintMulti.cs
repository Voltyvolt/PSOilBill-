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
    public partial class frmPrintMulti : Form
    {
        public frmPrintMulti()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtDocS.Text == "")
            {
                MessageBox.Show("กรุณาระบุเลขที่เอกสาร ให้ครบถ้วน","แจ้งเตือน",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtDocS.Focus();
                return;
            }
            else if (txtDocE.Text == "")
            {
                MessageBox.Show("กรุณาระบุเลขที่เอกสาร ให้ครบถ้วน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocE.Focus();
                return;
            }

            GVar.gvDocS = txtDocS.Text;
            GVar.gvDocE = txtDocE.Text;
            this.Close();
        }

        private void frmPrintMulti_Load(object sender, EventArgs e)
        {
            GVar.gvDocS = "";
            GVar.gvDocE = "";
        }

        private void txtDocE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnPrint_Click(sender, e);
            }
        }

        private void txtDocS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDocE.Focus();
            }
        }
    }
}
