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

namespace Lecture1_15Oct24
{
    public partial class frmProductSearch : Form
    {
        frmOrders frmo;
        public frmProductSearch(frmOrders f)
        {
            InitializeComponent();
            frmo = f;
        }

        SqlConnection sqlCon = null;
        string strConn = @"Data Source=UKIYOACE\MSSQLSERVER01;Initial Catalog=miniDB_4COM;Integrated Security=True;";

        private void frmProductSearch_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            showData("");
        }

        private void showData(string str)
        {
            string sql = "";
            if (str != "")
            {
                if (str == "lower")
                    sql = " WHERE qty <= instock";
                else
                    sql = " WHERE pro_id like '%" + str + "%'";
            }

            if (sqlCon == null || sqlCon.State == ConnectionState.Closed)
            {
                MessageBox.Show("Database connection is not initialized or closed.");
                return;
            }

            try
            {
                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM View_Products " + sql, sqlCon);
                SqlDataReader sqlDr = sqlCmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlDr);

                dgvShowData.DataSource = dt;
                dgvShowData.Columns[0].HeaderText = "ລະຫັດສິນຄ້າ";
                dgvShowData.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
                dgvShowData.Columns[2].HeaderText = "ຈຳນວນ";
                dgvShowData.Columns[3].HeaderText = "ລາຄາຕໍ່ໜ່ວຍ";
                dgvShowData.Columns[4].HeaderText = "ຫົວໜ່ວຍ";
                dgvShowData.Columns[7].HeaderText = "ປະເພດສິນຄ້າ";
                dgvShowData.Columns[5].HeaderText = "ເກນສິນຄ້າເຫຼືອ";
                dgvShowData.Columns[6].HeaderText = "ຮູບ";
                dgvShowData.Columns[8].Visible = false;

                sqlDr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnShowInstock_Click(object sender, EventArgs e)
        {
            showData("lower");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            showData("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            showData(txtSearch.Text);
        }

        private void dgvShowData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvShowData.CurrentRow == null)
            {
                MessageBox.Show("No row selected.");
                return;
            }

            int cindex = dgvShowData.CurrentRow.Index;
            frmo.txtProductID.Text = dgvShowData.Rows[cindex].Cells[0].Value?.ToString() ?? "";
            frmo.txtProductName.Text = dgvShowData.Rows[cindex].Cells[1].Value?.ToString() ?? "";
            frmo.txtQty.Text = dgvShowData.Rows[cindex].Cells[2].Value?.ToString() ?? "";
            frmo.txtProUnit.Text = dgvShowData.Rows[cindex].Cells[4].Value?.ToString() ?? "";

            frmo.Show();
            this.Close();
        }
    }
}
