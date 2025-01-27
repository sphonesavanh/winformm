using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture1_15Oct24
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string strConnect = @"Data Source=UKIYOACE\MSSQLSERVER01;Initial Catalog=miniDB_4COM;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pwd = txtPwd.Text;
            string sql = "select * from tbUsers where userName = '"+ username +"' and password_code = '"+ pwd +"'";
            conn = new SqlConnection(strConnect);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            conn.Close();

            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("Welcome");
                frmMainMenu frm = new frmMainMenu();
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
