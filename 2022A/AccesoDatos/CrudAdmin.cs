using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class CrudAdmin : Conexion
    {
        DataTable tabla = new DataTable();
        public void IngresoInventario(string nombre, int precio, int cantidad, string descripcion)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = connection;
                    Command.CommandText = "Sp_InsertarInventario";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@nombre", nombre);
                    Command.Parameters.AddWithValue("@precio", precio);
                    Command.Parameters.AddWithValue("@cantidad", cantidad);
                    Command.Parameters.AddWithValue("@descripcion", descripcion);
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }

        }

        public DataTable Mostrar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = connection;
                    Command.CommandText = "select * from inventario";
                    Command.CommandType = CommandType.Text;
                    SqlDataReader reader = Command.ExecuteReader();
                    tabla.Load(reader);

                    return tabla;
                }
            }
        }

        public void IngresoEmpleado(string nombre, string apellido, string direccion, string dpi, string username, string password, string rol)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = connection;
                    Command.CommandText = "Sp_IngresarEmpleado";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@nombre", nombre);
                    Command.Parameters.AddWithValue("@apellido", apellido );
                    Command.Parameters.AddWithValue("@direccion", direccion );
                    Command.Parameters.AddWithValue("@dpi",dpi );
                    Command.Parameters.AddWithValue("@username", username );
                    Command.Parameters.AddWithValue("@password",password );
                    Command.Parameters.AddWithValue("@rol",rol);
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();
                }
            }
        }


        public DataTable MostrarEmpleados()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = connection;
                    Command.CommandText = "Sp_BuscarUsuario";
                    Command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = Command.ExecuteReader();
                    tabla.Load(reader);

                    return tabla;
                }
            }
        }

    }
}
