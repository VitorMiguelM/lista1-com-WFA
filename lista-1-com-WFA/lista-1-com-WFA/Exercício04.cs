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
    public partial class Exercício04 : Form
    {
        public Exercício04()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(nudNumero.Value);

            int x1 = numero * 1;
            int x2 = numero * 2;
            int x3 = numero * 3;
            int x4 = numero * 4;
            int x5 = numero * 5;
            int x6 = numero * 6;
            int x7 = numero * 7;
            int x8 = numero * 8;
            int x9 = numero * 9;
            int x10 = numero * 10;


            string resultado = string.Format(@"{0} x 1 = {1}
{0} x 2 = {2}
{0} x 3 = {3}
{0} x 4 = {4}
{0} x 5 = {5}
{0} x 6 = {6}
{0} x 7 = {7}
{0} x 8 = {8}
{0} x 9 = {9}
{0} x 10 = {10}", numero, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10);

 

            txtResultado.Text = resultado;
           
        }
    }
}
