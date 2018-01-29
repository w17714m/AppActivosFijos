using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.Entity.Model;
using AppActivosFijosWJCQ.Entity;

namespace AppActivosFijosWJCQ.BusinessLayer.Interface
{
    public interface IAreaPersona_CiudadBL
    {
        List<AreaPersona_Ciudad> GetAllAreaPersona_Ciudad();
        List<AreaPersona_Ciudad> GetAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad);
        bool AddAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad);
        bool EditAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad);
        bool DeleteAreaPersona_Ciudad(AreaPersona_Ciudad pAreaPersona_Ciudad);
    }
}
