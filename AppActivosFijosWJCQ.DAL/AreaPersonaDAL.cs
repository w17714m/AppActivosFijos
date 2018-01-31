using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;
using System.Data.Entity;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AppActivosFijosWJCQ.DAL
{
    /// <summary>
    /// Clase Area o Persona de Acceso a Datos
    /// </summary>
    public class AreaPersonaDAL
    {
        /// <summary>
        /// Constructor Area o Persona de Acceso a Datos
        /// </summary>
        public AreaPersonaDAL()
        {
            
        }

        /// <summary>
        /// Agrega una nueva Area o Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area o persona</param>
        /// <returns>true o false según relsultado</returns>
        public bool AddAreaPersona(AreaPersona pAreaPersona)
        {
            try
            {
                using (var db = new ActivosFijosContext())
                {
                    int idCiudad = pAreaPersona.Ciudad.FirstOrDefault().Id_Ciudad;
                    pAreaPersona.Ciudad = db.Ciudad.Where(x => x.Id_Ciudad == idCiudad).ToList();
                    db.AreaPersona.Add(pAreaPersona);
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
        /// Borra una nueva Area o Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area o persona</param>
        /// <returns>true o false según relsultado</returns>
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
        /// <summary>
        /// Edita una nueva Area o Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area o persona</param>
        /// <returns>true o false según relsultado</returns>
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


        /// <summary>
        /// Obtiene todas las Areas o Personas
        /// </summary>
        /// <returns>Lista AreaPersona</returns>
        public List<AreaPersona> GetAllAreaPersona()
        {

            try
            {
                List<AreaPersona> vAreaPersona;

                using (var db = new ActivosFijosContext())
                {
                    vAreaPersona = db.AreaPersona.Include("Ciudad").ToList();
                }
                return vAreaPersona;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// Obtiene una nueva Area o Persona
        /// </summary>
        /// <param name="pAreaPersona">Entidad Area o persona</param>
        /// <returns>Lista de Areas o Personas</returns>
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
