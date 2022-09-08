using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentación.MedicoGeneral
{
    public partial class CrearPaciente : Form
    {
        CrudMedicoDominio crudMedicoDominio = new CrudMedicoDominio();
        public CrearPaciente()
        {
            InitializeComponent();
        }

        

        private void CrearPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                crudMedicoDominio.IngresarPaciente(txtnombre.Text, txtapellido.Text, txtdireccion.Text, txtdpi.Text, txtmotivovisita.Text, txtexamen.Text, txtresultados.Text, txtdiagnostico.Text, txtmedicina.Text, txtcantidad.Text, txttiempoaplicacion.Text, txttotal.Text, txtobservaciones.Text, txtcorreoencargado.Text);
                MessageBox.Show("Se ingreso correctamente");

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo ingresar los datos " + ex);
            }
        }
    }
}
