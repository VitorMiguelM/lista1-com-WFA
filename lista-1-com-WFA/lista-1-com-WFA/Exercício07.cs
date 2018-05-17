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
    public partial class Exercício07 : Form
    {
        public Exercício07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string magica = String.Format(@" *
***
*****
*******
*********
***********");

            txtMagica.Text = magica;
        }

        private void txtMagica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
