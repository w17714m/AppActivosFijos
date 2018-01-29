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

        /// <summary>
        /// Agrega AreaPersona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/AddAreaPersona")]
        public bool AddAreaPersona(AreaPersona pAreaPersona)
        {
            return  AreaPersonaBL.AddAreaPersona(pAreaPersona);
        }
        /// <summary>
        /// Borra Area Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/DeleteAreaPersona")]
        public bool DeleteAreaPersona(AreaPersona pAreaPersona)
        {
            return  AreaPersonaBL.DeleteAreaPersona(pAreaPersona);
        }
        /// <summary>
        /// Edita AreaPersona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona </param>
        /// <returns>true y false según resultado</returns>
        [HttpPost]
        [Route("api/EditAreaPersona")]
        public bool EditAreaPersona(AreaPersona pAreaPersona)
        {
            return  AreaPersonaBL.EditAreaPersona(pAreaPersona);
        }
        /// <summary>
        /// Agrega AreaPersona
        /// </summary>
        /// <returns>Lista Area Persona</returns>
        [HttpPost]
        [Route("api/GetAllAreaPersona")]
        public IEnumerable<AreaPersona> GetAllAreaPersona()
        {
            return  AreaPersonaBL.GetAllAreaPersona();
        }
        /// <summary>
        /// Obtiene Area Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona </param>
        /// <returns>Lista Area Persona</returns>
        [HttpPost]
        [Route("api/GetAreaAreaPersona")]
        public IEnumerable<AreaPersona> GetAreaAreaPersona(AreaPersona pAreaPersona)
        {
            return  AreaPersonaBL.GetAreaAreaPersona(pAreaPersona);
        }
    }
}
