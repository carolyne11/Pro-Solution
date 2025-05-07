namespace Pro_Solution
{
    partial class FormRecuperarsenha
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
            txtEmailRecuperation = new TextBox();
            txtNovaSenha = new TextBox();
            btnConfirmar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 205);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(194, 265);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 1;
            label2.Text = "Nova senha";
            // 
            // txtEmailRecuperation
            // 
            txtEmailRecuperation.Location = new Point(294, 199);
            txtEmailRecuperation.Name = "txtEmailRecuperation";
            txtEmailRecuperation.Size = new Size(204, 23);
            txtEmailRecuperation.TabIndex = 3;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(294, 259);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(204, 23);
            txtNovaSenha.TabIndex = 4;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(338, 299);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(105, 31);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._5;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(739, 564);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormRecuperarsenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 564);
            Controls.Add(btnConfirmar);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtEmailRecuperation);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormRecuperarsenha";
            Text = "FormRecuperarsenha";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmailRecuperation;
        private TextBox txtNovaSenha;
        private Button btnConfirmar;
        private PictureBox pictureBox1;
    }
}