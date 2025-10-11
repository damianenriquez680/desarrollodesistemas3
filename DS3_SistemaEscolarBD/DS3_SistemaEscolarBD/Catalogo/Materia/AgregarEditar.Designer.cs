namespace DS3_SistemaEscolarBD.Catalogo.Materia
{
    partial class AgregarEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEditar));
            toolStrip1 = new ToolStrip();
            btnGuardar = new ToolStripButton();
            Cancelar = new ToolStripButton();
            nCreditos = new NumericUpDown();
            dtpFechaHora = new DateTimePicker();
            txtNombreMateria = new TextBox();
            txtIDMateria = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nCreditos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGuardar, Cancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(546, 27);
            toolStrip1.TabIndex = 35;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageTransparentColor = Color.Magenta;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 24);
            btnGuardar.Text = "Guardar";
            // 
            // Cancelar
            // 
            Cancelar.Image = (Image)resources.GetObject("Cancelar.Image");
            Cancelar.ImageTransparentColor = Color.Magenta;
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(90, 24);
            Cancelar.Text = "Cancelar";
            // 
            // nCreditos
            // 
            nCreditos.Location = new Point(201, 135);
            nCreditos.Name = "nCreditos";
            nCreditos.Size = new Size(150, 27);
            nCreditos.TabIndex = 34;
            nCreditos.ThousandsSeparator = true;
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.AccessibleRole = AccessibleRole.ScrollBar;
            dtpFechaHora.Location = new Point(201, 184);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(312, 27);
            dtpFechaHora.TabIndex = 33;
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(201, 88);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(229, 27);
            txtNombreMateria.TabIndex = 32;
            // 
            // txtIDMateria
            // 
            txtIDMateria.Location = new Point(201, 46);
            txtIDMateria.Name = "txtIDMateria";
            txtIDMateria.ReadOnly = true;
            txtIDMateria.Size = new Size(147, 27);
            txtIDMateria.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 184);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 30;
            label4.Text = "Fecha Hora Creacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(103, 135);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 29;
            label5.Text = "Creditos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 91);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 28;
            label6.Text = "Nombre Materia:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 48);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 27;
            label7.Text = "ID Materia:";
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 242);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(nCreditos);
            Controls.Add(dtpFechaHora);
            Controls.Add(txtNombreMateria);
            Controls.Add(txtIDMateria);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Name = "AgregarEditar";
            Text = "AgregarEditar";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nCreditos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton Cancelar;
        private NumericUpDown nCreditos;
        private DateTimePicker dtpFechaHora;
        private TextBox txtNombreMateria;
        private TextBox txtIDMateria;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}