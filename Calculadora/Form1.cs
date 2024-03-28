using Calculadora.functionsMath;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSuma formSuma = new FormSuma();
            formSuma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormResta formResta = new FormResta();
            formResta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMultiplicacion formMultiplicacion = new FormMultiplicacion();
            formMultiplicacion.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDividir formDividir = new FormDividir();
            formDividir.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormLogaritmo formLogar = new FormLogaritmo();
            formLogar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPotencia formPotencia = new FormPotencia();
            formPotencia.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormRaizCuadrada formRaizCuadrada = new FormRaizCuadrada();
            formRaizCuadrada.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormSeno formSeno = new FormSeno();
            formSeno.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormCoseno formCoseno = new FormCoseno();
            formCoseno.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormValorAbsoluto formValor = new FormValorAbsoluto();
            formValor.ShowDialog();
        }
    }
}
