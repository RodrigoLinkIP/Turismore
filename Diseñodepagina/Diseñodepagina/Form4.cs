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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 regresar = new Form1();
            regresar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.UseSystemPasswordChar = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox4.Text;
            if (checkBox1.Checked)
            {
                textBox4.UseSystemPasswordChar = false;
                textBox4.Text = text;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
                textBox4.Text = text;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox5.Text;
            if (checkBox2.Checked)
            {
                textBox5.UseSystemPasswordChar = false;
                textBox5.Text = text;
            }
            else
            {
                textBox5.UseSystemPasswordChar = true;
                textBox5.Text = text;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
