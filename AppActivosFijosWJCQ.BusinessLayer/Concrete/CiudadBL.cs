using AppActivosFijosWJCQ.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;
using AppActivosFijosWJCQ.DAL;

namespace AppActivosFijosWJCQ.BusinessLayer.Concrete
{
    public class CiudadBL : ICiudadBL
    {
        public bool AddCiudad(Ciudad pCiudad)
        {
            return new CiudadDAL().AddCiudad(pCiudad);
        }

        public bool DeleteCiudad(Ciudad pCiudad)
        {
            return new CiudadDAL().DeleteCiudad(pCiudad);
        }

        public bool EditCiudad(Ciudad pCiudad)
        {
            return new CiudadDAL().EditCiudad(pCiudad);
        }

        public List<Ciudad> GetAllCiudad()
        {
            return new CiudadDAL().GetAllCiudad();
        }

        public List<Ciudad> GetCiudad(Ciudad pCiudad)
        {
            return new CiudadDAL().GetCiudad(pCiudad);
        }
    }
}
