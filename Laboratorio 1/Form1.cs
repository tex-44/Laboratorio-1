using Biblioteca;
namespace Laboratorio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a= double.Parse(textBox1.Text);
            double b= double.Parse(textBox2.Text);
            Biblioteca.Class1 suma = new Biblioteca.Class1 (a, b);
            label1.Text = suma.suma().ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            Biblioteca.Class1 resta = new Biblioteca.Class1(a, b);
            label1.Text = resta.resta().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            Biblioteca.Class1 multiplicacion = new Biblioteca.Class1(a, b);
            label1.Text = multiplicacion.multiplicacion().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            Biblioteca.Class1 division = new Biblioteca.Class1(a, b);
            label1.Text = division.division().ToString();
        }
    }
}