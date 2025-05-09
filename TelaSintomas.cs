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

            int score = 0;

            if (cmbSintoma1.SelectedItem.ToString() == "SIM") score++;
            if (cmbSintoma2.SelectedItem.ToString() == "SIM") score++;
            if (cmbSintoma3.SelectedItem.ToString() == "SIM") score++;
            if (score >= 2)
                lblResultado.Text = "Você pode estar com ansiedade.";
            else
                lblResultado.Text = "Você provavelmente não está com ansiedade.";
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
    }
}
