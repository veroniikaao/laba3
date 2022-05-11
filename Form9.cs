using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form9 : Form
    {
        Form8 f8;
        public Form9()
        {
            InitializeComponent();
        }
        public Form9(Form8 f8)
        {
            this.f8 = f8;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10(this);
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f8.comboBox1.Text = dataGridView1.CurrentCell.Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show();
        }
    }
}
