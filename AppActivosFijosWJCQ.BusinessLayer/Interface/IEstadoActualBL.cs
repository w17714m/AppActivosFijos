using AppActivosFijosWJCQ.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppActivosFijosWJCQ.BusinessLayer.Interface
{
    public interface IEstadoActualBL
    {
        List<EstadoActual> GetAllEstadoActual();
        List<EstadoActual> GetEstadoActual(EstadoActual pEstadoActual);
        bool AddEstadoActual(EstadoActual pEstadoActual);
        bool EditEstadoActual(EstadoActual pEstadoActual);
        bool DeleteEstadoActual(EstadoActual pEstadoActual);
    }
}
