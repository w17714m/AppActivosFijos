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
    public class EstadoActualDAL
    {
        public EstadoActualDAL()
        {

        }

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

        public List<EstadoActual> GetAllEstadoActual()
        {
            throw new NotImplementedException();
        }

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
