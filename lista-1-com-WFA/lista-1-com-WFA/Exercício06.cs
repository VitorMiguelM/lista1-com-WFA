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
    public partial class Exercício06 : Form
    {
        public Exercício06()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);
            double nota4 = Convert.ToDouble(txtNota4.Text);

            double media = nota1 + nota2 + nota3 + nota4 / 4;

            string resultado = String.Format("De acordo com suas notas, sua  média é: {0}", media);

            txtMedia.Text = resultado;

            if (media < 6)
            {
                MessageBox.Show("Você deve se esforçar mais!");
            }
            if (media > 6)
            {
                MessageBox.Show("Muito bom, tem direito a um descanso");
            }
        }
    }
}
