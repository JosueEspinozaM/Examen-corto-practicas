using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_corto_practicas
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kelvin, rankine;
            kelvin = Convert.ToDouble(textBox1.Text);
            rankine = kelvin * 9 / 5;

            label4.Text = rankine + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 cambio = new Form1();
            cambio.Show();
            this.Hide();
        }
    }
}
