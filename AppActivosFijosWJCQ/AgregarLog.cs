using AppActivosFijosWJCQ.LogSistema;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace AppActivosFijosWJCQ
{
    public class AgregarLog: ActionFilterAttribute
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            LogSistema4Net.EscribirLog(actionContext);
        }
    }
}