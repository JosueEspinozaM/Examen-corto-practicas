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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fahren, rankine;
            fahren = Convert.ToDouble(textBox1.Text);
            rankine = fahren + 459.67;

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
