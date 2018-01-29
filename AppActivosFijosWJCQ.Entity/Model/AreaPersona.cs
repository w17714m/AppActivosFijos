using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppActivosFijosWJCQ.Entity.Model
{
    [Table("AreaPersona", Schema = "public")]
    public class AreaPersona
    {
        public AreaPersona()
        {
            this.Ciudad = new HashSet<Ciudad>();
        }

        [Key]
        public int Id_AreaPersona { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Ciudad> Ciudad { get; set; }
    }
}
