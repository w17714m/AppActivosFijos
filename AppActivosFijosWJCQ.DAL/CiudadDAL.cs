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
    /// Clase Ciudad de Acceso a Datos
    /// </summary>
    public class CiudadDAL
    {
        /// <summary>
        /// Constructor Ciudad de Acceso a Datos
        /// </summary>
        public CiudadDAL()
        {

        }

        /// <summary>
        /// Agrega una nueva Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad</param>
        /// <returns>true o false según resultado</returns>
        public bool AddCiudad(Ciudad pCiudad)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.Ciudad.Add(pCiudad);
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
        /// Borra Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad</param>
        /// <returns>true o false según resultado</returns>
        public bool DeleteCiudad(Entity.Model.Ciudad pCiudad)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.Ciudad.Remove(pCiudad);
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
        /// Edita Ciudad
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad</param>
        /// <returns>true o false según resultado</returns>
        public bool EditCiudad(Entity.Model.Ciudad pCiudad)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    var query = db.Ciudad.Where(x => x.Id_Ciudad == pCiudad.Id_Ciudad).FirstOrDefault();
                    query.Descripcion = pCiudad.Descripcion == null ? query.Descripcion : pCiudad.Descripcion;
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
        /// Obtiene todas las ciudades
        /// </summary>
        /// <returns>Lista De ciudades</returns>
        public List<Entity.Model.Ciudad> GetAllCiudad()
        {
            try
            {
                List<Ciudad> vCiudad;

                using (var db = new ActivosFijosContext())
                {
                    vCiudad = db.Ciudad.ToList();
                }
                return vCiudad;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Obtiene Ciudades por filtro
        /// </summary>
        /// <param name="pCiudad">Entidad Ciudad</param>
        /// <returns>Lista de Ciudades</returns>
        public List<Entity.Model.Ciudad> GetCiudad(Ciudad pCiudad)
        {
            try
            {
                List<Ciudad> vCiudad;

                var vPredicado = PredicateBuilder.New<Ciudad>();

                vPredicado.Or(x => x.Id_Ciudad== pCiudad.Id_Ciudad);
                vPredicado.Or(x => x.Descripcion.Contains(pCiudad.Descripcion));

                using (var db = new ActivosFijosContext())
                {
                    vCiudad = db.Ciudad.Where(vPredicado).ToList();
                }
                return vCiudad;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
