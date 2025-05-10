namespace Pro_Solution
{
    partial class TelaEntrarColaborador
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            bntHappy = new Button();
            btnBad = new Button();
            label2 = new Label();
            label3 = new Label();
            btnAcessarTeste = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._6;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 577);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(30, 233);
            button1.Name = "button1";
            button1.Size = new Size(86, 33);
            button1.TabIndex = 2;
            button1.Text = "ACESSAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(561, 199);
            label1.Name = "label1";
            label1.Size = new Size(218, 17);
            label1.TabIndex = 3;
            label1.Text = "Como Você está se sentindo hoje?";
            // 
            // bntHappy
            // 
            bntHappy.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntHappy.Location = new Point(570, 232);
            bntHappy.Name = "bntHappy";
            bntHappy.Size = new Size(82, 33);
            bntHappy.TabIndex = 4;
            bntHappy.Text = "😊";
            bntHappy.UseVisualStyleBackColor = true;
            bntHappy.Click += bntHappy_Click;
            // 
            // btnBad
            // 
            btnBad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBad.Location = new Point(701, 232);
            btnBad.Name = "btnBad";
            btnBad.Size = new Size(78, 33);
            btnBad.TabIndex = 5;
            btnBad.Text = "😢";
            btnBad.UseVisualStyleBackColor = true;
            btnBad.Click += btnBad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 199);
            label2.Name = "label2";
            label2.Size = new Size(163, 17);
            label2.TabIndex = 6;
            label2.Text = "Formulário De Perguntas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 199);
            label3.Name = "label3";
            label3.Size = new Size(156, 17);
            label3.TabIndex = 7;
            label3.Text = "Teste Avaliativo pessoal";
            // 
            // btnAcessarTeste
            // 
            btnAcessarTeste.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcessarTeste.Location = new Point(335, 233);
            btnAcessarTeste.Name = "btnAcessarTeste";
            btnAcessarTeste.Size = new Size(86, 34);
            btnAcessarTeste.TabIndex = 8;
            btnAcessarTeste.Text = "ACESSAR";
            btnAcessarTeste.UseVisualStyleBackColor = true;
            btnAcessarTeste.Click += btnAcessarTeste_Click;
            // 
            // TelaEntrarColaborador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 577);
            Controls.Add(btnAcessarTeste);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBad);
            Controls.Add(bntHappy);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "TelaEntrarColaborador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaEntrarColaborador";
            Load += TelaEntrarColaborador_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Button bntHappy;
        private Button btnBad;
        private Label label2;
        private Label label3;
        private Button btnAcessarTeste;
    }
}