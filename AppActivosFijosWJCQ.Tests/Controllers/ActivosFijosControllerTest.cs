using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppActivosFijosWJCQ;
using AppActivosFijosWJCQ.Controllers;
using AppActivosFijosWJCQ.Entity;
using AppActivosFijosWJCQ.Entity.Model;
using AppActivosFijosWJCQ.BusinessLayer.Concrete;
using System.Web.Script.Serialization;


namespace AppActivosFijosWJCQ.Tests.Controllers
{
    [TestClass]
    public class ActivosFijosControllerTest
    {
        [TestMethod]
        public void AddActivosFijos()
        {
           
            
            ActivosFijosController af = new ActivosFijosController(new ActivosFijosBL());
            af.Request = new HttpRequestMessage();
            af.Configuration = new HttpConfiguration();

            ActivosFijos vAf = new ActivosFijos()
            {
                Alto = 3,
                Ancho = 3,
                AreaPersona = new AreaPersona() { Id_AreaPersona = 1},
                EstadoActual =  new EstadoActual() { Id_EstadoActual = 1},
                Descripcion = "Descripcion",
                FechaBaja = "2017-01-02 00:00:00",
                FechaCompra = "2017-01-02 00:00:00",
                Largo = 3,
                Nombre = "nombre test",
                NumeroInterno = "numero interno",
                Peso = 10,
                Serial = "Serial",
                Tipo = "1232132",
                ValorCompra = decimal.Parse("456445")
            };


            var retorno = af.AddActivosFijos(vAf);

            Assert.IsNotNull(retorno);
            Assert.IsTrue(retorno.IsSuccessStatusCode);
            
        }

        [TestMethod]
        public void GetAllActivosFijos()
        {
            ActivosFijosController controller = new ActivosFijosController(new ActivosFijosBL());
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            ActivosFijos vAf = new ActivosFijos()
            {
                Alto = 3,
                Ancho = 3,
                AreaPersona = new AreaPersona() { Id_AreaPersona = 1 },
                EstadoActual = new EstadoActual() { Id_EstadoActual = 1 },
                Descripcion = "Descripcion",
                FechaBaja = "2017-01-02 00:00:00",
                FechaCompra = "2017-01-02 00:00:00",
                Largo = 3,
                Nombre = "nombre test",
                NumeroInterno = "numero interno",
                Peso = 10,
                Serial = "Serial",
                Tipo = "1232132",
                ValorCompra = decimal.Parse("456445")
            };
            var result = controller.GetAllActivosFijos();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.IsSuccessStatusCode);
        }
    }
}
