using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploStringBuilder
{
    public partial class Exemplo01 : Form
    {
        public Exemplo01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string texto = "";
            for(int i = 0; i < 10000; i++)
            {
                sb.Append(i).Append(" / 2 = ").Append(i / 2.0).Append("\r\n");
            }
            txtResultado.Text = sb.ToString();
        }

        private void txtNome03_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
