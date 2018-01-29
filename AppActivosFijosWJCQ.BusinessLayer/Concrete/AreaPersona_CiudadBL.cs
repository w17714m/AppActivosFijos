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
    public class AreaPersona_CiudadBL : IAreaPersona_CiudadBL
    {
        public bool AddAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            return new AreaPersonaCiudadDAL().AddAreaPersona_Ciudad(pAreaPersona_Ciudad);
        }

        public bool DeleteAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            return new AreaPersonaCiudadDAL().DeleteAreaPersona_Ciudad(pAreaPersona_Ciudad);
        }

        public bool EditAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            return new AreaPersonaCiudadDAL().EditAreaPersona_Ciudad(pAreaPersona_Ciudad);
        }

        public List<AreaPersona_Ciudad> GetAllAreaPersona_Ciudad()
        {
            return new AreaPersonaCiudadDAL().GetAllAreaPersona_Ciudad();
        }

        public List<AreaPersona_Ciudad> GetAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad)
        {
            return new AreaPersonaCiudadDAL().GetAreaPersona_Ciudad(pAreaPersona_Ciudad);
        }
    }
}
