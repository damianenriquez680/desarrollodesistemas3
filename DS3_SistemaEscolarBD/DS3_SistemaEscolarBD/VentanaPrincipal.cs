using DS3_SistemaEscolarBD.Catalogo;
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
            Catalogo.Materia Materia = new Catalogo.Materia();
            Materia.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
