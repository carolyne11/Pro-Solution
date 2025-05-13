using MySql.Data.MySqlClient;

namespace Pro_Solution
{

    public partial class Form1 : Form

    {
        private string connectionString = "server=localhost;user=root;password=senacJBQ;database=trabalho;port=3307";
        private bool senhaVisivel = false;
        public Form1()
        {
            InitializeComponent();
            txtSenhaTela1.PasswordChar = '*';
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

        private void txtLoginTela1_TextChanged(object sender, EventArgs e)
        {

        }

        public bool VerificarLogin(string email, string senha)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM usuario WHERE email = @email AND senha = @senha";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@senha", senha);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Retorna true se o usuário existir
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtLoginTela1.Text;
            string senha = txtSenhaTela1.Text;

            string senhaHash = Criptografia.GerarHash(senha);

            using (var conexao = Conexao.obterConexao())
            {
                string query = "SELECT * FROM usuario WHERE email = @email AND senha = @senha";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senhaHash);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Login realizado com sucesso");
                    MessageBox.Show($"Bem vindo {email}");
                    TelaEntrarColaborador telaColaborador = new TelaEntrarColaborador();
                    telaColaborador.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalido");
                }
            }
        }

        private void btnMostarSenha_Click(object sender, EventArgs e)
        {
            if (senhaVisivel)
            {
                txtSenhaTela1.PasswordChar = '*';
                btnMostarSenha.Text = "Mostrar";
                senhaVisivel = false;
            }
            else
            {
                txtSenhaTela1.PasswordChar = '\0';
                btnMostarSenha.Text = "Esconder";
                senhaVisivel = true;
            }
        }

        private void btnEsqueci_Click(object sender, EventArgs e)
        {
            FormRecuperarsenha formRecuperarsenha = new FormRecuperarsenha();
            formRecuperarsenha.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
