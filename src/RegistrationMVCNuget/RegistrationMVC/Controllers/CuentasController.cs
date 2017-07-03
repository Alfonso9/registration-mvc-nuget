using RegistrationMVC.Models.Cuentas.Input;
using RegistrationMVC.Infraestructure.Abstract;
using System.Web.Mvc;
using System.Web.Security;
using RegistrationMVC.Filters;

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
        [SesionIniciada]
        public ActionResult IniciarSesion()
        {
            return View();
        }

        [HttpPost]
        [SesionIniciada]
        [ValidateAntiForgeryToken]
        public ActionResult IniciarSesion(UsuarioModel usuario, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (_IAuthProvider.Autenticar(usuario))
                {
                    UsuarioModel _Usuario = _IUsersRepository.ObtenerUsuario(usuario);

                    FormsAuthentication.SetAuthCookie(_Usuario._Usuario, _Usuario._Recordarme);

                    //FormsAuthentication.RedirectFromLoginPage(_Usuario._Usuario, _Usuario._Recordarme);

                    if (!AlmacenarDatosEnSesion(_Usuario))
                    {
                        ModelState.AddModelError("", "Por el momento el servicio no se encuentra disponible. Por favor, intente más tarde.");
                        return View();
                    }

                    if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                    && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Principal");
                    }
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

        [HttpGet]
        public void CerrarSesion()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();

            Response.Redirect(FormsAuthentication.LoginUrl);
            //FormsAuthentication.RedirectToLoginPage();
        }


        [HttpGet]
        [SesionIniciada]
        [AllowAnonymous]
        public ActionResult Recuperar()
        {
            return View();
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