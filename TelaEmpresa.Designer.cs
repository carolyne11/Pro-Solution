namespace Pro_Solution
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
            btnCarregar.Location = new Point(500, 543);
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
            cmbPalavra.Location = new Point(883, 501);
            cmbPalavra.Name = "cmbPalavra";
            cmbPalavra.Size = new Size(198, 23);
            cmbPalavra.TabIndex = 3;
            cmbPalavra.SelectedIndexChanged += cmbPalavra_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(941, 543);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "CONTAGEM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaEmpresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 634);
            Controls.Add(button1);
            Controls.Add(cmbPalavra);
            Controls.Add(btnCarregar);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "TelaEmpresa";
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
    }
}