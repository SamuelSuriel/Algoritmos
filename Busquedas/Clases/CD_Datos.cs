using Microsoft.Data.SqlClient;
using System.Data;

namespace Busquedas.Clases
{
    public class CD_Datos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public DataTable MostrarDatos(string clave)
        {
            CD_Conexion conexion = new CD_Conexion();
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "prc_MostrarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@clave", clave);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void InsertarDato(string clave, string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@nombreCompleto", nombre);
            comando.Parameters.AddWithValue("@activo", 1);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EditarDato(string clave, string nombre)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@nombreCompleto", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void EliminarDato(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDatos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
