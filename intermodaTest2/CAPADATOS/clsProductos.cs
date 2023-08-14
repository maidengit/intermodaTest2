using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace intermodaTest2.CAPADATOS
{
    internal class clsProductos
    {
        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand comando = new SqlCommand(); //Esta clase se utiliza para enviar comandos SQL a una base de datos y ejecutarlos.
        private SqlDataReader leerFilas; //SqlDataReader: Se utiliza para recuperar y leer datos de una base de datos SQL Server.



        //Ahora vamos a convertir esto a objeto para aplicar los pilares de la POO
        //ATRIBUTOS
        private int id;
        private String codigo;
        private String nombre;
        private int ProductoTipoId;
        private int UnidadMedidaID;
        private int estado;
        
        //METODOS GET Y SET
        public int _Id { get => id; set => id = value; }
        public string _Codigo { get => codigo; set => codigo = value; }
        public string _Nombre { get => nombre; set => nombre = value; }
        public int _ProductoTipoId { get => ProductoTipoId; set => ProductoTipoId = value; }
        public int _UnidadMedidaID { get => UnidadMedidaID; set => UnidadMedidaID = value; }
        public int _Estado { get => estado; set => estado = value; }

        //



        public DataTable ListarTiposProductos() //Recupera los datod de la de productos desde la Base de Datos
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.abrirConexion();
                comando.CommandText = "ListarTiposProductos";
                comando.CommandType = CommandType.StoredProcedure;
                leerFilas = comando.ExecuteReader();
                tabla.Load(leerFilas);
                leerFilas.Close();
            Conexion.cerrarConexion();
            return tabla;
        }

        public DataTable ListarUnidadMedida() //Recupera los datos de unidad de medida desde la base de datos
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.abrirConexion();
            comando.CommandText = "ListarUnidadMedida";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            Conexion.cerrarConexion();
            return tabla;
        }
        

   
        //Rellenar datagridview
        public DataTable listarProductos() //Recupera los datos de productos desde la DB
        {
            DataTable tabla = new DataTable();
            comando.Connection = Conexion.abrirConexion();
            comando.CommandText = "ListarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            Conexion.cerrarConexion();
            return tabla;
        }
        //********************************
        //***Procedimientos del CRUD******
        //********************************
        //AGREGAR
        public void insertarProducto()
        {
            comando.Connection = Conexion.abrirConexion();
            comando.CommandText = "InsertarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo", codigo);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@ProductoTipoId ", _ProductoTipoId);
            comando.Parameters.AddWithValue("@UnidadMedidaID", _UnidadMedidaID);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //EDITAR

        public void editarProducto()
        {
            comando.Connection = Conexion.abrirConexion();
            comando.CommandText = "UPDATE Producto SET Codigo = '" + codigo + "', Nombre = '" + nombre + "', ProductoTipoId = " + ProductoTipoId + ", UnidadMedidaID = " + UnidadMedidaID + ", Estado = '"+estado+"' where Id = " + id + "";
            comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
            Conexion.cerrarConexion();
        }

        //ELIMINAR
        public void eliminarProducto()
        {
            comando.Connection = Conexion.abrirConexion();
                comando.CommandText = "delete from Producto where Id = "+_Id+";";
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
            Conexion.cerrarConexion();
        }

        //RENOVAR
        public void renovarProducto()
        {
            comando.Connection = Conexion.abrirConexion();
                comando.CommandText = "update Producto set estado = 1 where id = "+_Id+";";
                comando.CommandType = CommandType.Text;
                comando.ExecuteNonQuery();
            Conexion.cerrarConexion();
        }
    }
}
