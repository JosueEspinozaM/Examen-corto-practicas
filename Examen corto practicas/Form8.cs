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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius, rankine;
            rankine = Convert.ToDouble(textBox1.Text);
            celsius = (rankine - 491.67) * 5/9;

            label4.Text = celsius + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 cambio = new Form1();
            cambio.Show();
            this.Hide();
        }
    }
}
