﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("15 + 5 = " + ( 15+5 )); 
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.Red;
            button1.Text = "Hello";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Text = "Calculate";
        }
    }
}
