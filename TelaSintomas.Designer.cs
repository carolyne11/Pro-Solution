namespace Pro_Solution
{
    partial class TelaSintomas
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
            cmbSintoma1 = new ComboBox();
            cmbSintoma2 = new ComboBox();
            cmbSintoma3 = new ComboBox();
            button1 = new Button();
            lblResultado = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 112);
            label1.Name = "label1";
            label1.Size = new Size(271, 17);
            label1.TabIndex = 0;
            label1.Text = "Você se sente nervoso(a) frequentemente?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(262, 218);
            label2.Name = "label2";
            label2.Size = new Size(221, 17);
            label2.TabIndex = 1;
            label2.Text = "Você tem dificuldade para relaxar?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 306);
            label3.Name = "label3";
            label3.Size = new Size(312, 17);
            label3.TabIndex = 2;
            label3.Text = "Você se sente sobrecarregado(a) com frequência?";
            // 
            // cmbSintoma1
            // 
            cmbSintoma1.FormattingEnabled = true;
            cmbSintoma1.Location = new Point(284, 164);
            cmbSintoma1.Name = "cmbSintoma1";
            cmbSintoma1.Size = new Size(152, 23);
            cmbSintoma1.TabIndex = 3;
            // 
            // cmbSintoma2
            // 
            cmbSintoma2.FormattingEnabled = true;
            cmbSintoma2.Location = new Point(284, 254);
            cmbSintoma2.Name = "cmbSintoma2";
            cmbSintoma2.Size = new Size(152, 23);
            cmbSintoma2.TabIndex = 4;
            // 
            // cmbSintoma3
            // 
            cmbSintoma3.FormattingEnabled = true;
            cmbSintoma3.Location = new Point(284, 346);
            cmbSintoma3.Name = "cmbSintoma3";
            cmbSintoma3.Size = new Size(152, 23);
            cmbSintoma3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(510, 367);
            button1.Name = "button1";
            button1.Size = new Size(95, 42);
            button1.TabIndex = 6;
            button1.Text = "Verificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(311, 407);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(21, 20);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "   ";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources._12;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(798, 570);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 467);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 9;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TelaSintomas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 570);
            Controls.Add(button2);
            Controls.Add(lblResultado);
            Controls.Add(button1);
            Controls.Add(cmbSintoma3);
            Controls.Add(cmbSintoma2);
            Controls.Add(cmbSintoma1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "TelaSintomas";
            Text = "TelaSintomas";
            Load += TelaSintomas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbSintoma1;
        private ComboBox cmbSintoma2;
        private ComboBox cmbSintoma3;
        private Button button1;
        private Label lblResultado;
        private PictureBox pictureBox1;
        private Button button2;
    }
}