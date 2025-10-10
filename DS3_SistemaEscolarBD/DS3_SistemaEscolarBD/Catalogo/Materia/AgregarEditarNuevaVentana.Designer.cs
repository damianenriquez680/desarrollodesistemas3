namespace DS3_SistemaEscolarBD.Catalogo.Materia
{
    partial class AgregarEditarNuevaVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEditarNuevaVentana));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIDMateria = new TextBox();
            txtNombreMateria = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            nCreditos = new NumericUpDown();
            toolStrip1 = new ToolStrip();
            btnGuardar = new ToolStripButton();
            Cancelar = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)nCreditos).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 51);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "ID Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 94);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre Materia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 138);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Creditos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 187);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha Hora Creacion:";
            // 
            // txtIDMateria
            // 
            txtIDMateria.Location = new Point(196, 49);
            txtIDMateria.Name = "txtIDMateria";
            txtIDMateria.ReadOnly = true;
            txtIDMateria.Size = new Size(147, 27);
            txtIDMateria.TabIndex = 4;
            // 
            // txtNombreMateria
            // 
            txtNombreMateria.Location = new Point(196, 91);
            txtNombreMateria.Name = "txtNombreMateria";
            txtNombreMateria.Size = new Size(229, 27);
            txtNombreMateria.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleRole = AccessibleRole.ScrollBar;
            dateTimePicker1.Location = new Point(196, 187);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // nCreditos
            // 
            nCreditos.Location = new Point(196, 138);
            nCreditos.Name = "nCreditos";
            nCreditos.Size = new Size(150, 27);
            nCreditos.TabIndex = 7;
            nCreditos.ThousandsSeparator = true;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnGuardar, Cancelar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(545, 27);
            toolStrip1.TabIndex = 8;
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
            // AgregarEditarNuevaVentana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 258);
            Controls.Add(toolStrip1);
            Controls.Add(nCreditos);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNombreMateria);
            Controls.Add(txtIDMateria);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarEditarNuevaVentana";
            Text = "AgregarEditarNuevaVentana";
            ((System.ComponentModel.ISupportInitialize)nCreditos).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIDMateria;
        private TextBox txtNombreMateria;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown nCreditos;
        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton Cancelar;
    }
}