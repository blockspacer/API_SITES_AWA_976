using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Roblox.Web.Util;
using System.Web.Routing;

namespace Roblox.GamePersistence.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            MvcHandler.DisableMvcResponseHeader = true;
        }

        protected void Application_Error()
        {
            // Make status code helpers for these in Roblox.Web.Util
            var ex = Server.GetLastError();
            Errors.RespondWithAHttpError(Response, ex);
            return;
        }
    }
}
