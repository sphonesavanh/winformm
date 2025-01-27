using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture1_15Oct24
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            comboBox1.Items.Add("dd/MM/yyyy");          
            comboBox1.Items.Add("MM/dd/yyyy");          
            comboBox1.Items.Add("yyyy-MM-dd");          
            comboBox1.Items.Add("dd MMMM yyyy");        
            comboBox1.Items.Add("MMM dd, yyyy");        
            comboBox1.Items.Add("dddd, MMMM dd, yyyy"); 
            comboBox1.SelectedIndex = 0; 

            button1.Click += button1_Click;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdFormat_Click(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DateTime now = DateTime.Now;
                string formattedDate = now.ToString(DateTimeFormatInfo.CurrentInfo);
                cmdFormat.Text = formattedDate;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                DateTime now = DateTime.Now;
                string formattedDate = now.ToString(DateTimeFormatInfo.InvariantInfo);
                cmdFormat.Text = formattedDate;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            string selectedFormat = comboBox1.SelectedItem.ToString();

            string formattedDate = now.ToString(selectedFormat);

            cmdFormat2.Text = formattedDate;
        }

        private void cmdFormat2_Click(object sender, EventArgs e)
        {

        }
    }
}
