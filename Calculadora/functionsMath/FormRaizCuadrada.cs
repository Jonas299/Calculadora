using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora.functionsMath
{
    public partial class FormRaizCuadrada : Form
    {
        public FormRaizCuadrada()
        {
            InitializeComponent();
            LabelResult.Text = "";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);

            LabelResult.Text = $"La raiz cuadrada de {numero1} es: " + Math.Sqrt(numero1).ToString();
        }
    }
}
