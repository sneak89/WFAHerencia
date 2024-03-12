using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        /*private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }*/


        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Ingresa el numero de bigotes"); 
            }
            else
            {
                int nBi = int.Parse(textBox2.Text);
                Gato gato1 = new Gato("SCAR", 5, nBi);
                textBox1.Text = gato1.MostrarGato();
            }


             
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty)
            {
                MessageBox.Show("Te falta informacion de la vaca"); 
            }
            else
            {
                string nombre = textBox3.Text;
                double pe = double.Parse(textBox4.Text);
                double lLeche = double.Parse(textBox5.Text);

                Vaca vaca1 = new Vaca(nombre, pe, lLeche);
                textBox1.Text = vaca1.mostrarVaca(); 

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }
    }
}
