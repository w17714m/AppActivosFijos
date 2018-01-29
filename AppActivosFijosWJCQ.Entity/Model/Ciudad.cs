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
            this.AreaPersona = new HashSet<AreaPersona>();
        }

        [Key]
        public int Id_Ciudad { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<AreaPersona> AreaPersona { get; set; }
    }
}
