using RegistrationMVC.Models.Cuentas.Input;

namespace RegistrationMVC.Infraestructure.Abstract
{
    public interface IAuthProvider
    {
        bool Autenticar(UsuarioModel usuario);
    }
}