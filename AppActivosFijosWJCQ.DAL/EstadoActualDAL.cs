using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AppActivosFijosWJCQ.DAL
{
    /// <summary>
    /// Clase Estado Actual de acceso a datos
    /// </summary>
    public class EstadoActualDAL
    {
        /// <summary>
        /// Constructor Estado Actual
        /// </summary>
        public EstadoActualDAL()
        {

        }

        /// <summary>
        /// Agrega un nuevo Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>true o false según resultado.</returns>
        public bool AddEstadoActual(EstadoActual pEstadoActual)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.EstadoActual.Add(pEstadoActual);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Borra Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>true o false según resultado.</returns>
        public bool DeleteEstadoActual(EstadoActual pEstadoActual)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.EstadoActual.Remove(pEstadoActual);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Edita Estado Actual
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>true o false según resultado.</returns>
        public bool EditEstadoActual(EstadoActual pEstadoActual)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    var query = db.EstadoActual.Where(x => x.Id_EstadoActual == pEstadoActual.Id_EstadoActual).FirstOrDefault();
                    query.Descripcion = pEstadoActual.Descripcion == null ? query.Descripcion : pEstadoActual.Descripcion;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene todos los estados Actuales
        /// </summary>
        /// <returns>Lista Estados Actuales</returns>
        public List<EstadoActual> GetAllEstadoActual()
        {
            try
            {
                List<EstadoActual> vEstadoActual;

                

                using (var db = new ActivosFijosContext())
                {
                    vEstadoActual = db.EstadoActual.ToList();
                }
                return vEstadoActual;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene Lista Estado Actual por filtro
        /// </summary>
        /// <param name="pEstadoActual">Entidad Estado Actual</param>
        /// <returns>Lista Estado Actual</returns>
        public List<EstadoActual> GetEstadoActual(EstadoActual pEstadoActual)
        {
            try
            {
                List<EstadoActual> vEstadoActual;

                var vPredicado = PredicateBuilder.New<EstadoActual>();

                vPredicado.Or(x => x.Id_EstadoActual == pEstadoActual.Id_EstadoActual);
                vPredicado.Or(x => x.Descripcion.Contains(pEstadoActual.Descripcion));

                using (var db = new ActivosFijosContext())
                {
                    vEstadoActual = db.EstadoActual.Where(vPredicado).ToList();
                }
                return vEstadoActual;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
