using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun.Cache;

namespace Presentación.Administración
{
    public partial class MainMenuAdmin : Form
    {
        public MainMenuAdmin()
        {
            InitializeComponent();
        }

        private void MainMenuAdmin_Load(object sender, EventArgs e) { 


            LoadUserDate();
            
        }

        private void LoadUserDate()
        {
            lblemail.Text = UserloginCache.username;
            lblrol.Text = UserloginCache.rol;
        }
        



        //METODO PARA ABRIRIR FORMULARIOS
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
            if(formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }





        private void btnGastos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Gastos>();
        }

        private void btnIngresarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario<IngresarEmpleados>();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EliminarEmpleados>();
        }

        private void btnDonaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Donaciones>();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btninventario_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Inventario>();
        }
    }

}
