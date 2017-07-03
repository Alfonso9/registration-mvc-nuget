using System;
using RegistrationMVC.Infraestructure.Abstract;
using RegistrationMVC.Models.Cuentas.Input;
using System.Web.Security;

namespace RegistrationMVC.Infraestructure.Concret
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Autenticar(UsuarioModel usuario)
        {
            bool _Autenticado = false;

            try
            {
                UsuarioModel _Usuario = new UsuarioModel(); //_IUsersRepository.GetUsuario(usuario, contrasenia);

                _Usuario._Usuario = "alfonso09.lr@gmail.com";
                _Usuario._Recordarme = true;

                if (_Usuario != null)
                {
                    _Autenticado = true;
                }
            }
            catch { }

            return _Autenticado;
        }
    }
}