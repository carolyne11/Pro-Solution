﻿namespace Pro_Solution
{
    partial class TelaEmpresa
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            btnCarregar = new Button();
            cmbPalavra = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            btnResetar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1150, 365);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1150, 634);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnCarregar
            // 
            btnCarregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarregar.Location = new Point(477, 579);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(160, 43);
            btnCarregar.TabIndex = 2;
            btnCarregar.Text = "Carregar Dados";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // cmbPalavra
            // 
            cmbPalavra.FormattingEnabled = true;
            cmbPalavra.Location = new Point(940, 498);
            cmbPalavra.Name = "cmbPalavra";
            cmbPalavra.Size = new Size(198, 23);
            cmbPalavra.TabIndex = 3;
            cmbPalavra.SelectedIndexChanged += cmbPalavra_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(998, 536);
            button1.Name = "button1";
            button1.Size = new Size(106, 26);
            button1.TabIndex = 4;
            button1.Text = "CONTAGEM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 598);
            button2.Name = "button2";
            button2.Size = new Size(78, 36);
            button2.TabIndex = 5;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnResetar
            // 
            btnResetar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetar.Location = new Point(0, 498);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(186, 33);
            btnResetar.TabIndex = 6;
            btnResetar.Text = "Resetar Respostas";
            btnResetar.UseVisualStyleBackColor = true;
            btnResetar.Click += btnResetar_Click;
            // 
            // TelaEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 634);
            Controls.Add(btnResetar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbPalavra);
            Controls.Add(btnCarregar);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "TelaEmpresa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaEmpresa";
            Load += TelaEmpresa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button btnCarregar;
        private ComboBox cmbPalavra;
        private Button button1;
        private Button button2;
        private Button btnResetar;
    }
}