using AppActivosFijosWJCQ.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;
using AppActivosFijosWJCQ.DAL;

namespace AppActivosFijosWJCQ.BusinessLayer.Concrete
{
    /// <summary>
    /// Clase Area Persona capa de negocios
    /// </summary>
    public class AreaPersonaBL : IAreaPersonaBL
    {
        /// <summary>
        /// Agrega Area o Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona</param>
        /// <returns>true or false</returns>
        public bool AddAreaPersona(AreaPersona pAreaPersona)
        {
            return new AreaPersonaDAL().AddAreaPersona(pAreaPersona);
        }
        /// <summary>
        /// Borra Area o Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona</param>
        /// <returns>true or false</returns>
        public bool DeleteAreaPersona(AreaPersona pAreaPersona)
        {
            return new AreaPersonaDAL().DeleteAreaPersona(pAreaPersona);
        }

        /// <summary>
        /// Edita Area o Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona</param>
        /// <returns>true or false</returns>
        public bool EditAreaPersona(AreaPersona pAreaPersona)
        {
            return new AreaPersonaDAL().EditAreaPersona(pAreaPersona);
        }
        /// <summary>
        /// Obtiene Area o Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona</param>
        /// <returns>true or false</returns>
        public List<AreaPersona> GetAllAreaPersona()
        {
            return new AreaPersonaDAL().GetAllAreaPersona();
        }

        /// <summary>
        /// Obtiene Area o Persona por filtro
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area Persona</param>
        /// <returns>Lista Area o Persona </returns>
        public List<AreaPersona> GetAreaAreaPersona(AreaPersona pAreaPersona)
        {
            return new AreaPersonaDAL().GetAreaAreaPersona(pAreaPersona);
        }
    }
}
