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
    /// Clase de acceso a datos que permite la administración de activos fijos
    /// </summary>
    public class ActivosFijosDAL
    {

        /// <summary>
        /// Constructor Activos Fijos
        /// </summary>
        public ActivosFijosDAL()
        {

        }

        /// <summary>
        /// Agrega activos fijos
        /// </summary>

        public bool AddActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    //var estadoActual = db.EstadoActual.FirstOrDefault(x => x.Id_EstadoActual == pActivosFijos.Id_EstadoActual);
                    //var areaPersona= db.AreaPersona.FirstOrDefault(x => x.Id_AreaPersona== pActivosFijos.Id_AreaPersona);
                    //pActivosFijos.AreaPersona = areaPersona;
                    //pActivosFijos.EstadoActual = estadoActual;
                    db.ActivosFijos.Add(pActivosFijos);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        /// <summary>
        /// Borra Activos Fijos
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos Fijos</param>
        /// <returns>true o false según el resultado</returns>
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
        /// <summary>
        /// Edita Activos Fijos
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos Fijos</param>
        /// <returns>true o false según el resultado</returns>
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
                    query.AreaPersona = pActivosFijos.AreaPersona==null? query.AreaPersona:db.AreaPersona.Where(x => x.Id_AreaPersona == pActivosFijos.AreaPersona.Id_AreaPersona).FirstOrDefault();
                    query.EstadoActual = pActivosFijos.EstadoActual == null ? query.EstadoActual : db.EstadoActual.Where(x => x.Id_EstadoActual== pActivosFijos.EstadoActual.Id_EstadoActual).FirstOrDefault();
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        /// <summary>
        /// Obtiene Activos Fijos por filtro
        /// </summary>
        /// <param name="pActivosFijos">Entidad Activos Fijos</param>
        /// <returns>Retorna lista tipo ActivosFijos</returns>
        public List<ActivosFijos> GetActivosFijos(ActivosFijos pActivosFijos)
        {
            try
            {
                List<ActivosFijos> vActivosFijos;

                var vPredicado = PredicateBuilder.New<ActivosFijos>();

                if (pActivosFijos.Tipo != null) vPredicado.Or(x => x.Tipo.Contains(pActivosFijos.Tipo));
                if (pActivosFijos.Serial != null) vPredicado.Or(x => x.Serial.Contains(pActivosFijos.Serial));
                if (!string.IsNullOrEmpty(pActivosFijos.FechaCompra)  ) vPredicado.Or(x => x.FechaCompra == pActivosFijos.FechaCompra);
                

                using (var db = new ActivosFijosContext())
                {
                    vActivosFijos = db.ActivosFijos.Where(vPredicado).ToList();
                }
                return vActivosFijos;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// Retorna todos los activos fijos
        /// </summary>
        /// <returns>Retorna lista tipo ActivosFijos</returns>
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
