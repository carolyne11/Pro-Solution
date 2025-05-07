namespace Pro_Solution
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtLoginTela1 = new TextBox();
            txtSenhaTela1 = new TextBox();
            btnEntrar = new Button();
            btnCadastrese = new Button();
            btnEmpresaTela1 = new Button();
            pictureBox1 = new PictureBox();
            btnMostarSenha = new Button();
            btnEsqueci = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 115);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 0;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 168);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtLoginTela1
            // 
            txtLoginTela1.Location = new Point(293, 112);
            txtLoginTela1.Name = "txtLoginTela1";
            txtLoginTela1.Size = new Size(203, 23);
            txtLoginTela1.TabIndex = 2;
            txtLoginTela1.TextChanged += txtLoginTela1_TextChanged;
            // 
            // txtSenhaTela1
            // 
            txtSenhaTela1.Location = new Point(293, 165);
            txtSenhaTela1.Name = "txtSenhaTela1";
            txtSenhaTela1.Size = new Size(203, 23);
            txtSenhaTela1.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = SystemColors.ButtonShadow;
            btnEntrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(513, 139);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCadastrese
            // 
            btnCadastrese.BackColor = SystemColors.ButtonShadow;
            btnCadastrese.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrese.Location = new Point(36, 56);
            btnCadastrese.Name = "btnCadastrese";
            btnCadastrese.Size = new Size(91, 23);
            btnCadastrese.TabIndex = 5;
            btnCadastrese.Text = "Cadastre-se";
            btnCadastrese.UseVisualStyleBackColor = false;
            btnCadastrese.Click += btnCadastrese_Click;
            // 
            // btnEmpresaTela1
            // 
            btnEmpresaTela1.BackColor = SystemColors.ButtonShadow;
            btnEmpresaTela1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpresaTela1.Location = new Point(688, 56);
            btnEmpresaTela1.Name = "btnEmpresaTela1";
            btnEmpresaTela1.Size = new Size(75, 23);
            btnEmpresaTela1.TabIndex = 6;
            btnEmpresaTela1.Text = "Empresa";
            btnEmpresaTela1.UseVisualStyleBackColor = false;
            btnEmpresaTela1.Click += btnEmpresaTela1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Mídia;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnMostarSenha
            // 
            btnMostarSenha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostarSenha.Location = new Point(621, 112);
            btnMostarSenha.Name = "btnMostarSenha";
            btnMostarSenha.Size = new Size(119, 23);
            btnMostarSenha.TabIndex = 8;
            btnMostarSenha.Text = "Mostrar Senha";
            btnMostarSenha.UseVisualStyleBackColor = true;
            btnMostarSenha.Click += btnMostarSenha_Click;
            // 
            // btnEsqueci
            // 
            btnEsqueci.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEsqueci.Location = new Point(621, 160);
            btnEsqueci.Name = "btnEsqueci";
            btnEsqueci.Size = new Size(119, 23);
            btnEsqueci.TabIndex = 9;
            btnEsqueci.Text = "Esqueci a senha";
            btnEsqueci.UseVisualStyleBackColor = true;
            btnEsqueci.Click += btnEsqueci_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 448);
            Controls.Add(btnEsqueci);
            Controls.Add(btnMostarSenha);
            Controls.Add(btnEmpresaTela1);
            Controls.Add(btnCadastrese);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenhaTela1);
            Controls.Add(txtLoginTela1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLoginTela1;
        private TextBox txtSenhaTela1;
        private Button btnEntrar;
        private Button btnCadastrese;
        private Button btnEmpresaTela1;
        private PictureBox pictureBox1;
        private Button btnMostarSenha;
        private Button btnEsqueci;
    }
}
