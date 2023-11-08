using System;

namespace practica_3__ejercicio_3_U3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Boton añadir
            listBox1.Items.Add(textBox1.Text);
            //Aqui es donde pasamos el parametro

            Total = f_num;
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Boton sumar numeros
            textBox2.Text = Total.ToString();
        }
    }
}