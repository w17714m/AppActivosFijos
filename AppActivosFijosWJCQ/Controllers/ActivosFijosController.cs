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
        /// <summary>
        /// Agrega Activos Fijos 
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos fijos</param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/AddActivosFijos")]
        public bool AddActivosFijos(ActivosFijos pActivosFijos)
        {
            return  ActivosFijosBL.AddActivosFijos(pActivosFijos);
        }
        /// <summary>
        /// Borra todos los Activos Fijos 
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos fijos</param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/DeleteActivosFijos")]
        public bool DeleteActivosFijos(ActivosFijos pActivosFijos)
        {
            return  ActivosFijosBL.DeleteActivosFijos(pActivosFijos);
        }
        /// <summary>
        /// Edita todos los Activos Fijos 
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos fijos</param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/EditActivosFijos")]
        public bool EditActivosFijos(ActivosFijos pActivosFijos)
        {
            return  ActivosFijosBL.EditActivosFijos(pActivosFijos);
        }
        /// <summary>
        /// Obtiene todos los Activos Fijos por filtro
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos fijos</param>
        /// <returns>Lista Activos Fijos</returns>
        [HttpPost]
        [Route("api/GetActivosFijos")]
        public IEnumerable<ActivosFijos> GetActivosFijos(ActivosFijos pActivosFijos)
        {
            return  ActivosFijosBL.GetActivosFijos(pActivosFijos);
        }
        /// <summary>
        ///  Obtiene todos los Activos Fijos
        /// </summary>
        /// <returns>Lista Activos Fijos</returns>
        [HttpGet]
        [Route("api/GetAllActivosFijos")]
        public IEnumerable<ActivosFijos> GetAllActivosFijos()
        {
            return  ActivosFijosBL.GetAllActivosFijos();
        }
    }
}
