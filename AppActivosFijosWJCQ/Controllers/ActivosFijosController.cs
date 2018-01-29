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
    public class ActivosFijosController : ApiController
    {
        IActivosFijosBL ActivosFijosBL;

        public ActivosFijosController(IActivosFijosBL ActivosFijosBL)
        {
            this.ActivosFijosBL = ActivosFijosBL;
        }

        public bool AddActivosFijos(ActivosFijos pActivosFijos)
        {
            return  ActivosFijosBL.AddActivosFijos(pActivosFijos);
        }

        public bool DeleteActivosFijos(ActivosFijos pActivosFijos)
        {
            return  ActivosFijosBL.DeleteActivosFijos(pActivosFijos);
        }

        public bool EditActivosFijos(ActivosFijos pActivosFijos)
        {
            return  ActivosFijosBL.EditActivosFijos(pActivosFijos);
        }

        public IEnumerable<ActivosFijos> GetActivosFijos(ActivosFijos pActivosFijos)
        {
            return  ActivosFijosBL.GetActivosFijos(pActivosFijos);
        }

        public IEnumerable<ActivosFijos> GetAllActivosFijos()
        {
            return  ActivosFijosBL.GetAllActivosFijos();
        }
    }
}
