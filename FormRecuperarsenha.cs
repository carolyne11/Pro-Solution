using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Solution
{
    public partial class FormRecuperarsenha : Form
    {
        private string connectionString = "server=localhost;user=root;password=senacJBQ;database=trabalho;port=3307";
        private bool senhaVisivel = false;

        public FormRecuperarsenha()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string email = txtEmailRecuperation.Text;
            string newPassword = txtNovaSenha.Text;
            string senhaHash = Criptografia.GerarHash(newPassword);

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            ChangePassword(email, senhaHash);
        }

        private void ChangePassword(string email, string newPassword)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE usuario SET senha = @senha WHERE email = @email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@senha", newPassword); 
                    cmd.Parameters.AddWithValue("@email", email);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Senha alterada com sucesso!");
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        }
    }

