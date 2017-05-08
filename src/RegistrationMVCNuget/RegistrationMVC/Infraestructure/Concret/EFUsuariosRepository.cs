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

            }
            catch
            {

            }

            return _Usuario;
        }
    }
}