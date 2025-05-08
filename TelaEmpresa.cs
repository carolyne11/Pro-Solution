using Microsoft.Win32.SafeHandles;
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

namespace Pro_Solution
{
    public partial class TelaEmpresa : Form
    {
        private string connectionString;

        public TelaEmpresa()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            using (var conn = Conexao.obterConexao())
            {

                string sql = "SELECT usuario.nome, usuario.setor, perguntas.A_liderança_da_sua_equipe_é_acessiível_e_aberto_ao_diálogo,perguntas.Como_avalia_seu_relacionamento_com_os_colaboradores_de_equipe,perguntas.Como_se_sente_em_relação_ao_seu_trabalho_atualmente,perguntas.Sua_carga_de_trabalho_é_adequada_para_tempo_disponível,perguntas.Você_está_contente_com_sua_remuneração_atual,perguntas.Você_se_sente_motivado_para_vir_trabalhar_todos_os_dias,perguntas.Você_se_sentiu_desconfortavél_com_algum_colega_ou_gestor,perguntas.Você_sente_que_recebe_feedebacks_construtivos_com_frequência,perguntas.Você_sente_que_seu_esforço_é_reconhecido_de_forma_justa,perguntas.Você_sente_que_seu_trabalho_é_valorizado_pela_empresa FROM usuario inner join perguntas ON usuario.email = perguntas.email";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palavraParaContar = cmbPalavra.Text;
            int contagem = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(palavraParaContar))
                    {
                        contagem++;
                    }
                }
            }
            MessageBox.Show($"Os colaboradores do {palavraParaContar}'preencheu {contagem} vezes a pesquisa.");
        }

        private void cmbPalavra_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void TelaEmpresa_Load(object sender, EventArgs e)
        {
            cmbPalavra.Items.Add("Administrativo");
            cmbPalavra.Items.Add("Telemarketing");
        }
    }


}



