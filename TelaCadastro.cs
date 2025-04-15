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
    }
}
