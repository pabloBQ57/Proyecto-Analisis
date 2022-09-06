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


namespace Presentación.MedicoGeneral
{
    public partial class MainMenuDoctor : Form
    {
        public MainMenuDoctor()
        {
            InitializeComponent();
        }


        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
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








        private void btngenerarficha_Click(object sender, EventArgs e)
        {
            AbrirFormulario<GenerarFicha>();
        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuDoctor_Load(object sender, EventArgs e)
        {
            LoadUserDate();
        }


        private void LoadUserDate()
        {
            lblemail.Text = UserloginCache.username;
            lblrol.Text = UserloginCache.rol;
        }

        private void btnverficha_Click(object sender, EventArgs e)
        {
            AbrirFormulario<VerFicha>();
        }

        private void btnasignarenfermero_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AsignarEnfermero>();
        }

        private void btnasignarespecialista_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AsignarEspecialista>();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncrearpaciente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CrearPaciente>();
        }
    }
}
