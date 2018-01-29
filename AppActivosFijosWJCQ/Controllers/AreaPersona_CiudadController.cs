using AppActivosFijosWJCQ.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppActivosFijosWJCQ.BusinessLayer.Interface;
namespace AppActivosFijosWJCQ.Controllers
{
    [AgregarLog]
    public class AreaPersona_CiudadController : ApiController
    {
        IAreaPersona_CiudadBL AreaPersonaCiudadBL;
        public AreaPersona_CiudadController(IAreaPersona_CiudadBL AreaPersona_CiudadBL)
        {
            this.AreaPersonaCiudadBL = AreaPersona_CiudadBL;
        }

        public bool AddAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            return  AreaPersonaCiudadBL.AddAreaPersona_Ciudad(pAreaPersona_Ciudad);
        }

        public bool DeleteAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            return  AreaPersonaCiudadBL.DeleteAreaPersona_Ciudad(pAreaPersona_Ciudad);
        }

        public bool EditAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            return  AreaPersonaCiudadBL.EditAreaPersona_Ciudad(pAreaPersona_Ciudad);
        }

        public IEnumerable<AreaPersona_Ciudad> GetAllAreaPersona_Ciudad()
        {
            return  AreaPersonaCiudadBL.GetAllAreaPersona_Ciudad();
        }

        public IEnumerable<AreaPersona_Ciudad> GetAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            return  AreaPersonaCiudadBL.GetAreaPersona_Ciudad(pAreaPersona_Ciudad);
        }

    }
}
