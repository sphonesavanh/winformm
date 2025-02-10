using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture1_15Oct24
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ເພToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ອອກຈາກລະບບToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ຂມນຜສະໜອງToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier frm = new supplier();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void ຂມນລກຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void ຂມນສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void ລາຍງານສນຄາໃນຮານToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptProductViewer frm = new frmrptProductViewer();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ຂມນປະເພດສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductType frm = new frmProductType();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }

        private void ສງຊສນຄາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
        }
    }
}
