using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD
{
    public partial class Splashscreen : Form
    {
        private int progressValue = 0;
        private const int totalTime = 5000; 
        private const int timerInterval = 40;
public Splashscreen()
        {
            InitializeComponent();
            ConfigureProgressBar();
            CenterPercentageLabel(); 
        }

        private void ConfigureProgressBar()
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }

        private void CenterPercentageLabel()
        {
          
            if (progressBar1 != null && labelPorcentaje != null)
            {
                int x = progressBar1.Left + (progressBar1.Width - labelPorcentaje.Width) / 2;
                int y = progressBar1.Top + (progressBar1.Height - labelPorcentaje.Height) / 2;
                labelPorcentaje.Location = new Point(x, y);
            }
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            timer1.Interval = timerInterval;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            progressValue++;
            int progressPercentage = (int)((float)progressValue / (totalTime / timerInterval) * 100);

            if (progressPercentage > 100)
                progressPercentage = 100;


            progressBar1.Value = progressPercentage;

       
            labelPorcentaje.Text = $"{progressPercentage}%";
            CenterPercentageLabel();
            if (progressPercentage >= 100)
            {
                timer1.Stop();
                System.Threading.Thread.Sleep(300);

                this.Hide();
                VentanaPrincipal principal = new VentanaPrincipal();
                principal.ShowDialog();
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void progressBar1_Click(object sender, EventArgs e) { }
    }
}