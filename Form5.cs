using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        Form2 f2;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(Form2 f2)
        {
            this.f2 = f2;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6(this);
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.comboBox2.Text = dataGridView1.CurrentCell.Value.ToString();
        }
    }
}
