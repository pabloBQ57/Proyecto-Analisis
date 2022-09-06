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

namespace Presentación.Especialistas
{
    public partial class MainMenuEspecialista : Form
    {
        public MainMenuEspecialista()
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

        

        private void LoadUserDate()
        {
            lblemail.Text = UserloginCache.username;
            lblrol.Text = UserloginCache.rol;
        }


        
        private void MainMenuEspecialista_Load(object sender, EventArgs e)
        {
            LoadUserDate();
        }

        private void btnverficha_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<VerFicha>();
        }

        private void btncerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
