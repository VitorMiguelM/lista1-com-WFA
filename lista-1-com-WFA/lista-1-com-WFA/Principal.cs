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

        private void btnExercício04_Click(object sender, EventArgs e)
        {
            Exercício04 exercicio04 = new Exercício04();
            exercicio04.Show();
        }

        private void btnExercício05_Click(object sender, EventArgs e)
        {
            Exercício05 exercicio05 = new Exercício05();
            exercicio05.Show();
        }

        private void btnExercicio06_Click(object sender, EventArgs e)
        {
            Exercício06 exercicio06 = new Exercício06();
            exercicio06.Show();
        }

        private void btnExercicio07_Click(object sender, EventArgs e)
        {
            Exercício07 exercicio07 = new Exercício07();
            exercicio07.Show();
        }

        private void btnExercicio08_Click(object sender, EventArgs e)
        {
            Exercício08 exercicio08 = new Exercício08();
            exercicio08.Show();
        }

        private void btnExercicio09_Click(object sender, EventArgs e)
        {
            Exercício09 exercicio09 = new Exercício09();
            exercicio09.Show();
        }
    }
}
