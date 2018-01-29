using System.Web.Http;
using Unity;
using Unity.WebApi;
using AppActivosFijosWJCQ.BusinessLayer;
using AppActivosFijosWJCQ.BusinessLayer.Interface;
using AppActivosFijosWJCQ.BusinessLayer.Concrete;

namespace AppActivosFijosWJCQ
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IActivosFijosBL, ActivosFijosBL>();
            container.RegisterType<IAreaPersona_CiudadBL, AreaPersona_CiudadBL>();
            container.RegisterType<IAreaPersonaBL, AreaPersonaBL>();
            container.RegisterType<ICiudadBL, CiudadBL>();
            container.RegisterType<IEstadoActualBL, EstadoActualBL>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}