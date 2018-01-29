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
    public class CiudadController : ApiController
    {
        ICiudadBL CiudadBL;

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
        public bool AddCiudad(Ciudad pCiudad)
        {
            return CiudadBL.AddCiudad(pCiudad);
        }
        /// <summary>
        /// Borra Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/DeleteCiudad")]
        public bool DeleteCiudad(Ciudad pCiudad)
        {
            return  CiudadBL.DeleteCiudad(pCiudad);
        }
        /// <summary>
        /// Edita Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/EditCiudad")]
        public bool EditCiudad(Ciudad pCiudad)
        {
            return  CiudadBL.EditCiudad(pCiudad);
        }
        /// <summary>
        /// Obtiene Ciudades
        /// </summary>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/GetAllCiudad")]
        public IEnumerable<Ciudad> GetAllCiudad()
        {
            return  CiudadBL.GetAllCiudad();
        }
        /// <summary>
        /// Obtiene Ciudades
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/GetCiudad")]
        public IEnumerable<Ciudad> GetCiudad(Ciudad pCiudad)
        {
            return  CiudadBL.GetCiudad(pCiudad);
        }

    }
}
