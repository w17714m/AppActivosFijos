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
    public class ActivosFijosDAL
    {
        public ActivosFijosDAL()
        {

        }
        public bool AddActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.ActivosFijos.Add(pActivosFijos);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    db.ActivosFijos.Remove(pActivosFijos);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    var query = db.ActivosFijos.Where(x => x.id_ActivosFijos == pActivosFijos.id_ActivosFijos).FirstOrDefault();
                    query.Nombre = pActivosFijos.Nombre == null ? query.Nombre : pActivosFijos.Nombre;
                    query.Descripcion = pActivosFijos.Descripcion == null ? query.Descripcion : pActivosFijos.Descripcion;
                    query.Tipo = pActivosFijos.Tipo == null ? query.Tipo : pActivosFijos.Tipo;
                    query.Serial = pActivosFijos.Serial == null ? query.Serial : pActivosFijos.Serial;
                    query.NumeroInterno = pActivosFijos.NumeroInterno == null ? query.NumeroInterno : pActivosFijos.NumeroInterno;
                    query.Peso = pActivosFijos.Peso;
                    query.Alto = pActivosFijos.Alto;
                    query.Ancho = pActivosFijos.Ancho;
                    query.Largo = pActivosFijos.Largo;
                    query.ValorCompra = pActivosFijos.ValorCompra;
                    query.FechaCompra = pActivosFijos.FechaCompra == null ? query.FechaCompra : pActivosFijos.FechaCompra;
                    query.FechaBaja = pActivosFijos.FechaBaja == null ? query.FechaBaja : pActivosFijos.FechaBaja;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ActivosFijos> GetActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                List<ActivosFijos> vActivosFijos;

                var vPredicado = PredicateBuilder.New<ActivosFijos>();

                vPredicado.Or(x => x.id_ActivosFijos==pActivosFijos.id_ActivosFijos);
                vPredicado.Or(x => x.Nombre.Contains(pActivosFijos.Nombre));
                vPredicado.Or(x => x.Descripcion.Contains(pActivosFijos.Descripcion));
                vPredicado.Or(x => x.Tipo.Contains(pActivosFijos.Tipo));
                vPredicado.Or(x => x.Serial.Contains(pActivosFijos.Serial));
                vPredicado.Or(x => x.NumeroInterno.Contains(pActivosFijos.NumeroInterno));
                vPredicado.Or(x => x.Peso == pActivosFijos.Peso);
                vPredicado.Or(x => x.Alto == pActivosFijos.Alto);
                vPredicado.Or(x => x.Ancho == pActivosFijos.Ancho);
                vPredicado.Or(x => x.Largo == pActivosFijos.Largo);
                vPredicado.Or(x => x.FechaCompra == pActivosFijos.FechaCompra);
                vPredicado.Or(x => x.FechaBaja == pActivosFijos.FechaBaja);

                using (var db = new ActivosFijosContext())
                {
                    vActivosFijos = db.ActivosFijos.Where(vPredicado).ToList();
                }
                return vActivosFijos;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<ActivosFijos> GetAllActivosFijos()
        {
            try
            {
                List<ActivosFijos> vActivosFijos;

                using (var db = new ActivosFijosContext())
                {
                    vActivosFijos = db.ActivosFijos.ToList();
                }
                return vActivosFijos;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
