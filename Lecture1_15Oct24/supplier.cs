using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Lecture1_15Oct24
{
    public partial class supplier : Form
    {
        public supplier()
        {
            InitializeComponent();
        }
        string pid = "";
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strConn = @"Data Source=UKIYOACE\MSSQLSERVER01;Initial Catalog=miniDB_4COM;Integrated Security=True;";
        private void showSupData()
        {
            sqlCmd = new SqlCommand("select * from tbSupplier", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDr);
            dgvShow.DataSource = dt;
            //dgvShowdata.Columns[0].HeaderText = "ລຳດັບ";
            //dgvShowdata.Columns[0].Visible = true;
            dgvShow.Columns[0].HeaderText = "ລະຫັດຜູ້ສະໜອງ";
            dgvShow.Columns[1].HeaderText = "ຊື່ບໍລິສັດ";
            dgvShow.Columns[2].HeaderText = "ຊື່ຜູ້ຕິດຕໍ່";
            dgvShow.Columns[3].HeaderText = "ທີ່ຢູ່";
            dgvShow.Columns[4].HeaderText = "ເບີໂທ";
            dgvShow.Columns[5].HeaderText = "ອີເມວ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlstr = "insert into tbSupplier(supplier_id, supplier_name, contract_namee, supplier_tel, supplier_addr, supplier_email) " +
                            "values(@supplier_id, @supplier_name, @contract_namee, @supplier_tel, @supplier_addr, @supplier_email)";

            sqlCmd = new SqlCommand(sqlstr, sqlCon);
            sqlCmd.Parameters.AddWithValue("@supplier_id", txtSupID.Text);
            sqlCmd.Parameters.AddWithValue("@supplier_name", txtSupName.Text);
            sqlCmd.Parameters.AddWithValue("@contract_namee", txtContr.Text);
            sqlCmd.Parameters.AddWithValue("@supplier_tel", txtTel.Text);
            sqlCmd.Parameters.AddWithValue("@supplier_addr", txtAddress.Text);
            sqlCmd.Parameters.AddWithValue("@supplier_email", txtEmail.Text);

            sqlCmd.ExecuteNonQuery();
            showSupData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlstr = "Update tbSupplier set supplier_name=@supplier_name,contract_namee=@contract_namee,supplier_tel=@supplier_tel,supplier_addr=@supplier_addr,supplier_email=@supplier_email where supplier_id='" + txtSupID.Text + "'";
            sqlCmd = new SqlCommand(sqlstr, sqlCon);
            sqlCmd.Parameters.AddWithValue("@supplier_name", txtSupName.Text);
            sqlCmd.Parameters.AddWithValue("@contract_namee", txtContr.Text);
            sqlCmd.Parameters.AddWithValue("@supplier_tel", txtTel.Text);
            sqlCmd.Parameters.AddWithValue("@supplier_addr", txtAddress.Text);
            sqlCmd.Parameters.AddWithValue("@supplier_email", txtEmail.Text);
            sqlCmd.ExecuteNonQuery();
            showSupData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ຫຼືບໍ່?", "Question",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlstr = "Delete from tbSupplier where supplier_id='" + txtSupID.Text + "'";
                sqlCmd = new SqlCommand(sqlstr, sqlCon);
                sqlCmd.ExecuteNonQuery();
                showSupData();
            }
        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvShow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShow.CurrentRow.Index;
            pid = dgvShow.Rows[cindex].Cells[0].Value.ToString();
            txtSupID.Text = dgvShow.Rows[cindex].Cells[0].Value.ToString();
            txtSupName.Text = dgvShow.Rows[cindex].Cells[1].Value.ToString();
            txtContr.Text = dgvShow.Rows[cindex].Cells[2].Value.ToString();
            txtTel.Text = dgvShow.Rows[cindex].Cells[4].Value.ToString();
            txtAddress.Text = dgvShow.Rows[cindex].Cells[3].Value.ToString();
            txtEmail.Text = dgvShow.Rows[cindex].Cells[5].Value.ToString();
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            sqlCmd = new SqlCommand("select * from tbSupplier", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dtPT = new DataTable();
            dtPT.Load(sqlDr);
            showSupData();
        }
    }
}
