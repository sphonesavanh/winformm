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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double dob = double.Parse(txtNum1.Text);
            double dob2 = double.Parse(txtNum2.Text);
            txtResult.Text = (dob + dob2).ToString();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dob = double.Parse(txtNum1.Text);
            double dob2 = double.Parse(txtNum2.Text);
            txtResult.Text = (dob - dob2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dob = double.Parse(txtNum1.Text);
            double dob2 = double.Parse(txtNum2.Text);
            txtResult.Text = (dob * dob2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double dob = double.Parse(txtNum1.Text);
            double dob2 = double.Parse(txtNum2.Text);
            txtResult.Text = (dob / dob2).ToString();
        }
    }
}
