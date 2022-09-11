using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public  class Conexion
    {
        private readonly string ConexionString;
        public Conexion()
        {
            ConexionString = "Server= LAPTOP-CQAQ576A\\SQLEXPRESS; Database= Asilo; integrated Security = true";

        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConexionString);
        }
    }
}
