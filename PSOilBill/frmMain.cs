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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void บลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBill frm = new frmBill();
            frm.MdiParent = this;
            frm.Show();
        }

        private void รายงานสรปToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchPrint frm = new frmSearchPrint();
            frm.ShowDialog();
        }
    }
}
