using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppActivosFijosWJCQ.Entity.Model
{
    [Table("Ciudad", Schema = "public")]
    public class Ciudad
    {
        public Ciudad()
        {
            AreaPersona_Ciudad = new HashSet<AreaPersona_Ciudad>();
        }

        [Key]
        public int Id_Ciudad { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<AreaPersona_Ciudad> AreaPersona_Ciudad { get; set; }
    }
}
