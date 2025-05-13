using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1;
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

namespace Pro_Solution
{
    public partial class TelaSintomas : Form
    {
        public TelaSintomas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label1 = cmbSintoma1.Text;
            string label2 = cmbSintoma2.Text;
            string label3 = cmbSintoma3.Text;
            string email = txtEmail.Text;

            int score = 0;

            if (cmbSintoma1.SelectedItem.ToString() == "SIM") score++;
            if (cmbSintoma2.SelectedItem.ToString() == "SIM") score++;
            if (cmbSintoma3.SelectedItem.ToString() == "SIM") score++;
            if (score >= 2)
                lblResultado.Text = "Você pode estar com ansiedade.";
            else
                lblResultado.Text = "Você provavelmente não está com ansiedade.";

            using (var conn = Conexao.obterConexao())
            {

                string query = "SELECT COUNT(*) FROM avaliacao WHERE email = @email";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count >= 1)
                    {
                        MessageBox.Show("Você já respondeu a pesquisa");
                    }
                    else
                    {

                        string sql = "INSERT INTO avaliacao (email,Você_se_sente_nervoso_frequentemente,Você_tem_dificuldade_para_relaxar,Você_se_sente_sobrecarregado_com_frequência) VALUES(@email,@Você_se_sente_nervoso_frequentemente,@Você_tem_dificuldade_para_relaxar,@Você_se_sente_sobrecarregado_com_frequência)";

                        using (var cmd1 = new MySqlCommand(sql, conn))
                        {
                            cmd1.Parameters.AddWithValue("@email", email);
                            cmd1.Parameters.AddWithValue("@Você_se_sente_nervoso_frequentemente", label1);
                            cmd1.Parameters.AddWithValue("@Você_tem_dificuldade_para_relaxar", label2);
                            cmd1.Parameters.AddWithValue("@Você_se_sente_sobrecarregado_com_frequência", label3);
                            cmd1.ExecuteNonQuery();
                        }

                        MessageBox.Show("Enviado com sucesso");
                        TelaEntrarColaborador telaColaborador = new TelaEntrarColaborador();
                        telaColaborador.ShowDialog();

                    }
                }
            }
        }



        private void TelaSintomas_Load(object sender, EventArgs e)
        {


            cmbSintoma1.Items.Add("SIM");
            cmbSintoma1.Items.Add("NÃO");
            cmbSintoma2.Items.Add("SIM");
            cmbSintoma2.Items.Add("NÃO");
            cmbSintoma3.Items.Add("SIM");
            cmbSintoma3.Items.Add("NÃO");


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaEntrarColaborador telaColaborador = new TelaEntrarColaborador();
            telaColaborador.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
