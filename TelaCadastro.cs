using MySql.Data.MySqlClient;

namespace Pro_Solution
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Tele Marketing");
            comboBox1.Items.Add("Administrativo");
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string email = txtemail.Text;
            string senha = txtSenhaCadastro.Text;
            string nome = txtNomeCadastro.Text;
            string matricula = txtMatricula.Text;
            string setor = comboBox1.Text;
            string confirmarsenha = txtConfirmarSenha.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            if (senha != confirmarsenha)
            {
                MessageBox.Show("As senhas não coincidem");
                return;
            }

            string senhaHas = Criptografia.GerarHash(senha);
            using (var conexao = Conexao.obterConexao())
            {
                string query = "INSERT INTO usuario(email,senha,nome,matricula,setor) VALUE (@email,@senha,@nome,@matricula,@setor)";
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senhaHas);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@setor", setor);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario cadastrado com sucesso");
                    Form1 form1 = new Form1();
                    form1.ShowDialog();

                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Email ja cadastrado");
                       
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar usuario" + ex.Message);
                    }

                }
            }
        }
    }
}



