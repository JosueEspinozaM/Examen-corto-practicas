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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius,fahren;
            celsius = Convert.ToDouble(textBox1.Text);
            fahren = (celsius * 9 / 5) + 32;

            label4.Text = fahren+"";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 cambio = new Form1();
            cambio.Show();
            this.Hide();
        }
    }
}
