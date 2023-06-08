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
    public partial class NovPerevozka : Form
    {
        public NovPerevozka()
        {
            InitializeComponent();
        }

        private Perevozki p;
        private void button1_Click(object sender, EventArgs e)
        {
            p = new Perevozki();
            p.Visible = true;
            this.Hide();
        }

        private void perevozkiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.perevozkiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uPDataSet);

        }

        private void NovPerevozka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Goroda". При необходимости она может быть перемещена или удалена.
            this.gorodaTableAdapter.Fill(this.uPDataSet.Goroda);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Gruz". При необходимости она может быть перемещена или удалена.
            this.gruzTableAdapter.Fill(this.uPDataSet.Gruz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Gruzovik". При необходимости она может быть перемещена или удалена.
            this.gruzovikTableAdapter.Fill(this.uPDataSet.Gruzovik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.uPDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Perevozki". При необходимости она может быть перемещена или удалена.
            this.perevozkiTableAdapter.Fill(this.uPDataSet.Perevozki);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            perevozkiBindingSource.AddNew();

        }

        private Oshibka o;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //проверяет введённые в поля данные на соответствие типам данных полей
                this.Validate();
                //закрывает подключение с сервером
                this.perevozkiBindingSource.EndEdit();
                //обновляет данные на сервере
                this.tableAdapterManager.UpdateAll(this.uPDataSet);
            }
            catch
            {
                o=new Oshibka();
                o.Visible = true;
                this.Hide();
            }
        }
    }
}
