using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_16
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Utilizador.Nome != "")
            {
                label4.Text = Utilizador.Nome;
            }
            else
            {
                label4.Text = "Utilizador";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fechafrms.fecharfrm();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Utilizador.Nome = textBox1.Text;
            Utilizador.Gmail = textBox2.Text;
            Utilizador.Passe = textBox3.Text;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = Utilizador.Nome;
            MessageBox.Show("Utilizador guardado");
        }
    }
}
