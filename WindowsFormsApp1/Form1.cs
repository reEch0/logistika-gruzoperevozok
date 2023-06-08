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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private Gruzy grz;
        private void button1_Click(object sender, EventArgs e)
        {
            grz = new Gruzy();
            grz.Visible = true;
            this.Hide();
        }


        private Gruzoviki grzoviki;
        private void button2_Click(object sender, EventArgs e)
        {
            grzoviki= new Gruzoviki();
            grzoviki.Visible = true;
            this.Hide();
        }

        private Perevozki perevozki;
        private void button3_Click(object sender, EventArgs e)
        {
            perevozki = new Perevozki();
            perevozki.Visible = true;
            this.Hide();
        }

        private Otchet ot;
        private void button4_Click(object sender, EventArgs e)
        {
            ot = new Otchet();
            ot.Visible = true;
            this.Hide();
        }
    }
}
