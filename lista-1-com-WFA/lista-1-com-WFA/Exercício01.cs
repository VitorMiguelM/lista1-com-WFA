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
    public partial class Exercício01 : Form
    {
        public Exercício01()
        {
            InitializeComponent();
        }
        
        double antecessor = 0;
        double sucessor = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void cbSucessor_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void ArmazenarInformações()
        {
            
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(nupNumero.Value);

            sucessor = numero + 1;
            antecessor = numero - 1;

            string resultado = String.Format("Sucessor: {0}  Antecessor {1}", sucessor, antecessor);

            txtResultado.Text = resultado; 

             
          

        }

        private void rdSucessor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdAntecessor_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void nupNumero_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
