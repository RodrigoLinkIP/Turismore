using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseñodepagina
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 principal = new Form1();
            principal.ShowDialog();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = text;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = text;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario, contra;


            usuario = textBox1.Text;
            contra = textBox2.Text;
            if (usuario == string.Empty || contra == string.Empty)
            {
                MessageBox.Show("Casillas vacias, ingrese su informacion.");
            }
            else
            {
                if (usuario == "Lopez") ;
                {
                    if (contra == "1234") ;
                    {
                        MessageBox.Show("Bienvenido " + usuario);
                        this.Hide();
                        Form1 logueado = new Form1();
                        logueado.ShowDialog();
                    }

                }
            }
        }
    }
}
