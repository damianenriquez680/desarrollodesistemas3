namespace DS3_SistemaEscolarBD
{
    partial class Splashscreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashscreen));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            labelPorcentaje = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tw Cen MT", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 0);
            label1.Location = new Point(55, 165);
            label1.Name = "label1";
            label1.Size = new Size(186, 35);
            label1.TabIndex = 1;
            label1.Text = "Sistema Escolar";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.White;
            progressBar1.Location = new Point(33, 305);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(268, 29);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 6000;
            timer1.Tick += timer1_Tick;
            // 
            // labelPorcentaje
            // 
            labelPorcentaje.AutoSize = true;
            labelPorcentaje.BackColor = Color.Gainsboro;
            labelPorcentaje.ForeColor = Color.Black;
            labelPorcentaje.Location = new Point(149, 305);
            labelPorcentaje.Name = "labelPorcentaje";
            labelPorcentaje.Size = new Size(29, 20);
            labelPorcentaje.TabIndex = 3;
            labelPorcentaje.Text = "0%";
            // 
            // Splashscreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(682, 501);
            Controls.Add(labelPorcentaje);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Splashscreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splashscreen";
            Load += Splashscreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label labelPorcentaje;
    }
}