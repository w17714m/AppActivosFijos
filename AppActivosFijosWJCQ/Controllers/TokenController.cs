using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace AppActivosFijosWJCQ.Controllers
{
    public class TokenController : ApiController
    {

        [HttpGet]
        [Route("apigeneratetoken/gettoken")]
        public string GetToken()
        {
            HttpContext.Current.Session["token"] = Guid.NewGuid();
            return HttpContext.Current.Session["token"].ToString();
        }

        [HttpGet]
        [Route("apigeneratetoken/ActualToken")]
        public string ActualToken()
        {

            try
            {
                string vTokenActual = HttpContext.Current.Session["token"].ToString();
                return vTokenActual;
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }

    }
}
