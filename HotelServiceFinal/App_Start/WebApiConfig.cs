using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HotelServiceFinal
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Quitar retorno en XML y retornar todo en Json
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Evitar la referencia circular.
            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
