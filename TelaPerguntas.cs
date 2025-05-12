using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pro_Solution
{
    public partial class TelaPerguntas : Form
    {
        public TelaPerguntas()
        {
            InitializeComponent();
        }


        private void cmbPergunta1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta1.Items.Add("Insatisfeito");
            cmbPergunta1.Items.Add("Satisfeito");
            cmbPergunta1.Items.Add("Neutro");
        }

        private void cmbPergunta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta2.Items.Add("Bom");
            cmbPergunta2.Items.Add("Regular");
            cmbPergunta2.Items.Add("Pessimo");
        }


        private void cmbPergunta3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta3.Items.Add("Sim");
            cmbPergunta3.Items.Add("Parcialmente");
            cmbPergunta3.Items.Add("Não");

        }

        private void cmbPergunta4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta4.Items.Add("Sim");
            cmbPergunta4.Items.Add("Raramente");
            cmbPergunta4.Items.Add("Nunca");
        }

        private void cmbPergunta5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta5.Items.Add("Sim");
            cmbPergunta5.Items.Add("Mais ou menos");
            cmbPergunta5.Items.Add("Não");

        }

        private void cmbPergunta6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta6.Items.Add("Sempre");
            cmbPergunta6.Items.Add("As vezes");
            cmbPergunta6.Items.Add("Nunca");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void cmbPergunta7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta7.Items.Add("Sim");
            cmbPergunta7.Items.Add("As vezes");
            cmbPergunta7.Items.Add("Nunca");
        }

        private void cmbPergunta8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta8.Items.Add("Sim");
            cmbPergunta8.Items.Add("As vezes");
            cmbPergunta8.Items.Add("Não");
        }

        private void cmbPergunta9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta9.Items.Add("Sim");
            cmbPergunta9.Items.Add("As vezes");
            cmbPergunta9.Items.Add("Não");
        }

        private void cmbPergunta10_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPergunta10.Items.Add("Sim");
            cmbPergunta10.Items.Add("As vezes");
            cmbPergunta10.Items.Add("Não");
        }

        private void TelaPerguntas_Load(object sender, EventArgs e)
        {
            cmbPergunta1.Items.Add("Insatisfeito");
            cmbPergunta1.Items.Add("Satisfeito");
            cmbPergunta1.Items.Add("Neutro");
            cmbPergunta2.Items.Add("Bom");
            cmbPergunta2.Items.Add("Regular");
            cmbPergunta2.Items.Add("Pessimo");
            cmbPergunta3.Items.Add("Sim");
            cmbPergunta3.Items.Add("Parcialmente");
            cmbPergunta3.Items.Add("Não");
            cmbPergunta4.Items.Add("Sim");
            cmbPergunta4.Items.Add("Raramente");
            cmbPergunta4.Items.Add("Nunca");
            cmbPergunta5.Items.Add("Sim");
            cmbPergunta5.Items.Add("Mais ou menos");
            cmbPergunta5.Items.Add("Não");
            cmbPergunta6.Items.Add("Sempre");
            cmbPergunta6.Items.Add("As vezes");
            cmbPergunta6.Items.Add("Nunca");
            cmbPergunta7.Items.Add("Sim");
            cmbPergunta7.Items.Add("As vezes");
            cmbPergunta7.Items.Add("Nunca");
            cmbPergunta8.Items.Add("Sim");
            cmbPergunta8.Items.Add("As vezes");
            cmbPergunta8.Items.Add("Não");
            cmbPergunta9.Items.Add("Sim");
            cmbPergunta9.Items.Add("As vezes");
            cmbPergunta9.Items.Add("Não");
            cmbPergunta10.Items.Add("Sim");
            cmbPergunta10.Items.Add("As vezes");
            cmbPergunta10.Items.Add("Não");


        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string pergunta1 = cmbPergunta1.Text;
            string pergunta2 = cmbPergunta2.Text;
            string pergunta3 = cmbPergunta3.Text;
            string pergunta4 = cmbPergunta4.Text;
            string pergunta5 = cmbPergunta5.Text;
            string pergunta6 = cmbPergunta6.Text;
            string pergunta7 = cmbPergunta7.Text;
            string pergunta8 = cmbPergunta8.Text;
            string pergunta9 = cmbPergunta9.Text;
            string pergunta10 = cmbPergunta10.Text;
            string email = txtEmailPerguntas.Text;

            MessageBox.Show("Email: " + email);

            using (var conn = Conexao.obterConexao())
            {

                //string query = "SELECT COUNT(*) FROM perguntas WHERE email = @email";
                //var cmd = new MySqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("@email", email);
                //int count = Convert.ToInt32(cmd.ExecuteScalar());



                string query = "SELECT COUNT(*) FROM perguntas WHERE email = @email";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());


                    MessageBox.Show("Total registros com este e-mail: " + count.ToString());

                    if (count >= 1)
                    {
                        MessageBox.Show("Você já respondeu a pesquisa");
                    }
                    else
                    {

                        string sql = "INSERT INTO perguntas (email, Como_se_sente_em_relação_ao_seu_trabalho_atualmente," +
                         "Como_avalia_seu_relacionamento_com_os_colaboradores_de_equipe, A_liderança_da_sua_equipe_é_acessiível_e_aberto_ao_diálogo," +
                         "Você_sente_que_recebe_feedebacks_construtivos_com_frequência, Você_está_contente_com_sua_remuneração_atual," +
                         "Você_sente_que_seu_esforço_é_reconhecido_de_forma_justa, Você_se_sentiu_desconfortavél_com_algum_colega_ou_gestor," +
                         "Você_se_sente_motivado_para_vir_trabalhar_todos_os_dias, Você_sente_que_seu_trabalho_é_valorizado_pela_empresa," +
                         "Sua_carga_de_trabalho_é_adequada_para_tempo_disponível) VALUES (" +
                         "@email, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)";

                        using (var cmd1 = new MySqlCommand(sql, conn))
                        {
                            cmd1.Parameters.AddWithValue("@email", email);
                            cmd1.Parameters.AddWithValue("@p1", pergunta1);
                            cmd1.Parameters.AddWithValue("@p2", pergunta2);
                            cmd1.Parameters.AddWithValue("@p3", pergunta3);
                            cmd1.Parameters.AddWithValue("@p4", pergunta4);
                            cmd1.Parameters.AddWithValue("@p5", pergunta5);
                            cmd1.Parameters.AddWithValue("@p6", pergunta6);
                            cmd1.Parameters.AddWithValue("@p7", pergunta7);
                            cmd1.Parameters.AddWithValue("@p8", pergunta8);
                            cmd1.Parameters.AddWithValue("@p9", pergunta9);
                            cmd1.Parameters.AddWithValue("@p10", pergunta10);

                            cmd1.ExecuteNonQuery();
                        }

                        MessageBox.Show("Enviado com sucesso");
                        TelaAgradecimento telaAgradecimento = new TelaAgradecimento();
                        telaAgradecimento.ShowDialog();

                    }
                }             

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TelaEntrarColaborador telaColaborador = new TelaEntrarColaborador();
            telaColaborador.ShowDialog();

        }
    }
}
