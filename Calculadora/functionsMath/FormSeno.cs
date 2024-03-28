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
    public partial class FormSeno : Form
    {
        public FormSeno()
        {
            InitializeComponent();
            LabelResult.Text = "";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);

            LabelResult.Text = $"El seno de {numero1} es: " + Math.Sin(numero1).ToString();
        }
    }
}
