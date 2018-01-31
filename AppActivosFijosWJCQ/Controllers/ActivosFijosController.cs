using AppActivosFijosWJCQ.BusinessLayer.Interface;
using AppActivosFijosWJCQ.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppActivosFijosWJCQ.Controllers
{
    /// <summary>
    /// Controlador Activos Fijos
    /// </summary>
    /// 
    
    [AgregarLog]
    public class ActivosFijosController : ApiController
    {
        /// <summary>
        /// Instancia Activos Fijos
        /// </summary>
        private IActivosFijosBL ActivosFijosBL;

        /// <summary>
        /// Constructor con injección de dependencia
        /// </summary>
        /// <param name="ActivosFijosBL">Interfaz Activos Fijos</param>
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
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage AddActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                var r = ActivosFijosBL.AddActivosFijos(pActivosFijos);
                if (r)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
                else
                {
                    var message =
                        string.Format("Se genero un error puede que no se ingresaron todos los datos del formulario");
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
                }
            }
            catch (Exception e)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,
                    "Se genero un error en el servidor");
            }
        }

        /// <summary>
        /// Borra todos los Activos Fijos 
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos fijos</param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/DeleteActivosFijos")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage DeleteActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                var r = ActivosFijosBL.DeleteActivosFijos(pActivosFijos);
                if (r)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
                else
                {
                    var message =
                        string.Format("Se genero un error puede que no se ingresaron todos los datos del formulario");
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
                }
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,
                    "Se genero un error en el servidor");
            }
        }

        /// <summary>
        /// Edita todos los Activos Fijos 
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos fijos</param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/EditActivosFijos")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage EditActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                var r = ActivosFijosBL.EditActivosFijos(pActivosFijos);
                if (r)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, true);
                }
                else
                {
                    var message =
                        string.Format("Se genero un error puede que no se ingresaron todos los datos del formulario");
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, message);
                }
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,
                    "Se genero un error en el servidor");
            }
        }

        /// <summary>
        /// Obtiene todos los Activos Fijos por filtro
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos fijos</param>
        /// <returns>Lista Activos Fijos</returns>
        [HttpPost]
        [Route("api/GetActivosFijos")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage GetActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                var r = ActivosFijosBL.GetActivosFijos(pActivosFijos);
                if (r.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, r);
                }
                else
                {
                    var message = string.Format("No se retornaron datos");
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
                }
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,
                    "Se genero un error en el servidor");
            }
        }

        /// <summary>
        ///  Obtiene todos los Activos Fijos
        /// </summary>
        /// <returns>Lista Activos Fijos</returns>
        [HttpGet]
        [Route("api/GetAllActivosFijos")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage GetAllActivosFijos()
        {
            try
            {
                var r = ActivosFijosBL.GetAllActivosFijos();
                if (r.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, r);
                }
                else
                {
                    var message = string.Format("No se retornaron datos");
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
                }
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError,
                    "Se genero un error en el servidor");
            }
        }
    }
}
