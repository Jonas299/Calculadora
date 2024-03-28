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
    public partial class FormValorAbsoluto : Form
    {
        public FormValorAbsoluto()
        {
            InitializeComponent();
            LabelResult.Text = "";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);

            LabelResult.Text = $"El valor absoluto de {numero1} es: " + Math.Abs(numero1).ToString();
        }
    }
}
