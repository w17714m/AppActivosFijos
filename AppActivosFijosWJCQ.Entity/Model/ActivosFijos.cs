using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppActivosFijosWJCQ.Entity.Model
{
    [Table("ActivosFijos", Schema = "public")]
    public class ActivosFijos
    {
    public ActivosFijos()
    {

    }        
    [Key]
    public int id_ActivosFijos { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Tipo { get; set; }
    public string Serial { get; set; }
    public string NumeroInterno { get; set; }
    public int Peso { get; set; }
    public int Alto { get; set; }
    public int Ancho { get; set; }
    public int Largo { get; set; }
    public  double ValorCompra { get; set; }
    public TimeSpan FechaCompra { get; set; }
    public TimeSpan FechaBaja { get; set; }

    public EstadoActual EstadoActual { get; set; }
    public AreaPersona AreaPersona { get; set; }
    }
}
