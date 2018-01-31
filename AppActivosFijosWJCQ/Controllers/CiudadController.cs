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
    /// Controlador Ciudad
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [AgregarLog]
    public class CiudadController : ApiController
    {
        /// <summary>
        /// Instancia Ciudad 
        /// </summary>
        ICiudadBL CiudadBL;

        /// <summary>
        /// Constructor con injección de dependencia
        /// </summary>
        /// <param name="CiudadBL">Interfaz Ciudad</param>
        public CiudadController(ICiudadBL CiudadBL)
        {
            this.CiudadBL = CiudadBL;
        }

        /// <summary>
        /// Agrega Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/AddCiudad")]
        public HttpResponseMessage AddCiudad(Ciudad pCiudad)
        {
            try
            {
                var r = CiudadBL.AddCiudad(pCiudad);
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
        /// Borra Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/DeleteCiudad")]
        public HttpResponseMessage DeleteCiudad(Ciudad pCiudad)
        {
            try
            {
                var r = CiudadBL.DeleteCiudad(pCiudad);
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
        /// Edita Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/EditCiudad")]
        public HttpResponseMessage EditCiudad(Ciudad pCiudad)
        {
            try
            {
                var r = CiudadBL.EditCiudad(pCiudad);
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
        /// Obtiene Ciudades
        /// </summary>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/GetAllCiudad")]
        public HttpResponseMessage GetAllCiudad()
        {
            try
            {
                var r = CiudadBL.GetAllCiudad();
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
        /// Obtiene Ciudades
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/GetCiudad")]
        public HttpResponseMessage GetCiudad(Ciudad pCiudad)
        {
            try
            {
                var r = CiudadBL.GetCiudad(pCiudad);
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
