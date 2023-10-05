namespace ProyectoFisicaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            hsbFuerzaInicial = new HScrollBar();
            hsbMasa = new HScrollBar();
            label3 = new Label();
            hsbPosicion = new HScrollBar();
            hsbAngulo = new HScrollBar();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            vsbPosicion = new VScrollBar();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 246, 220);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 358);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(803, 260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(68, 69, 75);
            label1.Location = new Point(359, 9);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 1;
            label1.Text = "Atinale al Exon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(68, 69, 75);
            label2.Location = new Point(12, 428);
            label2.Name = "label2";
            label2.Size = new Size(170, 37);
            label2.TabIndex = 2;
            label2.Text = "Fuerza inicial";
            // 
            // hsbFuerzaInicial
            // 
            hsbFuerzaInicial.Cursor = Cursors.Hand;
            hsbFuerzaInicial.Location = new Point(12, 465);
            hsbFuerzaInicial.Maximum = 1009;
            hsbFuerzaInicial.Minimum = 1;
            hsbFuerzaInicial.Name = "hsbFuerzaInicial";
            hsbFuerzaInicial.Size = new Size(240, 41);
            hsbFuerzaInicial.TabIndex = 4;
            hsbFuerzaInicial.Value = 1;
            hsbFuerzaInicial.Scroll += hsbFuerzaInicial_Scroll;
            // 
            // hsbMasa
            // 
            hsbMasa.Cursor = Cursors.Hand;
            hsbMasa.LargeChange = 1;
            hsbMasa.Location = new Point(12, 543);
            hsbMasa.Maximum = 10;
            hsbMasa.Minimum = 1;
            hsbMasa.Name = "hsbMasa";
            hsbMasa.Size = new Size(240, 41);
            hsbMasa.TabIndex = 6;
            hsbMasa.Value = 1;
            hsbMasa.Scroll += hsbMasa_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(68, 69, 75);
            label3.Location = new Point(12, 506);
            label3.Name = "label3";
            label3.Size = new Size(201, 37);
            label3.TabIndex = 5;
            label3.Text = "Peso del objeto";
            // 
            // hsbPosicion
            // 
            hsbPosicion.Cursor = Cursors.Hand;
            hsbPosicion.Location = new Point(396, 417);
            hsbPosicion.Maximum = 800;
            hsbPosicion.Minimum = 384;
            hsbPosicion.Name = "hsbPosicion";
            hsbPosicion.Size = new Size(517, 41);
            hsbPosicion.TabIndex = 10;
            hsbPosicion.Value = 800;
            hsbPosicion.Scroll += hScrollBar3_Scroll;
            // 
            // hsbAngulo
            // 
            hsbAngulo.Cursor = Cursors.Hand;
            hsbAngulo.Location = new Point(12, 622);
            hsbAngulo.Maximum = 99;
            hsbAngulo.Name = "hsbAngulo";
            hsbAngulo.Size = new Size(240, 41);
            hsbAngulo.TabIndex = 8;
            hsbAngulo.Scroll += hScrollBar4_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(68, 69, 75);
            label5.Location = new Point(12, 585);
            label5.Name = "label5";
            label5.Size = new Size(188, 37);
            label5.TabIndex = 7;
            label5.Text = "Angulo de tiro";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(172, 255, 198);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(663, 612);
            button1.Name = "button1";
            button1.Size = new Size(122, 54);
            button1.TabIndex = 11;
            button1.Text = "Lanzar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 172, 198);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(791, 612);
            button2.Name = "button2";
            button2.Size = new Size(122, 54);
            button2.TabIndex = 11;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // vsbPosicion
            // 
            vsbPosicion.Location = new Point(916, 56);
            vsbPosicion.Maximum = 260;
            vsbPosicion.Minimum = 3;
            vsbPosicion.Name = "vsbPosicion";
            vsbPosicion.Size = new Size(46, 355);
            vsbPosicion.TabIndex = 12;
            vsbPosicion.Value = 260;
            vsbPosicion.Scroll += vScrollBar1_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 465);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 13;
            label4.Text = "Puntos: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 198, 172);
            ClientSize = new Size(971, 678);
            Controls.Add(label4);
            Controls.Add(vsbPosicion);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hsbPosicion);
            Controls.Add(hsbAngulo);
            Controls.Add(label5);
            Controls.Add(hsbMasa);
            Controls.Add(label3);
            Controls.Add(hsbFuerzaInicial);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Atinale al Exon";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private HScrollBar hsbFuerzaInicial;
        private HScrollBar hsbMasa;
        private Label label3;
        private HScrollBar hsbPosicion;
        private HScrollBar hsbAngulo;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private VScrollBar vsbPosicion;
        private Label label4;
    }
}