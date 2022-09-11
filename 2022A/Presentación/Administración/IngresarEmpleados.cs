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

namespace Presentación.Administración
{
    public partial class IngresarEmpleados : Form
    {
        CrudAdminDominio crudAdminDominio = new CrudAdminDominio();
        public IngresarEmpleados()
        {
            InitializeComponent();
        }

        private void IngresarEmpleados_Load(object sender, EventArgs e)
        {
            MostrarmisUsuarios();
            alternar(dataGridView1);

        }

        private void MostrarmisUsuarios()
        {
            CrudAdminDominio crudAdminDominio = new CrudAdminDominio();
            dataGridView1.DataSource = crudAdminDominio.MostrarUsuarios();
        }


        public void alternar(DataGridView dvg)
        {
            dvg.RowsDefaultCellStyle.BackColor = Color.Black;
            dvg.AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray;
        }


        private void limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtdireccion.Clear();
            txtdpi.Clear();
            txtuser.Clear();
            txtpass.Clear();
           // txtrol.Clear();
        }

        private void btningresarempleados_Click(object sender, EventArgs e)
        {

            try
            {
                crudAdminDominio.IngresoEmpleado(txtnombre.Text, txtapellido.Text, txtdireccion.Text, txtdpi.Text, txtuser.Text, txtpass.Text, comboBox1.Text);
                MessageBox.Show("Se ingreso correctamente");
                limpiar();
            }
            catch
            {
                MessageBox.Show("No se pudo ingresar los datos");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            MostrarmisUsuarios();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
