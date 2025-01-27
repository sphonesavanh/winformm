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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
            connectionDB_Checking();
            getCustData();
        }

        string strConnect = @"Data Source=UKIYOACE\MSSQLSERVER01;Initial Catalog=miniDB_4COM;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        private void getCustData()
        {
            string sql = "select * from tbCustomers";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvShow.DataSource = dt;
            dgvShow.Columns[0].HeaderText = "ລະຫັດລູກຄ້າ";
            dgvShow.Columns[1].HeaderText = "ຊື່ລູກຄ້າ"; 
            dgvShow.Columns[2].HeaderText = "ທີ່ຢູ່ລູກຄ້າ";
            dgvShow.Columns[3].HeaderText = "ເບີໂທລະສັບ";
        }

        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbCustomers values('" +
                txtCustId.Text + "', N'" + txtCustName.Text + "', '" + txtCustAddr.Text + "', '"
                + txtCustTel.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            getCustData();
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvShow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShow.CurrentRow.Index;
            txtCustId.Text = dgvShow.Rows[cindex].Cells[0].Value.ToString();
            txtCustName.Text = dgvShow.Rows[cindex].Cells[1].Value.ToString();
            txtCustAddr.Text = dgvShow.Rows[cindex].Cells[2].Value.ToString();
            txtCustTel.Text = dgvShow.Rows[cindex].Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update tbCustomers set cust_Name = N'" +
                txtCustName.Text + "', cust_Address = '" + txtCustAddr.Text + "' , telephone = '" + txtCustTel.Text + "' where cust_id = '" + txtCustId.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            getCustData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ່?", "Question",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from tbCustomers where cust_Id= '" + txtCustId.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                getCustData();
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
