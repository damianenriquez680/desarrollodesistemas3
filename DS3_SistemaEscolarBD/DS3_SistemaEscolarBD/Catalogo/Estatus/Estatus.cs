using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_SistemaEscolarBD.Catalogo.Estatus
{
    public partial class Estatus : Form
    {
        public Estatus()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            string txtConsulta = "SELECT * FROM [DS3_Catalogos].[dbo].[Estatus]";
            dgvDatosEstatus.DataSource = conexion.ObtieneDatosBDCatalogo(txtConsulta);
        }
    }
}
