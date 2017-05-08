using System;
using RegistrationMVC.Infraestructure.Abstract;
using RegistrationMVC.Models.Cuentas.Input;

namespace RegistrationMVC.Infraestructure.Concret
{
    public class FormsAuthProvider : IAuthProvider
    {
        public bool Autenticar(UsuarioModel usuario)
        {
            /*Almacena el resultado del metodo*/
            bool _Autenticado = false;

            try
            {

                /*Almacena el numero de registro encontrados con los filtros colocados*/
                //Usuarios _Usuario = _IUsersRepository.GetUsuario(usuario, contrasenia);

                //if (_Usuario != null)
                {
                    //FormsAuthentication.SetAuthCookie(_Usuario.Usuario, recordarme);
                    //_Usuario.UltimoAcceso = DateTime.Now;
                    //_IUsersRepository.Update(_Usuario);
                    _Autenticado = true;
                }
            }
            catch { }

            return _Autenticado;
        }
    }
}