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
            label3 = new Label();
            txtEmailRecuperation = new TextBox();
            txtNovaSenha = new TextBox();
            txtConfirmeSenha = new TextBox();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 93);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 137);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Nova senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 179);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 2;
            label3.Text = "Confirme a nova senha";
            // 
            // txtEmailRecuperation
            // 
            txtEmailRecuperation.Location = new Point(334, 90);
            txtEmailRecuperation.Name = "txtEmailRecuperation";
            txtEmailRecuperation.Size = new Size(204, 23);
            txtEmailRecuperation.TabIndex = 3;
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(334, 134);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(204, 23);
            txtNovaSenha.TabIndex = 4;
            // 
            // txtConfirmeSenha
            // 
            txtConfirmeSenha.Location = new Point(334, 176);
            txtConfirmeSenha.Name = "txtConfirmeSenha";
            txtConfirmeSenha.Size = new Size(204, 23);
            txtConfirmeSenha.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(387, 215);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(105, 31);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // FormRecuperarsenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmar);
            Controls.Add(txtConfirmeSenha);
            Controls.Add(txtNovaSenha);
            Controls.Add(txtEmailRecuperation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRecuperarsenha";
            Text = "FormRecuperarsenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmailRecuperation;
        private TextBox txtNovaSenha;
        private TextBox txtConfirmeSenha;
        private Button btnConfirmar;
    }
}