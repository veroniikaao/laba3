using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form12 : Form
    {
    
        Form11 f11;
        public Form12()
        {
            InitializeComponent();
        }
        public Form12(Form11 f11)
        {
            this.f11 = f11;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f11.dataGridView1.Rows.Add(textBox1.Text);
            Close();
        }
    }
}
