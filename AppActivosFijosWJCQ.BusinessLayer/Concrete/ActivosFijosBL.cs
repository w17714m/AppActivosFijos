
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;
using AppActivosFijosWJCQ.DAL;
using AppActivosFijosWJCQ.BusinessLayer.Interface;

namespace AppActivosFijosWJCQ.BusinessLayer.Concrete
{
    /// <summary>
    /// Campa de negocio Activos Fijos
    /// </summary>
    public class ActivosFijosBL : IActivosFijosBL
    {
        /// <summary>
        /// Agrega Activos Fijos
        /// </summary>
        /// <param name="pActivosFijos">Clase Activos Fijos</param>
        /// <returns>true o false</returns>
        public bool AddActivosFijos(ActivosFijos pActivosFijos)
        {
            return new ActivosFijosDAL().AddActivosFijos(pActivosFijos);
        }

        /// <summary>
        /// Borra Activos Fijos
        /// </summary>
        /// <param name="pActivosFijos">Clase Activos Fijos</param>
        /// <returns>true o false</returns>
        public bool DeleteActivosFijos(ActivosFijos pActivosFijos)
        {
            return new ActivosFijosDAL().DeleteActivosFijos(pActivosFijos);
        }

        /// <summary>
        /// Edita Activos Fijos
        /// </summary>
        /// <param name="pActivosFijos">Clase Activos Fijos</param>
        /// <returns>true o false</returns>
        public bool EditActivosFijos(ActivosFijos pActivosFijos)
        {
            return new ActivosFijosDAL().EditActivosFijos(pActivosFijos);
        }

        /// <summary>
        /// Obtiene Activos Fijos por filtro
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos Fijos</param>
        /// <returns>Lista Activos Fijos</returns>
        public List<ActivosFijos> GetActivosFijos(ActivosFijos pActivosFijos)
        {
            return new ActivosFijosDAL().GetActivosFijos(pActivosFijos);
        }
        /// <summary>
        /// Obtiene Activos Fijos 
        /// </summary>
        /// <returns>Lista Activos Fijos</returns>
        public List<ActivosFijos> GetAllActivosFijos()
        {
            return new ActivosFijosDAL().GetAllActivosFijos();
        }
    }
}
