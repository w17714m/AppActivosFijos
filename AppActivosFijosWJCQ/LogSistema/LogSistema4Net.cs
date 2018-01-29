using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using log4net;
using System.IO;
using System.Reflection;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Controllers;
using System.Web;

namespace AppActivosFijosWJCQ.LogSistema
{
    public static class LogSistema4Net
    {



        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void EscribirLog(HttpActionContext actionContext) {


            try
            {
                
                StringBuilder vLog = new StringBuilder();
                vLog.AppendLine();
                vLog.Append("*********** log " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss") + "***********");
                vLog.Append("\n Nombre Accion " + actionContext.ActionDescriptor.ActionName+"");
                try
                {
                    vLog.Append("\n El host que hizo la petición es: " + (((HttpContextBase)actionContext.Request.Properties["MS_HttpContext"]).Request.UserHostAddress).ToString());
                }
                catch (Exception)
                {
                }
                vLog.Append("\n Nombre Controller" + actionContext.ActionDescriptor.ControllerDescriptor.ControllerName);
                vLog.Append("\n Nombre Controller" + string.Join(",", actionContext.ActionArguments.ToArray()));
                vLog.Append("\n *******************************************************************************");
                log.Info(vLog.ToString());
            }
            catch (Exception)
            {
                
            }
        }

    }
}
