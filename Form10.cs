using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form10 : Form
    {
        Form9 f9;
        public Form10()
        {
            InitializeComponent();
        }
        public Form10(Form9 f9)
        {
            this.f9 = f9;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            f9.dataGridView1.Rows.Add(textBox1.Text);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
