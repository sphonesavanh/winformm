﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Lecture1_15Oct24
{
    public partial class frmrptProductViewer : Form
    {
        public frmrptProductViewer()
        {
            InitializeComponent();
        }

        private void frmrptProductViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsProducts.View_Products' table. You can move, or remove it, as needed.
            //this.view_ProductsTableAdapter.Fill(this.dtsProducts.View_Products);

            this.reportViewer1.RefreshReport();
        }
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strConn = @"Data Source=UKIYOACE\MSSQLSERVER01;Initial Catalog=miniDB_4COM;Integrated Security=True;";

        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            string sqlquery = "";
            if(textBox1.Text != "")
            {
                sqlquery = "where pro_id = '" + textBox1.Text + "'";
            }
            sqlCmd = new SqlCommand("select * from View_Products " + sqlquery, sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dtPT = new DataTable();
            dtPT.Load(sqlDr);
            ReportDataSource ds = new ReportDataSource("DataSet1", dtPT);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
