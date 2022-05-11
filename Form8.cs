using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form8 : Form
    {
        Form7 f7;
        public Form8()
        {
            InitializeComponent();
        }
        public Form8(Form7 f7)
        {
            this.f7 = f7;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f7.dataGridView1.Rows.Add(textBox1.Text, dateTimePicker1.Text, comboBox1.Text, textBox3.Text, comboBox2.Text);
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void jobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9(this);
            newForm.Show();
        }

        private void scienceDegreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11(this);
            newForm.Show();
        }
    }
}
