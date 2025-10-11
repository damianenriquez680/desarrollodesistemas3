namespace DS3_SistemaEscolarBD.Catalogo.Alumno
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
            txtEstatus = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            dtpFechaHora = new DateTimePicker();
            label4 = new Label();
            txtIDMateria = new TextBox();
            label7 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGuardar, Cancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(532, 27);
            toolStrip1.TabIndex = 36;
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
            // txtEstatus
            // 
            txtEstatus.Location = new Point(181, 189);
            txtEstatus.Name = "txtEstatus";
            txtEstatus.Size = new Size(147, 27);
            txtEstatus.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 192);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 55;
            label3.Text = "Estatus:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 141);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 53;
            label2.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 27);
            txtNombre.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 94);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 51;
            label1.Text = "Nombre:";
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.AccessibleRole = AccessibleRole.ScrollBar;
            dtpFechaHora.Location = new Point(181, 235);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(312, 27);
            dtpFechaHora.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 240);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 49;
            label4.Text = "Fecha Hora Creacion:";
            // 
            // txtIDMateria
            // 
            txtIDMateria.Location = new Point(181, 45);
            txtIDMateria.Name = "txtIDMateria";
            txtIDMateria.ReadOnly = true;
            txtIDMateria.Size = new Size(147, 27);
            txtIDMateria.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 48);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 47;
            label7.Text = "ID Materia:";
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 297);
            ControlBox = false;
            Controls.Add(txtEstatus);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dtpFechaHora);
            Controls.Add(label4);
            Controls.Add(txtIDMateria);
            Controls.Add(label7);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "AgregarEditar";
            Text = "AgregarEditar";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton Cancelar;
        private TextBox txtEstatus;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private DateTimePicker dtpFechaHora;
        private Label label4;
        private TextBox txtIDMateria;
        private Label label7;
    }
}