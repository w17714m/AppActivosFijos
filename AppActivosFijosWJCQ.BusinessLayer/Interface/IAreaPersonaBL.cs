
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppActivosFijosWJCQ.Entity.Model;

namespace AppActivosFijosWJCQ.BusinessLayer.Interface
{
    public interface IAreaPersonaBL
    {
        List<AreaPersona> GetAllAreaPersona();
        List<AreaPersona> GetAreaAreaPersona(AreaPersona pAreaPersona);
        bool AddAreaPersona(AreaPersona pAreaPersona);
        bool EditAreaPersona(AreaPersona pAreaPersona);
        bool DeleteAreaPersona(AreaPersona pAreaPersona);
    }
}
