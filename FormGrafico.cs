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
    public partial class FormGrafico : Form
    {
        public FormGrafico()
        {
            InitializeComponent();
            
        }

        private void FormGrafico_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=senacJBQ;database=trabalho;port=3307";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

            }

        }
    }
}
