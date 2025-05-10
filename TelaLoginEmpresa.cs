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
    public partial class TelaLoginEmpresa : Form
    {
        private bool senhaVisivel = false;
        public TelaLoginEmpresa()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TelaLoginEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginEmpresa_Click(object sender, EventArgs e)
        {
            string login = txtLoginEmpresa.Text;
            string senha = txtSenhaEmpresa.Text;

            if (login == "Admin" && senha == "Admin123")
            {
                MessageBox.Show("Login Realizado com sucesso");
                TelaEntrarEmpresa telaEntrarEmpresa = new TelaEntrarEmpresa();
                telaEntrarEmpresa.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Login Incorreto");
            }
        }

        private void btnMostrarSenhaEmpresa_Click(object sender, EventArgs e)
        {
            if (senhaVisivel)
            {
                txtSenhaEmpresa.PasswordChar = '*';
                btnMostrarSenhaEmpresa.Text = "Mostrar";
                senhaVisivel = false;
            }
            else
            {
                txtSenhaEmpresa.PasswordChar = '\0';
                btnMostrarSenhaEmpresa.Text = "Esconder";
                senhaVisivel = true;
            }
        }
    }
}
