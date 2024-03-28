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
    public partial class FormLogaritmo : Form
    {
        public FormLogaritmo()
        {
            InitializeComponent();
            textBox2.Text = "2";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int bs = int.Parse(textBox2.Text);

            LabelResult.Text = $"El logaritmo del numero {numero1} es: " + Math.Log(numero1, bs).ToString();
        }
    }
}
