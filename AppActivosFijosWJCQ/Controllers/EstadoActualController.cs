using AppActivosFijosWJCQ.BusinessLayer.Concrete;
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
    /// Controllador para la entidad Estado Actual
    /// </summary>
    /// 
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [AgregarLog]
    public class EstadoActualController : ApiController
    {
        /// <summary>
        /// Instancia Estado Actual
        /// </summary>
        IEstadoActualBL EstadoActualBL;

        /// <summary>
        /// Constructor Con injección de dependencia
        /// </summary>
        /// <param name="EstadoActualBL">Interfaz Estado Actual</param>
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
        public HttpResponseMessage AddEstadoActual(EstadoActual pEstadoActual)
        {
            try
            {
                var r = new EstadoActualBL().AddEstadoActual(pEstadoActual);
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
        /// Borra Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad estado actual</param>
        /// <returns>verdadero o falso según resultado</returns>
        [HttpPost]
        [Route("api/DeleteEstadoActual")]
        public HttpResponseMessage DeleteEstadoActual(EstadoActual pEstadoActual)
        {
            try
            {
                var r = new EstadoActualBL().DeleteEstadoActual(pEstadoActual);
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
        /// Editar Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>verdadero o falso según resultado</returns>
        [HttpPost]
        [Route("api/EditEstadoActual")]
        public HttpResponseMessage EditEstadoActual(EstadoActual pEstadoActual)
        {

            try
            {
                var r = new EstadoActualBL().EditEstadoActual(pEstadoActual);
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
        /// Obtiene toda la entidad Estado Actual
        /// </summary>
        /// <returns>Lista estadoactual</returns>
        [HttpGet]
        [Route("api/GetAllEstadoActual")]
        public HttpResponseMessage GetAllEstadoActual()
        {
            try
            {
                var r = new EstadoActualBL().GetAllEstadoActual();
                if (r.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.OK,r );
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
        /// Obtiene Estado Actual por un filtro
        /// </summary>
        /// <param name="pEstadoActual">Entidad estado Actual</param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/GetEstadoActual")]
        public HttpResponseMessage GetEstadoActual(EstadoActual pEstadoActual)
        {

            try
            {
                var r = new EstadoActualBL().GetEstadoActual(pEstadoActual);
                if (r.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, r);
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

    }
}
