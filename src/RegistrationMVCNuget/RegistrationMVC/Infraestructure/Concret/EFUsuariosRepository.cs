using System;
using RegistrationMVC.Infraestructure.Abstract;
using RegistrationMVC.Models.Cuentas.Input;

namespace RegistrationMVC.Infraestructure.Concret
{
    public class EFUsuariosRepository : IUsuariosRepository
    {
        public UsuarioModel ObtenerUsuario(UsuarioModel usuario)
        {
            UsuarioModel _Usuario = new UsuarioModel();

            try
            {
                _Usuario = new UsuarioModel();

                _Usuario._Usuario = "alfonso09.lr@gmail.com";
            }
            catch
            {

            }

            return _Usuario;
        }
    }
}