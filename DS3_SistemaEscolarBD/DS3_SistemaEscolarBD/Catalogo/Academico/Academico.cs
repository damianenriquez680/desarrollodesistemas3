using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo
{
    public partial class Academico : Form
    {
        public Academico()
        {
            InitializeComponent();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            string txtConsulta = "SELECT * FROM [DS3_Catalogos].[dbo].[Academico]";
            dgvDatosAcademico.DataSource = conexion.ObtieneDatosBDCatalogo(txtConsulta);
        }
    }
}
