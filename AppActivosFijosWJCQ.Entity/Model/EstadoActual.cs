using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppActivosFijosWJCQ.Entity.Model
{
    /// <summary>
    /// Clase Estado Actual
    /// </summary>
    [Table("EstadoActual", Schema = "public")]
    public class EstadoActual
    {
        [Key]
        public int Id_EstadoActual { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<ActivosFijos> ActivosFijos { get; set; }
    }
}
