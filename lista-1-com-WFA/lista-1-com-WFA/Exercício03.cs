using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_1_com_WFA
{
    public partial class Exercício03 : Form
    {
        public Exercício03()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double numero01 = Convert.ToDouble(nupNumero01.Text);
            double numero02 = Convert.ToDouble(nupNumero02.Text);

            double soma = numero01 + numero02;
            double subtracao = numero01 - numero02;
            double multiplicacao = numero01 * numero02;
            double divisao = numero01 / numero02;
        }

        
    }
}
