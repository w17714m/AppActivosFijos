using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;

namespace AppActivosFijosWJCQ.BusinessLayer.Interface
{
    /// <summary>
    /// Interface Firma Activos fijos
    /// </summary>
    public interface IActivosFijosBL
    {
        List<ActivosFijos> GetAllActivosFijos();
        List<ActivosFijos> GetActivosFijos(ActivosFijos pActivosFijos);
        bool AddActivosFijos(ActivosFijos pActivosFijos);
        bool EditActivosFijos(ActivosFijos pActivosFijos);
        bool DeleteActivosFijos(ActivosFijos pActivosFijos);
    }
}
