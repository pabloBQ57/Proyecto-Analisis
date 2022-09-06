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
using Dominio;

namespace Presentación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        




        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "") 
            {
                if (txtpass.Text != "") {
                    UsuarioDominio user = new UsuarioDominio();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        if (UserloginCache.rol == rol.Administrador)
                        {
                            Administración.MainMenuAdmin mainMenu = new Administración.MainMenuAdmin();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }
                        if(UserloginCache.rol == rol.Medico)
                        {
                            MedicoGeneral.MainMenuDoctor mainMenu = new MedicoGeneral.MainMenuDoctor();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }
                        if(UserloginCache.rol == rol.Enfermero)
                        {
                            Enfermeria.MainMenuEnfermero mainMenu = new Enfermeria.MainMenuEnfermero();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }

                        if (UserloginCache.rol == rol.Especialista)
                        {
                            Especialistas.MainMenuEspecialista mainMenu = new Especialistas.MainMenuEspecialista();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }
                        if (UserloginCache.rol == rol.Laboratorista)
                        {
                            Laboratorio.MainMenuLaboratorio mainMenu = new Laboratorio.MainMenuLaboratorio();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }
                        if (UserloginCache.rol == rol.Farmaceutico)
                        {
                            Farmacia.MainMenuFarmacia mainMenu = new Farmacia.MainMenuFarmacia();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }
                        if (UserloginCache.rol == rol.Cajero)
                        {
                            Caja.MainMenuCaja mainMenu = new Caja.MainMenuCaja();
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }
                    }

                    else{
                        msgError("Usuario o Contraseña incorrecta.");
                        txtpass.Clear();
                        txtuser.Focus();
                    }

                }
                else msgError("Ingrese Su Contraseña");
            }
            else msgError("Ingrese Su Usuario");
        }

        private void msgError(string msg)
        {
            lblErrorMessage.Text = " " + msg;
            lblErrorMessage.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Clear();
            txtuser.Clear();
            lblErrorMessage.Visible = false;
            this.Show();
            txtuser.Focus();
        }







        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
