using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Otchet : Form
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private Form1 f1;
        private void button1_Click(object sender, EventArgs e)
        {
            f1= new Form1();
            f1.Visible=true;
            this.Hide();
        }

        private void Otchet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.most_pop_city". При необходимости она может быть перемещена или удалена.
            this.most_pop_cityTableAdapter.Fill(this.uPDataSet.most_pop_city);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.most_pop_tovar". При необходимости она может быть перемещена или удалена.
            this.most_pop_tovarTableAdapter.Fill(this.uPDataSet.most_pop_tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.most_pop_city". При необходимости она может быть перемещена или удалена.
            this.most_pop_cityTableAdapter.Fill(this.uPDataSet.most_pop_city);

        }
    }
}
