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
    public partial class Oshibka : Form
    {
        public Oshibka()
        {
            InitializeComponent();
        }

        private Perevozki p;
        private void button1_Click(object sender, EventArgs e)
        {
            p=new Perevozki();
            p.Visible= true;
            this.Hide();
        }
    }
}
