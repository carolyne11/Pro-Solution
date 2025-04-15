namespace Pro_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrese_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void btnEmpresaTela1_Click(object sender, EventArgs e)
        {
            TelaLoginEmpresa tela = new TelaLoginEmpresa();
            tela.Show();
            this.Hide();
        }
    }
}
