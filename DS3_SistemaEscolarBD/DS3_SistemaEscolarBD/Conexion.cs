using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3_SistemaEscolarBD
{
    public class ConexionBD
    {
        public string txtConexionCatalogo = "Server=DAMIAN_PC\\SQLEXPRESS; Database=DS3_Catalogos; Integrated Security=True; TrustServerCertificate=True";
        public string txtConexionTablas = "Server=DAMIAN_PC\\SQLEXPRESS; Database=DS3_Tablas; Integrated Security=True; TrustServerCertificate=True";

        public DataTable ObtieneDatosBDCatalogo(string txtConsulta)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(txtConexionCatalogo))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter ad = new SqlDataAdapter(txtConsulta, txtConexionCatalogo);
                    ad.Fill(dt); // Llenamos el DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción: " + ex.Message);
                }
            }
                
            return dt; // Regresamos el DataTable
        }
        public DataTable ObtieneDatosBDTablas(string txtConsulta)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conexion = new SqlConnection(txtConexionTablas))
            {
                try
                {
                    conexion.Open();
                    SqlDataAdapter ad = new SqlDataAdapter(txtConsulta, txtConexionTablas);
                    ad.Fill(dt); // Llenamos el DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Excepción: " + ex.Message);
                }
            }

            return dt; // Regresamos el DataTable
        }
    }
}
