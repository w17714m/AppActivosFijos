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
    public class AreaPersonaDAL
    {
        public AreaPersonaDAL()
        {
            
        }
        public bool AddAreaPersona(AreaPersona pAreaPersona)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.AreaPersona.Add(pAreaPersona);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteAreaPersona(AreaPersona pAreaPersona)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.AreaPersona.Remove(pAreaPersona);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditAreaPersona(AreaPersona pAreaPersona)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    var query = db.AreaPersona.Where(x => x.Id_AreaPersona == pAreaPersona.Id_AreaPersona).FirstOrDefault();
                    query.Nombre = pAreaPersona.Nombre == null ? query.Nombre : pAreaPersona.Nombre;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<AreaPersona> GetAllAreaPersona()
        {

            try
            {
                List<AreaPersona> vAreaPersona;

                using (var db = new ActivosFijosContext())
                {
                    vAreaPersona = db.AreaPersona.ToList();
                }
                return vAreaPersona;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<AreaPersona> GetAreaAreaPersona(AreaPersona pAreaPersona)
        {
            try
            {
                List<AreaPersona> vAreaPersona;



                var vPredicado = PredicateBuilder.New<AreaPersona>();

                vPredicado.Or(x => x.Id_AreaPersona == pAreaPersona.Id_AreaPersona);
                vPredicado.Or(x => x.Nombre.Contains(pAreaPersona.Nombre));

                using (var db = new ActivosFijosContext())
                {
                    vAreaPersona = db.AreaPersona.Where(vPredicado).ToList();
                }
                return vAreaPersona;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
