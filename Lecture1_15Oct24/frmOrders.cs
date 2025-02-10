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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strConn = @"Data Source=UKIYOACE\MSSQLSERVER01;Initial Catalog=miniDB_4COM;Integrated Security=True;";

        private void btnProSearch_Click(object sender, EventArgs e)
        {
            frmProductSearch frm = new frmProductSearch(this);
            frm.ShowDialog();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            sqlCmd = new SqlCommand("select * from tbSupplier" , sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dtPT = new DataTable();
            dtPT.Load(sqlDr);
            cboSupID.DataSource = dtPT;
            cboSupID.DisplayMember = "supplier_name";
            cboSupID.ValueMember = "supplier_id";
            showDataOrder();
            showDataOrderDetail();
        }
        private void showDataOrder()
        {
            using (SqlCommand sqlCmd = new SqlCommand("SELECT * FROM View_Order", sqlCon))
            using (SqlDataReader sqlDr = sqlCmd.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(sqlDr);
                dgvOrder.DataSource = dt;
            }

            dgvOrder.Columns[0].HeaderText = "ລະຫັດ";
            dgvOrder.Columns[1].HeaderText = "ວັນທີ";
            dgvOrder.Columns[2].HeaderText = "ຊື່ຜູ້ສະໜອງ";
            dgvOrder.Columns[3].HeaderText = "ສະຖານະ";
            dgvOrder.Columns[4].Visible = false;
        }

        private void showDataOrderDetail()
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text)) return;

            string query = "SELECT * FROM View_OrderDetail WHERE orderID = @orderID";
            using (SqlCommand sqlCmd = new SqlCommand(query, sqlCon))
            {
                sqlCmd.Parameters.AddWithValue("@orderID", txtOrderID.Text);
                using (SqlDataReader sqlDr = sqlCmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(sqlDr);
                    dgvOrderDetail.DataSource = dt;
                }
            }
        }


        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            string sqlstr = "INSERT INTO tbOrder (orderID, orderDate, supplierID, status) VALUES (@orderID, @orderDate, @supplierID, 'N')";
            using (SqlCommand sqlCmd = new SqlCommand(sqlstr, sqlCon))
            {
                sqlCmd.Parameters.AddWithValue("@orderID", txtOrderID.Text);
                sqlCmd.Parameters.AddWithValue("@orderDate", dtpOrderDate.Value);  // Use Value, not Text
                sqlCmd.Parameters.AddWithValue("@supplierID", cboSupID.SelectedValue);
                sqlCmd.ExecuteNonQuery();
            }
            showDataOrder();
        }


        private void dgvOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvOrder.CurrentRow.Index;
            txtOrderID.Text = dgvOrder.Rows[cindex].Cells[0].Value.ToString();
            dtpOrderDate.Text = dgvOrder.Rows[cindex].Cells[1].Value.ToString();
            cboSupID.SelectedValue = dgvOrder.Rows[cindex].Cells[4].Value.ToString();
            showDataOrderDetail();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text) || string.IsNullOrWhiteSpace(txtProductID.Text) || string.IsNullOrWhiteSpace(txtQty.Text))
            {
                MessageBox.Show("Please fill all fields before adding an order detail!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlstr = "INSERT INTO tbOrderDetail (orderID, ProID, Amount, status) VALUES (@orderID, @ProID, @Amount, 'N')";
            using (SqlCommand sqlCmd = new SqlCommand(sqlstr, sqlCon))
            {
                sqlCmd.Parameters.AddWithValue("@orderID", txtOrderID.Text);
                sqlCmd.Parameters.AddWithValue("@ProID", txtProductID.Text);
                sqlCmd.Parameters.AddWithValue("@Amount", txtQty.Text);
                sqlCmd.ExecuteNonQuery();
            }

            showDataOrderDetail();
        }

    }
}
