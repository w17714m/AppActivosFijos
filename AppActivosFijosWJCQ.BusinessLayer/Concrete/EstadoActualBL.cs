using AppActivosFijosWJCQ.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.Entity.Model;
using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.DAL;

namespace AppActivosFijosWJCQ.BusinessLayer.Concrete
{

    /// <summary>
    /// Clase Estado Actual Capa de negocios
    /// </summary>
    public class EstadoActualBL : IEstadoActualBL
    {

        /// <summary>
        /// Agrega Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>true or false</returns>
        public bool AddEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualDAL().AddEstadoActual(pEstadoActual);
        }
        /// <summary>
        /// Borra Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>true or false</returns>
        public bool DeleteEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualDAL().DeleteEstadoActual(pEstadoActual);
        }
        /// <summary>
        /// Edita Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>true or false</returns>
        public bool EditEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualDAL().EditEstadoActual(pEstadoActual);
        }
        /// <summary>
        /// Obtiene todos los Estados Actuales
        /// </summary>
        /// <returns>Lista Estado Actual</returns>
        public List<EstadoActual> GetAllEstadoActual()
        {
            return new EstadoActualDAL().GetAllEstadoActual();
        }
        /// <summary>
        /// Obtiene Estado Actual por filtro
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>Lista Estado Actual</returns>
        public List<EstadoActual> GetEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualDAL().GetEstadoActual(pEstadoActual);
        }
    }
}
