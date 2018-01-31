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
    /// Clase Ciudad capa de negocios
    /// </summary>
    public class CiudadBL : ICiudadBL
    {
        /// <summary>
        /// Agrega Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad</param>
        /// <returns>true or false</returns>
        public bool AddCiudad(Ciudad pCiudad)
        {
            return new CiudadDAL().AddCiudad(pCiudad);
        }
        /// <summary>
        /// Borra Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad</param>
        /// <returns>true or false</returns>
        public bool DeleteCiudad(Ciudad pCiudad)
        {
            return new CiudadDAL().DeleteCiudad(pCiudad);
        }
        /// <summary>
        /// Edita Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad</param>
        /// <returns>true or false</returns>
        public bool EditCiudad(Ciudad pCiudad)
        {
            return new CiudadDAL().EditCiudad(pCiudad);
        }

        /// <summary>
        /// Obtiene todas las Ciudades
        /// </summary>
        /// <returns>Lista Ciudad</returns>
        public List<Ciudad> GetAllCiudad()
        {
            return new CiudadDAL().GetAllCiudad();
        }
        /// <summary>
        /// Obtiene todas las Ciudades
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad</param>
        /// <returns>Lista Ciudad</returns>
        public List<Ciudad> GetCiudad(Ciudad pCiudad)
        {
            return new CiudadDAL().GetCiudad(pCiudad);
        }
    }
}
