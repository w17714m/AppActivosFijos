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
    public class EstadoActualController : ApiController
    {
        IEstadoActualBL EstadoActualBL;
        public EstadoActualController(IEstadoActualBL EstadoActualBL)
        {
            this.EstadoActualBL = EstadoActualBL;
        }

        public bool AddEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualBL().AddEstadoActual(pEstadoActual);
        }

        public bool DeleteEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualBL().DeleteEstadoActual(pEstadoActual);
        }

        public bool EditEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualBL().EditEstadoActual(pEstadoActual);
        }

        public IEnumerable<EstadoActual> GetAllEstadoActual()
        {
            return new EstadoActualBL().GetAllEstadoActual();
        }

        public IEnumerable<EstadoActual> GetEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualBL().GetEstadoActual(pEstadoActual);
        }

    }
}
