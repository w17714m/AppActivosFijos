using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppActivosFijosWJCQ.DAL
{
    public class CiudadDAL
    {
        public CiudadDAL()
        {

        }

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
