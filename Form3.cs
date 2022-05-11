using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        Form2 f2;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form2 f2)
        {
            this.f2 = f2;
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4(this);
            newForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.comboBox1.Text = dataGridView1.CurrentCell.Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }
    }
}
