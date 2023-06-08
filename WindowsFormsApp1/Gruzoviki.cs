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
    public partial class Gruzoviki : Form
    {
        public Gruzoviki()
        {
            InitializeComponent();
        }

        private void gruzovikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruzovikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uPDataSet);

        }

        private void Gruzoviki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Gruzovik". При необходимости она может быть перемещена или удалена.
            this.gruzovikTableAdapter.Fill(this.uPDataSet.Gruzovik);

        }

        private Form1 f1;
        private void button1_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gruzovikDataGridView.Sort(gruzovikDataGridView.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gruzovikDataGridView.Sort(gruzovikDataGridView.Columns[3], System.ComponentModel.ListSortDirection.Descending);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(var i = 0; i < gruzovikDataGridView.RowCount; i++) 
            { 
                if(comboBox1.SelectedIndex == i)
                    gruzovikBindingSource.Filter = $"Voditel LIKE '%{comboBox1.Text}%'";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(var i = 0; i < gruzovikDataGridView.RowCount;i++)
                if(comboBox2.SelectedIndex == i)
                    gruzovikBindingSource.Filter = $"MarkaAvto LIKE '%{comboBox2.Text}%'";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gruzovikBindingSource.Filter = "";
        }
    }
}
