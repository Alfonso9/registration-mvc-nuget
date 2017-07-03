using RegistrationMVC.Infraestructure.Abstract;
using RegistrationMVC.Models.Cuentas.Input;
using System.Web.Mvc;

namespace RegistrationMVC.Controllers
{
    [Authorize]
    public class PrincipalController : Controller
    {
        private IUsuariosRepository _IUsersRepository;

        public PrincipalController(IUsuariosRepository iUsersRepository)
        {
            _IUsersRepository = iUsersRepository;
        }

        // GET: Principal
        [Authorize]
        public ActionResult Index()
        {
            if (Session.SessionID == "jeggpufxbmq5jyujgx0wu1mc")
            {
                var _Usuario = _IUsersRepository.ObtenerUsuario(new UsuarioModel());
                Session["Usuario"] = _Usuario;
            }

            if (HttpContext.User.Identity.IsAuthenticated)
            {
                UsuarioModel _Usuario = (UsuarioModel)Session["Usuario"];

                ViewBag.Usuario = ("Usuario: " + _Usuario._Usuario + "\nRecordarme: " + _Usuario._Recordarme);
            }
            return View();
        }
    }
}