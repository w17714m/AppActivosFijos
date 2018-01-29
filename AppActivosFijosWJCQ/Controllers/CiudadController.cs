using AppActivosFijosWJCQ.BusinessLayer.Concrete;
using AppActivosFijosWJCQ.BusinessLayer.Interface;
using AppActivosFijosWJCQ.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppActivosFijosWJCQ.Controllers
{
    [AgregarLog]
    public class CiudadController : ApiController
    {
        ICiudadBL CiudadBL;

        public CiudadController(ICiudadBL CiudadBL)
        {
            this.CiudadBL = CiudadBL;
        }

        public bool AddCiudad(Ciudad pCiudad)
        {
            return CiudadBL.AddCiudad(pCiudad);
        }

        public bool DeleteCiudad(Ciudad pCiudad)
        {
            return  CiudadBL.DeleteCiudad(pCiudad);
        }

        public bool EditCiudad(Ciudad pCiudad)
        {
            return  CiudadBL.EditCiudad(pCiudad);
        }

        public IEnumerable<Ciudad> GetAllCiudad()
        {
            return  CiudadBL.GetAllCiudad();
        }

        public IEnumerable<Ciudad> GetCiudad(Ciudad pCiudad)
        {
            return  CiudadBL.GetCiudad(pCiudad);
        }

    }
}
