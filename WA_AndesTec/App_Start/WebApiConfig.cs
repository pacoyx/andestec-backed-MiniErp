using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WA_AndesTec
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();
            config.EnableCors();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{ide}/{id}",
                defaults: new { ide = RouteParameter.Optional, id = RouteParameter.Optional }
            );
            
            // Configure Web API to return JSON
            //config.Formatters.JsonFormatter
            //.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));


        }
    }
}
