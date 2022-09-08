using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.SqlClient;
using AccesoDatos;


namespace Dominio
{
   public class CrudAdminDominio
    {
        CrudAdmin crudAdmin = new CrudAdmin();
        public void IngresoInventario(string nombre, string precio, string cantidad, string descripcion)
        {
            crudAdmin.IngresoInventario(nombre, Convert.ToInt32(precio),Convert.ToInt32(cantidad) , descripcion);
        }

        public DataTable MostrarInventario()
        {
            DataTable tabla = new DataTable();
            tabla = crudAdmin.Mostrar();
            return tabla;

        }

        public DataTable MostrarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = crudAdmin.MostrarEmpleados();
            return tabla;

        }

        public void IngresoEmpleado(string nombre, string apellido, string direccion, string dpi, string username, string password, string rol)
        {
            crudAdmin.IngresoEmpleado(nombre, apellido, direccion, dpi, username, password, rol);

        }
    }
}
