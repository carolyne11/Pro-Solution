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
            Matricula = new TextBox();
            comboBox1 = new ComboBox();
            txtSenhaCadastro = new TextBox();
            btnCadastrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 107);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 159);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Matricula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 213);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "Setor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 268);
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
            // Matricula
            // 
            Matricula.Location = new Point(271, 156);
            Matricula.Name = "Matricula";
            Matricula.Size = new Size(212, 23);
            Matricula.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(271, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Location = new Point(271, 265);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.Size = new Size(212, 23);
            txtSenhaCadastro.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(338, 316);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
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
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(comboBox1);
            Controls.Add(Matricula);
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
        private TextBox Matricula;
        private ComboBox comboBox1;
        private TextBox txtSenhaCadastro;
        private Button btnCadastrar;
        private PictureBox pictureBox1;
    }
}