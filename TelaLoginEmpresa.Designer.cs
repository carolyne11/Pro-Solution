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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Location = new Point(135, 94);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "login";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Location = new Point(135, 141);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtLoginEmpresa
            // 
            txtLoginEmpresa.Location = new Point(190, 91);
            txtLoginEmpresa.Name = "txtLoginEmpresa";
            txtLoginEmpresa.Size = new Size(208, 23);
            txtLoginEmpresa.TabIndex = 2;
            // 
            // txtSenhaEmpresa
            // 
            txtSenhaEmpresa.Location = new Point(190, 138);
            txtSenhaEmpresa.Name = "txtSenhaEmpresa";
            txtSenhaEmpresa.Size = new Size(208, 23);
            txtSenhaEmpresa.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.grafico_login;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(575, 284);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLoginEmpresa
            // 
            btnLoginEmpresa.Location = new Point(249, 177);
            btnLoginEmpresa.Name = "btnLoginEmpresa";
            btnLoginEmpresa.Size = new Size(75, 23);
            btnLoginEmpresa.TabIndex = 5;
            btnLoginEmpresa.Text = "Login";
            btnLoginEmpresa.UseVisualStyleBackColor = true;
            btnLoginEmpresa.Click += btnLoginEmpresa_Click;
            // 
            // TelaLoginEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 284);
            Controls.Add(btnLoginEmpresa);
            Controls.Add(txtSenhaEmpresa);
            Controls.Add(txtLoginEmpresa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaLoginEmpresa";
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
    }
}