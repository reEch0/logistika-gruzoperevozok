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
    public partial class NovGruz : Form
    {
        public NovGruz()
        {
            InitializeComponent();
        }

        private void gruzBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gruzBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uPDataSet);

        }

        private void NovGruz_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uPDataSet.Gruz". При необходимости она может быть перемещена или удалена.
            this.gruzTableAdapter.Fill(this.uPDataSet.Gruz);

        }

        private Gruzy grz;
        private void button1_Click(object sender, EventArgs e)
        {
            grz = new Gruzy();
            grz.Visible = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gruzBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей
            this.Validate();
            //закрывает подключение с сервером
            this.gruzBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.uPDataSet);
        }
    }
}
