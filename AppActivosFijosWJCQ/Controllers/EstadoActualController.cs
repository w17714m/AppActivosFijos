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
    /// <summary>
    /// Controllador para la entidad Estado Actual
    /// </summary>
    [AgregarLog]
    public class EstadoActualController : ApiController
    {
        IEstadoActualBL EstadoActualBL;
        public EstadoActualController(IEstadoActualBL EstadoActualBL)
        {
            this.EstadoActualBL = EstadoActualBL;
        }

        /// <summary>
        /// Agrega Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>verdadero o falso según resultado</returns>
        [HttpPost]
        [Route("api/AddEstadoActual")]
        public bool AddEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualBL().AddEstadoActual(pEstadoActual);
        }
        /// <summary>
        /// Borra Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad estado actual</param>
        /// <returns>verdadero o falso según resultado</returns>
        [HttpPost]
        [Route("api/DeleteEstadoActual")]
        public bool DeleteEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualBL().DeleteEstadoActual(pEstadoActual);
        }
        /// <summary>
        /// Editar Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>verdadero o falso según resultado</returns>
        [HttpPost]
        [Route("api/EditEstadoActual")]
        public bool EditEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualBL().EditEstadoActual(pEstadoActual);
        }

        /// <summary>
        /// Obtiene toda la entidad Estado Actual
        /// </summary>
        /// <returns>Lista estadoactual</returns>
        [HttpGet]
        [Route("api/GetAllEstadoActual")]
        public IEnumerable<EstadoActual> GetAllEstadoActual()
        {
            return new EstadoActualBL().GetAllEstadoActual();
        }
        /// <summary>
        /// Obtiene Estado Actual por un filtro
        /// </summary>
        /// <param name="pEstadoActual">Entidad estado Actual</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetEstadoActual")]
        public IEnumerable<EstadoActual> GetEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualBL().GetEstadoActual(pEstadoActual);
        }

    }
}
