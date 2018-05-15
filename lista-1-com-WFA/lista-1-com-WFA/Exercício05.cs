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
    public partial class Exercício05 : Form
    {
        public Exercício05()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Apresentacao();

        }


        private void Apresentacao()
        {
            double valorDoCarro = Convert.ToDouble(mtbValorDoCarro.Text);
            double valorDaParcela = Convert.ToDouble(mtbValorDeCadaParcela.Text);
            int quantidadeDeParcelas = Convert.ToInt32(nupQuantidadeDeParcelas.Value);
            double valorTotalDoFinanciamento = valorDaParcela * quantidadeDeParcelas;
            double diferencaFinanciamento = valorTotalDoFinanciamento - valorDoCarro;
            string nomeDoCarro = txtNomeDoCarro.Text;

            string dados = string.Format(@"Nome do carro: {0}
Valor do carro: {1}
Valor da parcela: {2}
Quantidade de parcelas: {3}
Valor total do financiamento: {4}
Diferença do Financiamento e o valor do carro: {5}", nomeDoCarro, valorDoCarro, valorDaParcela, quantidadeDeParcelas, valorTotalDoFinanciamento, diferencaFinanciamento);

            txtResultado.Text = dados;

        }

        private void validacao()
        {
            
        }
    

     
    }
}
