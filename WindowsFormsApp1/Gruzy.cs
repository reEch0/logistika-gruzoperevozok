using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Gruzy : Form
    {
        public Gruzy()
        {
            InitializeComponent();
        }

        private Form1 f1;
        private void button1_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Visible= true;
            this.Hide();
        }

        private void gruzBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruzBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uPDataSet);

        }

        private void Gruzy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Gruz". При необходимости она может быть перемещена или удалена.
            this.gruzTableAdapter.Fill(this.uPDataSet.Gruz);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gruzBindingSource.Filter = $"Nazvanie LIKE '%{textBox1.Text}%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gruzDataGridView.Sort(gruzDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gruzDataGridView.Sort(gruzDataGridView.Columns[1], System.ComponentModel.ListSortDirection.Descending);

        }

        private NovGruz NGrz;
        private void button4_Click(object sender, EventArgs e)
        {
            NGrz = new NovGruz();
            NGrz.Visible = true;
            this.Hide();
        }
    }
}
