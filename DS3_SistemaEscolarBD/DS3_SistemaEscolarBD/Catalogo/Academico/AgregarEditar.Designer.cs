namespace DS3_SistemaEscolarBD.Catalogo.Academico
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
            txtIDMateria = new TextBox();
            label7 = new Label();
            dtpFechaHora = new DateTimePicker();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            txtNombre = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            txtGrado = new TextBox();
            label3 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGuardar, Cancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(520, 27);
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
            // txtIDMateria
            // 
            txtIDMateria.Location = new Point(176, 46);
            txtIDMateria.Name = "txtIDMateria";
            txtIDMateria.ReadOnly = true;
            txtIDMateria.Size = new Size(147, 27);
            txtIDMateria.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 49);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 37;
            label7.Text = "ID Materia:";
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.AccessibleRole = AccessibleRole.ScrollBar;
            dtpFechaHora.Location = new Point(176, 236);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(312, 27);
            dtpFechaHora.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 241);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 39;
            label4.Text = "Fecha Hora Creacion:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 95);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 41;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(176, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 27);
            txtNombre.TabIndex = 42;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 142);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 43;
            label2.Text = "Apellidos:";
            // 
            // txtGrado
            // 
            txtGrado.Location = new Point(176, 190);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(147, 27);
            txtGrado.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 193);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 45;
            label3.Text = "Grado:";
            // 
            // AgregarEditar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 297);
            ControlBox = false;
            Controls.Add(txtGrado);
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
        private TextBox txtIDMateria;
        private Label label7;
        private DateTimePicker dtpFechaHora;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private TextBox txtNombre;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtGrado;
        private Label label3;
    }
}