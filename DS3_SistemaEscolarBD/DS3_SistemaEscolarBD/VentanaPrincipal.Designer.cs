namespace DS3_SistemaEscolarBD
{
    partial class VentanaPrincipal
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
            btnMateria = new Button();
            btnAula = new Button();
            btnAcademico = new Button();
            btnAlumno = new Button();
            btnCarrera = new Button();
            btnCiudad = new Button();
            btnEstado = new Button();
            btnPais = new Button();
            btnEstatus = new Button();
            label1 = new Label();
            label2 = new Label();
            btnSalir = new Button();
            label3 = new Label();
            btnReinscripción = new Button();
            btnGrupo = new Button();
            SuspendLayout();
            // 
            // btnMateria
            // 
            btnMateria.Location = new Point(12, 75);
            btnMateria.Name = "btnMateria";
            btnMateria.Size = new Size(94, 29);
            btnMateria.TabIndex = 2;
            btnMateria.Text = "Materia";
            btnMateria.UseVisualStyleBackColor = true;
            btnMateria.Click += btnMateria_Click;
            // 
            // btnAula
            // 
            btnAula.Location = new Point(12, 110);
            btnAula.Name = "btnAula";
            btnAula.Size = new Size(94, 29);
            btnAula.TabIndex = 3;
            btnAula.Text = "Aula";
            btnAula.UseVisualStyleBackColor = true;
            // 
            // btnAcademico
            // 
            btnAcademico.Location = new Point(12, 145);
            btnAcademico.Name = "btnAcademico";
            btnAcademico.Size = new Size(94, 29);
            btnAcademico.TabIndex = 4;
            btnAcademico.Text = "Academico";
            btnAcademico.UseVisualStyleBackColor = true;
            // 
            // btnAlumno
            // 
            btnAlumno.Location = new Point(12, 180);
            btnAlumno.Name = "btnAlumno";
            btnAlumno.Size = new Size(94, 29);
            btnAlumno.TabIndex = 5;
            btnAlumno.Text = "Alumno";
            btnAlumno.UseVisualStyleBackColor = true;
            // 
            // btnCarrera
            // 
            btnCarrera.Location = new Point(12, 215);
            btnCarrera.Name = "btnCarrera";
            btnCarrera.Size = new Size(94, 29);
            btnCarrera.TabIndex = 6;
            btnCarrera.Text = "Carrera";
            btnCarrera.UseVisualStyleBackColor = true;
            // 
            // btnCiudad
            // 
            btnCiudad.Location = new Point(112, 75);
            btnCiudad.Name = "btnCiudad";
            btnCiudad.Size = new Size(94, 29);
            btnCiudad.TabIndex = 7;
            btnCiudad.Text = "Ciudad";
            btnCiudad.UseVisualStyleBackColor = true;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(112, 110);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(94, 29);
            btnEstado.TabIndex = 8;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            // 
            // btnPais
            // 
            btnPais.Location = new Point(112, 145);
            btnPais.Name = "btnPais";
            btnPais.Size = new Size(94, 29);
            btnPais.TabIndex = 9;
            btnPais.Text = "Pais";
            btnPais.UseVisualStyleBackColor = true;
            // 
            // btnEstatus
            // 
            btnEstatus.Location = new Point(112, 180);
            btnEstatus.Name = "btnEstatus";
            btnEstatus.Size = new Size(94, 29);
            btnEstatus.TabIndex = 10;
            btnEstatus.Text = "Estatus";
            btnEstatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 11;
            label1.Text = "SELECCIONE LA TABLA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 12;
            label2.Text = "CATÁLOGO";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(341, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 52);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 17;
            label3.Text = "TABLAS";
            // 
            // btnReinscripción
            // 
            btnReinscripción.Location = new Point(251, 110);
            btnReinscripción.Name = "btnReinscripción";
            btnReinscripción.Size = new Size(105, 29);
            btnReinscripción.TabIndex = 15;
            btnReinscripción.Text = "Reinscripcion";
            btnReinscripción.UseVisualStyleBackColor = true;
            // 
            // btnGrupo
            // 
            btnGrupo.Location = new Point(251, 75);
            btnGrupo.Name = "btnGrupo";
            btnGrupo.Size = new Size(94, 29);
            btnGrupo.TabIndex = 14;
            btnGrupo.Text = "Grupo";
            btnGrupo.UseVisualStyleBackColor = true;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 287);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(btnReinscripción);
            Controls.Add(btnGrupo);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEstatus);
            Controls.Add(btnPais);
            Controls.Add(btnEstado);
            Controls.Add(btnCiudad);
            Controls.Add(btnCarrera);
            Controls.Add(btnAlumno);
            Controls.Add(btnAcademico);
            Controls.Add(btnAula);
            Controls.Add(btnMateria);
            Name = "VentanaPrincipal";
            Text = "Ventana Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMateria;
        private Button btnAula;
        private Button btnAcademico;
        private Button btnAlumno;
        private Button btnCarrera;
        private Button btnCiudad;
        private Button btnEstado;
        private Button btnPais;
        private Button btnEstatus;
        private Label label1;
        private Label label2;
        private Button btnSalir;
        private Label label3;
        private Button btnReinscripción;
        private Button btnGrupo;
    }
}
