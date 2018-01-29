
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;
using AppActivosFijosWJCQ.DAL;
using AppActivosFijosWJCQ.BusinessLayer.Interface;

namespace AppActivosFijosWJCQ.BusinessLayer.Concrete
{
    public class ActivosFijosBL : IActivosFijosBL
    {
        public bool AddActivosFijos(ActivosFijos pActivosFijos)
        {
            return new ActivosFijosDAL().AddActivosFijos(pActivosFijos);
        }

        public bool DeleteActivosFijos(ActivosFijos pActivosFijos)
        {
            return new ActivosFijosDAL().DeleteActivosFijos(pActivosFijos);
        }

        public bool EditActivosFijos(ActivosFijos pActivosFijos)
        {
            return new ActivosFijosDAL().EditActivosFijos(pActivosFijos);
        }

        public List<ActivosFijos> GetActivosFijos(ActivosFijos pActivosFijos)
        {
            return new ActivosFijosDAL().GetActivosFijos(pActivosFijos);
        }

        public List<ActivosFijos> GetAllActivosFijos()
        {
            return new ActivosFijosDAL().GetAllActivosFijos();
        }
    }
}
