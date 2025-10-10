using Microsoft.Data.SqlClient;
using System.Data;

namespace DS3_SistemaEscolarBD
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        { 
            DS3_SistemaEscolarBD.Catalogo.Materia Materia = new DS3_SistemaEscolarBD.Catalogo.Materia();
            Materia.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcademico_Click(object sender, EventArgs e)
        {
            DS3_SistemaEscolarBD.Catalogo.Academico Academico = new DS3_SistemaEscolarBD.Catalogo.Academico();
            Academico.ShowDialog();
        }
    }
}
