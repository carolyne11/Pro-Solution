using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Solution
{
    public partial class TelaEntrarColaborador : Form
    {
        public TelaEntrarColaborador()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPerguntas telaPerguntas = new TelaPerguntas();
            telaPerguntas.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bntHappy_Click(object sender, EventArgs e)
        {
            bntHappy.Text = "😃";
            bntHappy.Click -= bntHappy_Click;
            MessageBox.Show("Que bom que você está feliz! 😊", "Resposta");
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            btnBad.Text = "😢";
            btnBad.Click -= btnBad_Click;
            MessageBox.Show("Sinto muito que você não esteja feliz. 😔", "Resposta");
        }

        private void btnAcessarTeste_Click(object sender, EventArgs e)
        {
            TelaSintomas telaSintomas = new TelaSintomas();
            telaSintomas.ShowDialog();
        }
    }
}
