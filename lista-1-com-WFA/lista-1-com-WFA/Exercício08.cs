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
    public partial class Exercício08 : Form
    {
        public Exercício08()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exercício08_Load(object sender, EventArgs e)
        {

        }

        private void btnInformações_Click(object sender, EventArgs e)
        {
            double contaDeLuz = Convert.ToDouble(txtLuz.Text);
            double contaDeAgua = Convert.ToDouble(txtAgua.Text);
            double valorNet = Convert.ToDouble(txtNet.Text);
            double valorVivo = Convert.ToDouble(txtVivo.Text);
            double valorOi = Convert.ToDouble(txtOi.Text);
            double valorIPTU = Convert.ToDouble(txtIPTU.Text);
            double valorIPVA = Convert.ToDouble(txtIPVA.Text);
            double seguroDoCarro = Convert.ToDouble(txtSeguroCarro.Text);

            double valorDasContasDeTelefone = valorNet + valorVivo + valorOi;

            double valorImpostos = valorIPTU + valorIPVA;

            double restanteDasContas = contaDeLuz + contaDeAgua + seguroDoCarro;

            double valorTotalDeTodasAsContas = valorDasContasDeTelefone + valorImpostos + restanteDasContas;

            string informacoes = String.Format(@"Valor das contas do Telefone: {0}
Valor dos impostos: {1}
valor do restante das contas: {2}
valor total de todas as contas: {3}",valorDasContasDeTelefone, valorImpostos, restanteDasContas, valorTotalDeTodasAsContas);

            txtInformações.Text = informacoes;
        }
    }
}
