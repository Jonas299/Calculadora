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
    public partial class FormCoseno : Form
    {
        public FormCoseno()
        {
            InitializeComponent();
            LabelResult.Text = "";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);

            LabelResult.Text = $"El coseno de {numero1} es: " + Math.Cos(numero1).ToString();
        }
    }
}
