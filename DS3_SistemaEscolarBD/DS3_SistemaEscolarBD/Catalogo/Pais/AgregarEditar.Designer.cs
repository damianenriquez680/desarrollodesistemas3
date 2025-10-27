namespace DS3_SistemaEscolarBD.Catalogo.Pais
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
            toolStrip1 = new ToolStrip();
            btnGuardar = new ToolStripButton();
            Cancelar = new ToolStripButton();
<<<<<<< HEAD
            txtSiglasPais = new TextBox();
            txtNomPais = new TextBox();
            lblSiglasPais = new Label();
            lblNomPais = new Label();
=======
            lblNomPais = new Label();
            lbIdPais = new Label();
            lblSiglasPais = new Label();
            lblFechaHoraCreacion = new Label();
            txtIdPais = new TextBox();
            txtNomPais = new TextBox();
            txtSiglasPais = new TextBox();
            dtpPais = new DateTimePicker();
>>>>>>> 203f46e84a15e22024fe3f5effa139c108f0858b
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.GripMargin = new Padding(6, 2, 2, 2);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGuardar, Cancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
<<<<<<< HEAD
            toolStrip1.Size = new Size(349, 27);
=======
            toolStrip1.Size = new Size(700, 27);
>>>>>>> 203f46e84a15e22024fe3f5effa139c108f0858b
            toolStrip1.TabIndex = 36;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.guardar;
            btnGuardar.ImageTransparentColor = Color.Magenta;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(73, 24);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Image = Properties.Resources.Cancelar;
            Cancelar.ImageTransparentColor = Color.Magenta;
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(77, 24);
            Cancelar.Text = "Cancelar";
            Cancelar.Click += Cancelar_Click;
            // 
            // txtSiglasPais
            // 
            txtSiglasPais.BackColor = Color.FromArgb(255, 255, 192);
            txtSiglasPais.Location = new Point(139, 119);
            txtSiglasPais.Margin = new Padding(3, 4, 3, 4);
            txtSiglasPais.Name = "txtSiglasPais";
            txtSiglasPais.Size = new Size(164, 27);
            txtSiglasPais.TabIndex = 51;
            // 
            // txtNomPais
            // 
            txtNomPais.BackColor = Color.FromArgb(255, 255, 192);
            txtNomPais.Location = new Point(139, 74);
            txtNomPais.Margin = new Padding(3, 4, 3, 4);
            txtNomPais.Name = "txtNomPais";
            txtNomPais.Size = new Size(164, 27);
            txtNomPais.TabIndex = 50;
            // 
            // lblSiglasPais
            // 
            lblSiglasPais.AutoSize = true;
            lblSiglasPais.BackColor = Color.FromArgb(255, 255, 192);
            lblSiglasPais.Location = new Point(30, 122);
            lblSiglasPais.Name = "lblSiglasPais";
            lblSiglasPais.Size = new Size(103, 20);
            lblSiglasPais.TabIndex = 48;
            lblSiglasPais.Text = "Siglas de pais:";
            // 
            // lblNomPais
            // 
            lblNomPais.AutoSize = true;
            lblNomPais.BackColor = Color.FromArgb(255, 255, 192);
            lblNomPais.Location = new Point(37, 77);
            lblNomPais.Name = "lblNomPais";
            lblNomPais.Size = new Size(96, 20);
            lblNomPais.TabIndex = 46;
            lblNomPais.Text = "Nombre Pais:";
            // 
            // lblNomPais
            // 
            lblNomPais.AutoSize = true;
            lblNomPais.Location = new Point(75, 71);
            lblNomPais.Name = "lblNomPais";
            lblNomPais.Size = new Size(78, 15);
            lblNomPais.TabIndex = 37;
            lblNomPais.Text = "Nombre Pais:";
            // 
            // lbIdPais
            // 
            lbIdPais.AutoSize = true;
            lbIdPais.Location = new Point(109, 42);
            lbIdPais.Name = "lbIdPais";
            lbIdPais.Size = new Size(44, 15);
            lbIdPais.TabIndex = 38;
            lbIdPais.Text = "Id Pais:";
            // 
            // lblSiglasPais
            // 
            lblSiglasPais.AutoSize = true;
            lblSiglasPais.Location = new Point(73, 100);
            lblSiglasPais.Name = "lblSiglasPais";
            lblSiglasPais.Size = new Size(80, 15);
            lblSiglasPais.TabIndex = 39;
            lblSiglasPais.Text = "Siglas de pais:";
            // 
            // lblFechaHoraCreacion
            // 
            lblFechaHoraCreacion.AutoSize = true;
            lblFechaHoraCreacion.Location = new Point(33, 129);
            lblFechaHoraCreacion.Name = "lblFechaHoraCreacion";
            lblFechaHoraCreacion.Size = new Size(120, 15);
            lblFechaHoraCreacion.TabIndex = 40;
            lblFechaHoraCreacion.Text = "Fecha Hora Creacion:";
            // 
            // txtIdPais
            // 
            txtIdPais.Enabled = false;
            txtIdPais.Location = new Point(159, 39);
            txtIdPais.Name = "txtIdPais";
            txtIdPais.Size = new Size(100, 23);
            txtIdPais.TabIndex = 41;
            // 
            // txtNomPais
            // 
            txtNomPais.Location = new Point(159, 68);
            txtNomPais.Name = "txtNomPais";
            txtNomPais.Size = new Size(100, 23);
            txtNomPais.TabIndex = 42;
            // 
            // txtSiglasPais
            // 
            txtSiglasPais.Location = new Point(159, 97);
            txtSiglasPais.Name = "txtSiglasPais";
            txtSiglasPais.Size = new Size(100, 23);
            txtSiglasPais.TabIndex = 44;
            // 
            // dtpPais
            // 
            dtpPais.Enabled = false;
            dtpPais.Location = new Point(159, 126);
            dtpPais.Name = "dtpPais";
            dtpPais.Size = new Size(200, 23);
            dtpPais.TabIndex = 45;
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackgroundImage = Properties.Resources.agregareditar2;
            ClientSize = new Size(349, 205);
            ControlBox = false;
            Controls.Add(txtSiglasPais);
            Controls.Add(txtNomPais);
            Controls.Add(lblSiglasPais);
            Controls.Add(lblNomPais);
            Controls.Add(toolStrip1);
            MaximumSize = new Size(367, 252);
            MinimumSize = new Size(367, 252);
            Name = "AgregarEditar";
            Text = "Agregar y Editar";
=======
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(dtpPais);
            Controls.Add(txtSiglasPais);
            Controls.Add(txtNomPais);
            Controls.Add(txtIdPais);
            Controls.Add(lblFechaHoraCreacion);
            Controls.Add(lblSiglasPais);
            Controls.Add(lbIdPais);
            Controls.Add(lblNomPais);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarEditar";
            Text = "AgregarEditar";
            Load += AgregarEditar_Load;
>>>>>>> 203f46e84a15e22024fe3f5effa139c108f0858b
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton Cancelar;
<<<<<<< HEAD
        private TextBox txtSiglasPais;
        private TextBox txtNomPais;
        private Label lblSiglasPais;
        private Label lblNomPais;
=======
        private Label lblNomPais;
        private Label lbIdPais;
        private Label lblSiglasPais;
        private Label lblFechaHoraCreacion;
        private TextBox txtIdPais;
        private TextBox txtNomPais;
        private TextBox txtSiglasPais;
        private DateTimePicker dtpPais;
>>>>>>> 203f46e84a15e22024fe3f5effa139c108f0858b
    }
}