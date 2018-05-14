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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnExercicio01_Click(object sender, EventArgs e)
        {
            Exercício01 exercicio01 = new Exercício01();
            exercicio01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exercício02 exercicio02 = new Exercício02();
            exercicio02.Show();
        }

        private void btnExercicio03_Click(object sender, EventArgs e)
        {
            Exercício03 exercicio03 = new Exercício03();
            exercicio03.Show();
        }
    }
}
