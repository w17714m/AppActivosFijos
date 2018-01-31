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
    /// Controlador Area Personal
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [AgregarLog]
    public class AreaPersonaController : ApiController
    {
        /// <summary>
        /// Instancia Area Personal
        /// </summary>
        IAreaPersonaBL AreaPersonaBL;
        /// <summary>
        /// Constructor con injección de dependencia
        /// </summary>
        /// <param name="AreaPersonaBL">Interfaz Area personal</param>
        public AreaPersonaController(IAreaPersonaBL AreaPersonaBL)
        {
            this.AreaPersonaBL = AreaPersonaBL;
        }

        /// <summary>
        /// Agrega AreaPersona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/AddAreaPersona")]
        public HttpResponseMessage AddAreaPersona(AreaPersona pAreaPersona)
        {
            try
            {
                var r = AreaPersonaBL.AddAreaPersona(pAreaPersona);
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
        /// Borra Area Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/DeleteAreaPersona")]
        public HttpResponseMessage DeleteAreaPersona(AreaPersona pAreaPersona)
        {
            try
            {
                var r = AreaPersonaBL.DeleteAreaPersona(pAreaPersona);
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
        /// Edita AreaPersona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/EditAreaPersona")]
        public HttpResponseMessage EditAreaPersona(AreaPersona pAreaPersona)
        {
            try
            {
                var r = AreaPersonaBL.EditAreaPersona(pAreaPersona);
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
        /// Agrega AreaPersona
        /// </summary>
        /// <returns>Lista Area Persona</returns>
        [HttpPost]
        [Route("api/GetAllAreaPersona")]
        public HttpResponseMessage GetAllAreaPersona()
        {
            try
            {
                var r = AreaPersonaBL.GetAllAreaPersona();
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
        /// Obtiene Area Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona </param>
        /// <returns>Lista Area Persona</returns>
        [HttpPost]
        [Route("api/GetAreaAreaPersona")]
        public HttpResponseMessage GetAreaAreaPersona(AreaPersona pAreaPersona)
        {
            try
            {
                var r =AreaPersonaBL.GetAreaAreaPersona(pAreaPersona);
                
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
