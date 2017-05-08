using RegistrationMVC.Models.Cuentas.Input;

namespace RegistrationMVC.Infraestructure.Abstract
{
    public interface IUsuariosRepository
    {
        UsuarioModel ObtenerUsuario(UsuarioModel usuario);
    }
}
