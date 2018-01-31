using AppActivosFijosWJCQ.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppActivosFijosWJCQ.BusinessLayer.Interface
{
    /// <summary>
    /// Interface Firma Ciudad
    /// </summary>
    public interface ICiudadBL
    {
        List<Ciudad> GetAllCiudad();
        List<Ciudad> GetCiudad(Ciudad pCiudad);
        bool AddCiudad(Ciudad pCiudad);
        bool EditCiudad(Ciudad pCiudad);
        bool DeleteCiudad(Ciudad pCiudad);
    }
}
