using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace AppActivosFijosWJCQ.Entity.Model
{
    /// <summary>
    /// Clase Area Persona
    /// </summary>
    [Table("AreaPersona", Schema = "public")]
    public class AreaPersona
    {
        public AreaPersona()
        {
            this.Ciudad = new HashSet<Ciudad>();
            this.ActivosFijos = new HashSet<ActivosFijos>();
        }

        [Key]
        public int Id_AreaPersona { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Ciudad> Ciudad { get; set; }
        public virtual ICollection<ActivosFijos> ActivosFijos { get; set; }


    }
}
