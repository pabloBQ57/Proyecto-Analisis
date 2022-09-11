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

    public partial class Inventario : Form
    {
        CrudAdminDominio crudAdminDominio = new CrudAdminDominio();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            MostrarInvent();
            alternar(dataGridView1);
            
            
        }

        private void MostrarInvent()
        {
            CrudAdminDominio crudAdminDominio = new CrudAdminDominio();
            dataGridView1.DataSource = crudAdminDominio.MostrarInventario();

        }

        public void alternar(DataGridView dvg)
        {
            dvg.RowsDefaultCellStyle.BackColor = Color.Black;
            dvg.AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray;
        }
        

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                crudAdminDominio.IngresoInventario(txtnombre.Text, txtprecio.Text, txtcantidad.Text , txtdescripcion.Text);
                MessageBox.Show("Se ingreso correctamente");
                limpiar();
            }
            catch
            {
                MessageBox.Show("No se pudo ingresar los datos");
            }
        }



        private void limpiar()
        {
            txtnombre.Clear();
            txtprecio.Clear();
            txtcantidad.Clear();
            txtdescripcion.Clear();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            MostrarInvent();
        }
    }
}
