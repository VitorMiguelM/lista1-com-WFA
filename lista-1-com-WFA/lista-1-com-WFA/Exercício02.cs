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
    public partial class Exercício02 : Form
    {
        public Exercício02()
        {
            InitializeComponent();
        }

        private void lblQuantidadeAnosConsumidos_Click(object sender, EventArgs e)
        {

        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            int quantidadeAnos = Convert.ToInt32(nupQuantidadeAnosConsumidos.Value);
            int quantidadeLitros = Convert.ToInt32(nupQuantidadeLitros.Value);
            double valorPorLitro = 0;

           

            try
            {
                valorPorLitro = Convert.ToDouble(mtbValorPorLitro.Text);

            }
            catch
            {
                MessageBox.Show("O campo \"Valor por litro\"DEVE ser preenchido!");
                mtbValorPorLitro.Focus();
                return;

            }

            int quantidadeLitrosConsumidos = (quantidadeAnos * 365) * quantidadeLitros;

            double valorTotalPago = quantidadeLitrosConsumidos * valorPorLitro;

            string resultado = String.Format(@"Quantidade Litros Consumidos: {0}L
                                            Valor total pago: {1:n}");

            txtResultado.Text = resultado;

            


        }

        private void txtValorPago_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
