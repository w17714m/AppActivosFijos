using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppActivosFijosWJCQ.Entity.Model
{
    [Table("AreaPersona_Ciudad", Schema = "public")]
    public class AreaPersona_Ciudad
    {
        [Key]
        public int Id_AreaPersona_Ciudad { get; set; }
        public int Id_AreaPersona { get; set; }
        public int Id_Ciudad { get; set; }

        public virtual AreaPersona AreaPersona { get; set; }
        public virtual Ciudad Ciudad { get; set; }
    }
}
