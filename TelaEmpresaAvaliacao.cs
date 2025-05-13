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
    public partial class TelaEmpresaAvaliacao : Form
    {
        public TelaEmpresaAvaliacao()
        {
            InitializeComponent();
        }

        private void btnCarregarDado_Click(object sender, EventArgs e)
        {
            using (var conn = Conexao.obterConexao())
            {

                string sql = "SELECT usuario.nome,usuario.setor,avaliacao.Você_se_sente_nervoso_frequentemente,avaliacao.Você_tem_dificuldade_para_relaxar,avaliacao.Você_se_sente_sobrecarregado_com_frequência from usuario INNER JOIN avaliacao ON usuario.email=avaliacao.email;";
                //MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
                //DataTable dt = new DataTable();
                //dataAdapter.Fill(dt);
                //dataGridView1.AutoGenerateColumns = true; // Permite que o DataGridView gere automaticamente as colunas
                //dataGridView1.DataSource = dt;

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;



            }
        }
    }
}
