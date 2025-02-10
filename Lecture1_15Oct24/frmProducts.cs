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
using System.IO;

namespace Lecture1_15Oct24
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        string pid = "";
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strConn = @"Data Source=UKIYOACE\MSSQLSERVER01;Initial Catalog=miniDB_4COM;Integrated Security=True;";
        private void frmProducts_Load(object sender, EventArgs e)
        {
            
        }
        private void showData()
        {
            sqlCmd = new SqlCommand("select * from tbProducts", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDr);
            dgvShowdata.DataSource = dt;
            dgvShowdata.Columns[0].HeaderText = "ລະຫັດສິນຄ້າ";
            dgvShowdata.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            dgvShowdata.Columns[2].HeaderText = "ຈຳນວນ";
            dgvShowdata.Columns[3].HeaderText = "ລາຄາຕໍ່ໜ່ວຍ";
            dgvShowdata.Columns[4].HeaderText = "ຫົວໜ່ວຍ";
            dgvShowdata.Columns[5].HeaderText = "ປະເພດສິນຄ້າ";
            dgvShowdata.Columns[6].HeaderText = "ເກນສິນຄ້າເຫຼືອ";
            dgvShowdata.Columns[7].HeaderText = "ຮູບ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvShowdata_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChoose_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opFdl = new OpenFileDialog();
            opFdl.Filter = "Image Files (*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";

            if (opFdl.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opFdl.FileName);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (cboType.SelectedValue == null || string.IsNullOrEmpty(cboType.SelectedValue.ToString()))
            {
                MessageBox.Show("Please select a product type.");
                return;
            }

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] btimg = ms.GetBuffer();

            string sqlstr = "insert into tbProducts(pro_id, pro_name, qty, price, unit, ptType_ID, instock, pro_img) " +
                            "values(@pro_id, @pro_name, @qty, @price, @unit, @ptType_ID, @instock, @pro_img)";

            sqlCmd = new SqlCommand(sqlstr, sqlCon);
            sqlCmd.Parameters.AddWithValue("@pro_id", txtProNo.Text);
            sqlCmd.Parameters.AddWithValue("@pro_name", txtProName.Text);
            sqlCmd.Parameters.AddWithValue("@qty", txtQty.Text);
            sqlCmd.Parameters.AddWithValue("@price", txtPrice.Text);
            sqlCmd.Parameters.AddWithValue("@unit", txtUnit.Text);
            sqlCmd.Parameters.AddWithValue("@ptType_ID", cboType.SelectedValue);  // Pass SelectedValue
            sqlCmd.Parameters.AddWithValue("@instock", txtInstock.Text);
            sqlCmd.Parameters.AddWithValue("@pro_img", btimg);

            sqlCmd.ExecuteNonQuery();
            showData();
        }


        private void frmProducts_Load_1(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            sqlCmd = new SqlCommand("select * from tbPtProductType", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dtPT = new DataTable();
            dtPT.Load(sqlDr);
            cboType.DataSource = dtPT;
            cboType.DisplayMember = "ptType_name";
            cboType.ValueMember = "ptType_ID";
            showData();
        }

        private void dgvShowdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvShowdata_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShowdata.CurrentRow.Index;
            pid = dgvShowdata.Rows[cindex].Cells[0].Value.ToString();
            txtProNo.Text = dgvShowdata.Rows[cindex].Cells[0].Value.ToString();
            txtProName.Text = dgvShowdata.Rows[cindex].Cells[1].Value.ToString();
            txtQty.Text = dgvShowdata.Rows[cindex].Cells[2].Value.ToString();
            txtPrice.Text = dgvShowdata.Rows[cindex].Cells[3].Value.ToString();
            txtUnit.Text = dgvShowdata.Rows[cindex].Cells[4].Value.ToString();
            txtInstock.Text = dgvShowdata.Rows[cindex].Cells[6].Value.ToString();
            var img = (byte[])dgvShowdata.Rows[cindex].Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            cboType.SelectedValue = dgvShowdata.Rows[cindex].Cells[7].Value.ToString();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ຫຼືບໍ່?", "Question",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlstr = "Delete from tbProducts where pro_id='" + txtProNo.Text + "'";
                sqlCmd = new SqlCommand(sqlstr, sqlCon);
                sqlCmd.ExecuteNonQuery();
                showData();
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] btimg = ms.GetBuffer();
            string sqlstr = "Update tbproducts set pro_name=@pro_name,qty=@qty,price=@price,unit=@unit,instock=@instock,pro_img=@pro_img,ptType_ID=@ptType_ID where pro_id='" + txtProNo.Text + "'";
            sqlCmd = new SqlCommand(sqlstr, sqlCon);
            sqlCmd.Parameters.AddWithValue("@pro_name", txtProName.Text);
            sqlCmd.Parameters.AddWithValue("@qty", txtQty.Text);
            sqlCmd.Parameters.AddWithValue("@price", txtPrice.Text);
            sqlCmd.Parameters.AddWithValue("@unit", txtUnit.Text);
            sqlCmd.Parameters.AddWithValue("@instock", txtInstock.Text);
            sqlCmd.Parameters.AddWithValue("@pro_img", btimg);
            sqlCmd.Parameters.AddWithValue("@ptType_ID", cboType.SelectedValue);
            sqlCmd.ExecuteNonQuery();
            showData();
        }
    }
}