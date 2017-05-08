using Ninject;
using RegistrationMVC.Infraestructure.Abstract;
using RegistrationMVC.Infraestructure.Concret;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace RegistrationMVC.Infraestructure.Ninject
{
    /*Gestor de dependencias*/
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            /*Crea una instancia de Ninject*/
            ninjectKernel = new StandardKernel();

            /*Inyecta las dependencias*/
            AddBindings();
        }

        /**/
        protected override IController GetControllerInstance(RequestContext resquestContext, Type controllerType)
        {
            return controllerType == null
                ? null : (IController)ninjectKernel.Get(controllerType);
        }

        /*Metodo para describir las dependencias a inyectar*/
        private void AddBindings()
        {
            /*Configuraciones de relación entre las interfaces y la implementación deseada*/
            ninjectKernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
            ninjectKernel.Bind<IUsuariosRepository>().To<EFUsuariosRepository>();
        }
    }
}