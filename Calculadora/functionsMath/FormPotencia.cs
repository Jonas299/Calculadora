using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.functionsMath
{
    public partial class FormPotencia : Form
    {
        public FormPotencia()
        {
            InitializeComponent();
            LabelResult.Text = "";
            label3.Text = "";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);

            LabelResult.Text = $"El resultado de elevar {numero1} a la potencia de {numero2}";
            label2.Text = Math.Pow(numero1, numero2).ToString();
        }

        private void LabelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
