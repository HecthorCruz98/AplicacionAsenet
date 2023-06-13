using System.Data;
using System.Data.SqlClient;

namespace AplicacionAsenet.Models.DataBase
{
    public class ConexionDb
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-VQTGT9N\\SQLEXPRESS;DataBase= db_AppTalyCap;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
