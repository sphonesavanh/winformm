using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;

namespace Lecture1_15Oct24
{
    public partial class frmProductType : Form
    {
        public frmProductType()
        { 
            InitializeComponent();
            connectionDB_Checking();
            getPtTypeData();
        }

        string strConnect = @"Data Source=UKIYOACE\MSSQLSERVER01;Initial Catalog=miniDB_4COM;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;

        private void getPtTypeData()
        {
            string sql = "select * from tbPtProductType";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvShow.DataSource = dt;
            dgvShow.Columns[0].HeaderText = "ລະຫັດປະເພດ";
            dgvShow.Columns[1].HeaderText = "ຊື່ປະເພດ";
        }

        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into tbPtProductType values('"+
                txtPtTypeID.Text+"', N'"+txtPtTypeName.Text+"')";
            cmd = new SqlCommand (sql, conn);
            cmd.ExecuteNonQuery();
            getPtTypeData();
        }

        private void dgvShow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShow.CurrentRow.Index;
            txtPtTypeID.Text = dgvShow.Rows[cindex].Cells[0].Value.ToString();
            txtPtTypeName.Text = dgvShow.Rows[cindex].Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "update tbPtProductType set ptType_name=N'" +
                txtPtTypeName.Text + "' where ptType_ID='" + txtPtTypeID.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            getPtTypeData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ່?", "Question",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from tbPtProductType where ptType_ID= '" + txtPtTypeID.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                getPtTypeData();
            }
            
        }
    }
}
