using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 f1;
        
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f1)
        {
            this.f1 = f1;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            f1.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Text, comboBox1.Text, comboBox2.Text, textBox4.Text);
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void udkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Show();
        }

        private void publisherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5(this);
            newForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
