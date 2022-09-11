using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class CrudMedico:Conexion
    {
        DataTable tabla = new DataTable();

        public void IngresarPaciente(string nombre, string apellido, string direccion, string dpi, string motivo_visita, string examen_laboratorio, string resultados, string diagnostico, string medicina, int cantidad, string tiempo_aplicacion, int total, string observaciones, string correo_encargado)
        {
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var Command = new SqlCommand())
                {
                    Command.Connection = connection;
                    Command.CommandText = "Sp_IngresarPaciente";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@nombre",nombre);
                    Command.Parameters.AddWithValue("@apellido",apellido);
                    Command.Parameters.AddWithValue("@direccion",direccion);
                    Command.Parameters.AddWithValue("@dpi",dpi);
                    Command.Parameters.AddWithValue("@motivo_visita",motivo_visita);
                    Command.Parameters.AddWithValue("@examen_laboratorio",examen_laboratorio);
                    Command.Parameters.AddWithValue("@resultados",resultados);
                    Command.Parameters.AddWithValue("@diagnostico",diagnostico);
                    Command.Parameters.AddWithValue("@medicina",medicina);
                    Command.Parameters.AddWithValue("@cantidad",cantidad);
                    Command.Parameters.AddWithValue("@tiempo_aplicacion",tiempo_aplicacion);
                    Command.Parameters.AddWithValue("@total",total);
                    Command.Parameters.AddWithValue("@observaciones",observaciones);
                    Command.Parameters.AddWithValue("@correo_encargado",correo_encargado);
                    Command.ExecuteNonQuery();
                    Command.Parameters.Clear();

                }
            }
        }


        public DataTable MostrarFicha()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = connection;
                    Command.CommandText = "select * from fichamedica";
                    Command.CommandType = CommandType.Text;
                    SqlDataReader reader = Command.ExecuteReader();
                    tabla.Load(reader);

                    return tabla;
                }
            }
        }


    }
}
