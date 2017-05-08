using RegistrationMVC.Models.Cuentas.Input;
using RegistrationMVC.Infraestructure.Abstract;
using System.Web.Mvc;

namespace RegistrationMVC.Controllers
{
    public class CuentasController : Controller
    {
        private IAuthProvider _IAuthProvider;
        private IUsuariosRepository _IUsersRepository;

        public CuentasController(IAuthProvider iAuthProvider, IUsuariosRepository iUsersRepository)
        {
            _IAuthProvider = iAuthProvider;
            _IUsersRepository = iUsersRepository;
        }

        [HttpGet]
        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IniciarSesion(UsuarioModel usuario)
        { 
            if (ModelState.IsValid)
            {
                if (_IAuthProvider.Autenticar(usuario))
                {
                    UsuarioModel _Usuario = _IUsersRepository.ObtenerUsuario(usuario);

                    if (!AlmacenarDatosEnSesion(_Usuario))
                    {
                        ModelState.AddModelError("", "Por el momento el servicio no se encuentra disponible. Por favor, intente más tarde.");
                        return View();
                    }

                    return Redirect("Principal/Index");
                }
                else
                {
                    ModelState.AddModelError("", "El usuario o contraseña son incorrectos.");
                    return View(usuario);
                }
            }
            else
            {
                return View();
            }
        }

        private bool AlmacenarDatosEnSesion(UsuarioModel usuario)
        {
            bool _Almacenado = false;

            try
            {
                Session["usuario"] = usuario;
                _Almacenado = true;
            }
            catch
            {
                _Almacenado = false;
            }

            return _Almacenado;
        }
    }
}