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
    public class AreaPersonaCiudadDAL
    {
        public AreaPersonaCiudadDAL()
        {

        }

        public bool AddAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.AreaPersona_Ciudad.Add(pAreaPersona_Ciudad);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.AreaPersona_Ciudad.Remove(pAreaPersona_Ciudad);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    var query = db.AreaPersona_Ciudad.Where(x => x.Id_AreaPersona_Ciudad == pAreaPersona_Ciudad.Id_AreaPersona_Ciudad).FirstOrDefault();
                    query.Id_AreaPersona = pAreaPersona_Ciudad.Id_AreaPersona;
                    query.Id_Ciudad = pAreaPersona_Ciudad.Id_Ciudad;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<AreaPersona_Ciudad> GetAllAreaPersona_Ciudad()
        {
            try
            {
                List<AreaPersona_Ciudad> vAreaPersona_Ciudad;

                using (var db = new ActivosFijosContext())
                {
                    vAreaPersona_Ciudad = db.AreaPersona_Ciudad.ToList();
                }
                return vAreaPersona_Ciudad;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<AreaPersona_Ciudad> GetAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            try
            {
                List<AreaPersona_Ciudad> vAreaPersona_Ciudad;


                var vPredicado = PredicateBuilder.New<AreaPersona_Ciudad>();

                vPredicado.Or(x => x.Id_AreaPersona_Ciudad == pAreaPersona_Ciudad.Id_AreaPersona_Ciudad);
                vPredicado.Or(x => x.Id_Ciudad == pAreaPersona_Ciudad.Id_Ciudad);
                vPredicado.Or(x => x.Id_AreaPersona == pAreaPersona_Ciudad.Id_AreaPersona);


                using (var db = new ActivosFijosContext())
                {
                    vAreaPersona_Ciudad = db.AreaPersona_Ciudad.Where(vPredicado).ToList();
                }
                return vAreaPersona_Ciudad;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
