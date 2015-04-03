using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GoodSamaritan
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //ADDED
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);

            config.MapHttpAttributeRoutes();


            //config.Routes.MapHttpRoute("GetMyCourses", "api/mycourses/{userid}/{token}", new { controller = "courses", action = "getcourses" });

            config.Routes.MapHttpRoute("PostReportSearch", "api/Reports", new { controller = "reports", action = "postsearch" });

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
        }
    }
}
