using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppActivosFijosWJCQ;
using AppActivosFijosWJCQ.Controllers;

namespace AppActivosFijosWJCQ.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            
           HomeController controller = new HomeController();

            
           ViewResult result = controller.Index() as ViewResult;

           
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ViewBag.Title);
        }
    }
}
