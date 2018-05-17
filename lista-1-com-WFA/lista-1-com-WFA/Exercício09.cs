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
    public partial class Exercício09 : Form
    {
        public Exercício09()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int numero01 = Convert.ToInt32(txtNumero01.Text);
            int numero02 = Convert.ToInt32(txtNumero02.Text);

            numero01 = numero01 + numero02;
           
            numero02 = numero01 - numero02;
            
            numero01 = numero01 - numero02;

            string resultado = String.Format(@"Numero1: {0}
numero2: {1}", numero01, numero02);

            txtResultado.Text = resultado;
        }
    }
}
