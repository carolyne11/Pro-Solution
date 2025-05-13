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
    public partial class TelaEntrarEmpresa : Form
    {
        public TelaEntrarEmpresa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaEmpresa telaEmpresa = new TelaEmpresa();
            telaEmpresa.ShowDialog();
            this.Close();
        }

        private void TelaEntrarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TelaEmpresaAvaliacao telaEmpresaAvaliacao = new TelaEmpresaAvaliacao();
            telaEmpresaAvaliacao.ShowDialog();
        }
    }
}
