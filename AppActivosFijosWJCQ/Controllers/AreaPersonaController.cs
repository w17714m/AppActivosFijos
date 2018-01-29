using AppActivosFijosWJCQ.BusinessLayer.Concrete;
using AppActivosFijosWJCQ.BusinessLayer.Interface;
using AppActivosFijosWJCQ.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppActivosFijosWJCQ.Controllers
{
    [AgregarLog]
    public class AreaPersonaController : ApiController
    {
        IAreaPersonaBL AreaPersonaBL;

        public AreaPersonaController(IAreaPersonaBL AreaPersonaBL)
        {
            this.AreaPersonaBL = AreaPersonaBL;
        }
        

        public bool AddAreaPersona(AreaPersona pAreaPersona)
        {
            return  AreaPersonaBL.AddAreaPersona(pAreaPersona);
        }

        public bool DeleteAreaPersona(AreaPersona pAreaPersona)
        {
            return  AreaPersonaBL.DeleteAreaPersona(pAreaPersona);
        }

        public bool EditAreaPersona(AreaPersona pAreaPersona)
        {
            return  AreaPersonaBL.EditAreaPersona(pAreaPersona);
        }

        public IEnumerable<AreaPersona> GetAllAreaPersona()
        {
            return  AreaPersonaBL.GetAllAreaPersona();
        }

        public IEnumerable<AreaPersona> GetAreaAreaPersona(AreaPersona pAreaPersona)
        {
            return  AreaPersonaBL.GetAreaAreaPersona(pAreaPersona);
        }
    }
}
