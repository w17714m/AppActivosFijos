using AppActivosFijosWJCQ.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.Entity.Model;
using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.DAL;

namespace AppActivosFijosWJCQ.BusinessLayer.Concrete
{
    public class EstadoActualBL : IEstadoActualBL
    {
        public bool AddEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualDAL().AddEstadoActual(pEstadoActual);
        }

        public bool DeleteEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualDAL().DeleteEstadoActual(pEstadoActual);
        }

        public bool EditEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualDAL().EditEstadoActual(pEstadoActual);
        }

        public List<EstadoActual> GetAllEstadoActual()
        {
            return new EstadoActualDAL().GetAllEstadoActual();
        }

        public List<EstadoActual> GetEstadoActual(EstadoActual pEstadoActual)
        {
            return new EstadoActualDAL().GetEstadoActual(pEstadoActual);
        }
    }
}
