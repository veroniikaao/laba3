using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form11 : Form
    {
        Form8 f8;
        public Form11()
        {
            InitializeComponent();
        }
        public Form11(Form8 f8)
        {
            this.f8 = f8;
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12(this);
            newForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form12 newForm = new Form12();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delet = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f8.comboBox2.Text = dataGridView1.CurrentCell.Value.ToString();
        }
    }
}
