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
    public partial class Perevozki : Form
    {
        public Perevozki()
        {
            InitializeComponent();
        }

        private void Perevozki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Gruzovik". При необходимости она может быть перемещена или удалена.
            this.gruzovikTableAdapter.Fill(this.uPDataSet.Gruzovik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Perevozki_info". При необходимости она может быть перемещена или удалена.
            this.perevozki_infoTableAdapter.Fill(this.uPDataSet.Perevozki_info);

        }

        private Form1 f1;
        private void button1_Click(object sender, EventArgs e)
        {
            f1 = new Form1();
            f1.Visible = true;
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(var i = 0; i < perevozki_infoDataGridView.RowCount; i++) 
            { 
                if(comboBox1.SelectedIndex == i)
                    perevozki_infoBindingSource.Filter = $"Gorod LIKE '%{comboBox1.Text}%'";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < perevozki_infoDataGridView.RowCount; i++)
            {
                if (comboBox1.SelectedIndex == i)
                    perevozki_infoBindingSource.Filter = $"Voditel LIKE '%{comboBox2.Text}%'";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < perevozki_infoDataGridView.RowCount; i++)
            {
                if (comboBox1.SelectedIndex == i)
                    perevozki_infoBindingSource.Filter = $"Nomer LIKE '%{comboBox3.Text}%'";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            perevozki_infoBindingSource.Filter = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            perevozki_infoDataGridView.Sort(perevozki_infoDataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            perevozki_infoDataGridView.Sort(perevozki_infoDataGridView.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        private NovPerevozka np;
        private void button5_Click(object sender, EventArgs e)
        {
            np = new NovPerevozka();
            np.Visible = true;
            this.Hide();
        }
    }
}
