namespace Pro_Solution
{
    partial class TelaLoginEmpresa
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
            txtLoginEmpresa = new TextBox();
            txtSenhaEmpresa = new TextBox();
            pictureBox1 = new PictureBox();
            btnLoginEmpresa = new Button();
            btnMostrarSenhaEmpresa = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 167);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 0;
            label1.Text = "login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 226);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtLoginEmpresa
            // 
            txtLoginEmpresa.Location = new Point(277, 159);
            txtLoginEmpresa.Name = "txtLoginEmpresa";
            txtLoginEmpresa.Size = new Size(208, 23);
            txtLoginEmpresa.TabIndex = 2;
            // 
            // txtSenhaEmpresa
            // 
            txtSenhaEmpresa.Location = new Point(277, 218);
            txtSenhaEmpresa.Name = "txtSenhaEmpresa";
            txtSenhaEmpresa.Size = new Size(208, 23);
            txtSenhaEmpresa.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._61;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(757, 476);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLoginEmpresa
            // 
            btnLoginEmpresa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginEmpresa.Location = new Point(348, 261);
            btnLoginEmpresa.Name = "btnLoginEmpresa";
            btnLoginEmpresa.Size = new Size(80, 27);
            btnLoginEmpresa.TabIndex = 5;
            btnLoginEmpresa.Text = "Login";
            btnLoginEmpresa.UseVisualStyleBackColor = true;
            btnLoginEmpresa.Click += btnLoginEmpresa_Click;
            // 
            // btnMostrarSenhaEmpresa
            // 
            btnMostrarSenhaEmpresa.Location = new Point(584, 191);
            btnMostrarSenhaEmpresa.Name = "btnMostrarSenhaEmpresa";
            btnMostrarSenhaEmpresa.Size = new Size(98, 23);
            btnMostrarSenhaEmpresa.TabIndex = 6;
            btnMostrarSenhaEmpresa.Text = "Mostrar Senha";
            btnMostrarSenhaEmpresa.UseVisualStyleBackColor = true;
            btnMostrarSenhaEmpresa.Click += btnMostrarSenhaEmpresa_Click;
            // 
            // TelaLoginEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 476);
            Controls.Add(btnMostrarSenhaEmpresa);
            Controls.Add(btnLoginEmpresa);
            Controls.Add(txtSenhaEmpresa);
            Controls.Add(txtLoginEmpresa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaLoginEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaLoginEmpresa";
            Load += TelaLoginEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLoginEmpresa;
        private TextBox txtSenhaEmpresa;
        private PictureBox pictureBox1;
        private Button btnLoginEmpresa;
        private Button btnMostrarSenhaEmpresa;
    }
}