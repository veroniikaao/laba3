using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        Form5 f5;
        public Form6()
        {
            InitializeComponent();
        }

        public Form6(Form5 f5)
        {
            this.f5 = f5;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f5.dataGridView1.Rows.Add(textBox1.Text);
            Close();
        }
    }
}
