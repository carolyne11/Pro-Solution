namespace Pro_Solution
{
    partial class TelaCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtNomeCadastro = new TextBox();
            txtMatricula = new TextBox();
            comboBox1 = new ComboBox();
            txtSenhaCadastro = new TextBox();
            btnCadastrar = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtemail = new TextBox();
            txtConfirmarSenha = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Location = new Point(209, 112);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Location = new Point(194, 164);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Matricula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gainsboro;
            label3.Location = new Point(214, 270);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Setor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Location = new Point(210, 313);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 4;
            label5.Text = "Senha";
            // 
            // txtNomeCadastro
            // 
            txtNomeCadastro.Location = new Point(271, 104);
            txtNomeCadastro.Name = "txtNomeCadastro";
            txtNomeCadastro.Size = new Size(212, 23);
            txtNomeCadastro.TabIndex = 5;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(271, 156);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(212, 23);
            txtMatricula.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(271, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Location = new Point(271, 305);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.Size = new Size(212, 23);
            txtSenhaCadastro.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(330, 384);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 29);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Capturar;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 71);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Location = new Point(210, 218);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 11;
            label4.Text = "E-mail";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(271, 210);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(212, 23);
            txtemail.TabIndex = 12;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(271, 344);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(212, 23);
            txtConfirmarSenha.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 347);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 14;
            label6.Text = "Confirmar Senha";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtemail);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(comboBox1);
            Controls.Add(txtMatricula);
            Controls.Add(txtNomeCadastro);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtNomeCadastro;
        private TextBox txtMatricula;
        private ComboBox comboBox1;
        private TextBox txtSenhaCadastro;
        private Button btnCadastrar;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtemail;
        private TextBox txtConfirmarSenha;
        private Label label6;
    }
}