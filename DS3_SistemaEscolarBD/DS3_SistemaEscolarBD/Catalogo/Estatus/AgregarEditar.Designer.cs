namespace DS3_SistemaEscolarBD.Catalogo.Estatus
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
            lblIdEstatus = new Label();
            lblClaveEstatus = new Label();
            lblNombreEstatus = new Label();
            lblUsuario = new Label();
            lblFechaHoraCreacion = new Label();
            txtIdEstatus = new TextBox();
            txtClaveEstatus = new TextBox();
            txtNombreEstatus = new TextBox();
            txtUsuario = new TextBox();
            dtpEstatus = new DateTimePicker();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGuardar, Cancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(700, 27);
            toolStrip1.TabIndex = 36;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageTransparentColor = Color.Magenta;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(73, 24);
            btnGuardar.Text = "Guardar";
            // 
            // Cancelar
            // 
            Cancelar.Image = (Image)resources.GetObject("Cancelar.Image");
            Cancelar.ImageTransparentColor = Color.Magenta;
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(77, 24);
            Cancelar.Text = "Cancelar";
            // 
            // lblIdEstatus
            // 
            lblIdEstatus.AutoSize = true;
            lblIdEstatus.Location = new Point(91, 41);
            lblIdEstatus.Name = "lblIdEstatus";
            lblIdEstatus.Size = new Size(60, 15);
            lblIdEstatus.TabIndex = 37;
            lblIdEstatus.Text = "Id Estatus:";
            // 
            // lblClaveEstatus
            // 
            lblClaveEstatus.AutoSize = true;
            lblClaveEstatus.Location = new Point(72, 70);
            lblClaveEstatus.Name = "lblClaveEstatus";
            lblClaveEstatus.Size = new Size(79, 15);
            lblClaveEstatus.TabIndex = 38;
            lblClaveEstatus.Text = "Clave estatus:";
            // 
            // lblNombreEstatus
            // 
            lblNombreEstatus.AutoSize = true;
            lblNombreEstatus.Location = new Point(60, 99);
            lblNombreEstatus.Name = "lblNombreEstatus";
            lblNombreEstatus.Size = new Size(94, 15);
            lblNombreEstatus.TabIndex = 39;
            lblNombreEstatus.Text = "Nombre estatus:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(99, 128);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 40;
            lblUsuario.Text = "Usuario:";
            // 
            // lblFechaHoraCreacion
            // 
            lblFechaHoraCreacion.AutoSize = true;
            lblFechaHoraCreacion.Location = new Point(31, 160);
            lblFechaHoraCreacion.Name = "lblFechaHoraCreacion";
            lblFechaHoraCreacion.Size = new Size(120, 15);
            lblFechaHoraCreacion.TabIndex = 41;
            lblFechaHoraCreacion.Text = "Fecha Hora Creacion:";
            // 
            // txtIdEstatus
            // 
            txtIdEstatus.Enabled = false;
            txtIdEstatus.Location = new Point(157, 38);
            txtIdEstatus.Name = "txtIdEstatus";
            txtIdEstatus.Size = new Size(100, 23);
            txtIdEstatus.TabIndex = 42;
            // 
            // txtClaveEstatus
            // 
            txtClaveEstatus.Location = new Point(157, 67);
            txtClaveEstatus.Name = "txtClaveEstatus";
            txtClaveEstatus.Size = new Size(100, 23);
            txtClaveEstatus.TabIndex = 43;
            // 
            // txtNombreEstatus
            // 
            txtNombreEstatus.Location = new Point(157, 96);
            txtNombreEstatus.Name = "txtNombreEstatus";
            txtNombreEstatus.Size = new Size(100, 23);
            txtNombreEstatus.TabIndex = 46;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(157, 125);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 44;
            // 
            // dtpEstatus
            // 
            dtpEstatus.Enabled = false;
            dtpEstatus.Location = new Point(157, 154);
            dtpEstatus.Name = "dtpEstatus";
            dtpEstatus.Size = new Size(200, 23);
            dtpEstatus.TabIndex = 47;
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            ControlBox = false;
            Controls.Add(dtpEstatus);
            Controls.Add(txtNombreEstatus);
            Controls.Add(txtUsuario);
            Controls.Add(txtClaveEstatus);
            Controls.Add(txtIdEstatus);
            Controls.Add(lblFechaHoraCreacion);
            Controls.Add(lblUsuario);
            Controls.Add(lblNombreEstatus);
            Controls.Add(lblClaveEstatus);
            Controls.Add(lblIdEstatus);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarEditar";
            Text = "AgregarEditar";
            Load += AgregarEditar_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton Cancelar;
        private Label lblIdEstatus;
        private Label lblClaveEstatus;
        private Label lblNombreEstatus;
        private Label lblUsuario; 
        private Label lblFechaHoraCreacion;
        private TextBox txtIdEstatus;
        private TextBox txtClaveEstatus;
        private TextBox txtNombreEstatus;
        private TextBox txtUsuario; 
        private DateTimePicker dtpEstatus;
    }
}