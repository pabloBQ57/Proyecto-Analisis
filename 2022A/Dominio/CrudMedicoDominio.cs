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
    public class CrudMedicoDominio
    {
        CrudMedico crudMedico = new CrudMedico();

        public void IngresarPaciente(string nombre, string apellido, string direccion, string dpi, string motivo_visita, string examen_laboratorio, string resultados, string diagnostico, string medicina, string cantidad, string tiempo_aplicacion, string total, string observaciones, string correo_encargado)
        {
            crudMedico.IngresarPaciente(nombre, apellido, direccion, dpi, motivo_visita, examen_laboratorio, resultados, diagnostico, medicina, Convert.ToInt32(cantidad), tiempo_aplicacion, Convert.ToInt32(total), observaciones, correo_encargado);
        }



        public DataTable MostrarFicha()
        {
            DataTable tabla = new DataTable();
            tabla = crudMedico.MostrarFicha();
            return tabla;

        }
    }

}