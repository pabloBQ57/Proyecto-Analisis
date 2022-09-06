using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Comun.Cache;


//MIS CONSTRUCTORES

namespace Dominio
{
    public class UsuarioDominio
    {
        UsuarioDao usuarioDao = new UsuarioDao();
        public bool LoginUser(string user, string pass)
        {
            return usuarioDao.login(user,pass);
        }

        public void AnyMethod()
        {
            if (UserloginCache.rol == rol.Administrador)
            {

            }
            if (UserloginCache.rol == rol.Medico)
            {

            }
            if(UserloginCache.rol == rol.Enfermero)
            {

            }

            if (UserloginCache.rol == rol.Especialista)
            {

            }
            if (UserloginCache.rol == rol.Laboratorista)
            {
            }
            if (UserloginCache.rol == rol.Farmaceutico)
            {
            }
            if (UserloginCache.rol == rol.Cajero)
            {
            }
        }

    }
}
