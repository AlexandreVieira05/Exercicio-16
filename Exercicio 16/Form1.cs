namespace Exercicio_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utilizador.Nome = "";
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
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
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fechafrms.fecharfrm();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}