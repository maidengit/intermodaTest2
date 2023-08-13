using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importamos librerias para poder acceder a la base de datos
using System.Data;
using System.Data.SqlClient;

namespace intermodaTest2.CAPADATOS
{
    internal class ConexionBD
    {
        //Declaramos una variable estatica tipo string para la cadena de conexion
        static private string cadenaConexion = "Server=DESKTOP-GES92U6; Database=intermoda_db; integrated security=true";
        //declaramos el objeto sql conexion como nueva uinstancia 
        private SqlConnection Conexion = new SqlConnection(cadenaConexion);

        //Creamos un metodo activo para abrir la conexion
        public SqlConnection abrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection cerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
