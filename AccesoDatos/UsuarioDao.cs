using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Comun.Cache;

namespace AccesoDatos
{
    public class UsuarioDao:Conexion
    {
        public bool login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = connection;
                    Command.CommandText = "select * from usuario where username= @user and password=@pass";
                    Command.Parameters.AddWithValue("@user", user);
                    Command.Parameters.AddWithValue("@pass", pass);
                    Command.CommandType = CommandType.Text;
                    SqlDataReader reader = Command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserloginCache.id = reader.GetInt32(0);
                            UserloginCache.username = reader.GetString(1);
                            UserloginCache.rol = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }

        }

        public void AnyMethod()
        {
            if (UserloginCache.rol == rol.Administrador)
            {

            }
            if (UserloginCache.rol == rol.Medico)
            {

            }
            if (UserloginCache.rol == rol.Enfermero)
            {

            }
            if (UserloginCache.rol == rol.Especialista)
            {

            }
            if(UserloginCache.rol == rol.Laboratorista)
            { 
            }
            if(UserloginCache.rol == rol.Farmaceutico) 
            {
            }
            if (UserloginCache.rol == rol.Cajero) 
            { 
            }

        }

        
    }
}
