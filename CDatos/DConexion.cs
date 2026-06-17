using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CDatos
{
    public class DConexion
    {
        private SqlConnection conexion = new SqlConnection("Server=.;Database=Boletos;Trusted_Connection=True;TrustServerCertificate=True");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed) conexion.Open();

            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open) conexion.Close();

            return conexion;
        }
    }
}
