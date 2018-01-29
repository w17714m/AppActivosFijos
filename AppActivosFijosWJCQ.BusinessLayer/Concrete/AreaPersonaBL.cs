using AppActivosFijosWJCQ.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.BusinessLayer.Interface;
using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;
using AppActivosFijosWJCQ.DAL;

namespace AppActivosFijosWJCQ.BusinessLayer.Concrete
{
    public class AreaPersonaBL : IAreaPersonaBL
    {
        public bool AddAreaPersona(AreaPersona pAreaPersona)
        {
            return new AreaPersonaDAL().AddAreaPersona(pAreaPersona);
        }

        public bool DeleteAreaPersona(AreaPersona pAreaPersona)
        {
            return new AreaPersonaDAL().DeleteAreaPersona(pAreaPersona);
        }

        public bool EditAreaPersona(AreaPersona pAreaPersona)
        {
            return new AreaPersonaDAL().EditAreaPersona(pAreaPersona);
        }

        public List<AreaPersona> GetAllAreaPersona()
        {
            return new AreaPersonaDAL().GetAllAreaPersona();
        }

        public List<AreaPersona> GetAreaAreaPersona(AreaPersona pAreaPersona)
        {
            return new AreaPersonaDAL().GetAreaAreaPersona(pAreaPersona);
        }
    }
}
