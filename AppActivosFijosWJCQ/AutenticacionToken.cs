using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http.Controllers;
using System.Linq;


namespace AppActivosFijosWJCQ
{
    public class AutenticacionToken: System.Web.Http.Filters.AuthorizationFilterAttribute
    {
        public bool ValidarAutorizacion { get; set; }

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var vTokenUsuario= new AutorizacionTokenCustomizado(actionContext);

            if (ValidarAutorizacion) {
                if (!vTokenUsuario.IsAuthenticated)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden, "No tiene permitido el acceso.");
                }
            }

            
            
        }
    }

    
    public class AutorizacionTokenCustomizado
    {
        public bool IsAuthenticated { get; set; }

        public AutorizacionTokenCustomizado(HttpActionContext httpContext)
        {
            try
            {
                if(httpContext.Request.Headers.GetValues("token") != null && httpContext.Request.Headers.GetValues("token").First() == GetToken())
                {
                    IsAuthenticated = true;
                }
                else
                {
                    IsAuthenticated = false;
                }
            }
            catch (Exception)
            {
                IsAuthenticated = false;
            }

        }


        protected string GetToken() {
            try
            {
                return HttpContext.Current.Session["token"].ToString();
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }

    }
}