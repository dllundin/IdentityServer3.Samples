﻿using System.Web.Http;
using System.Web.Http.Cors;

namespace SampleAspNetWebApi
{
    public static class WebApiConfig
    {
        public static HttpConfiguration Register()
        {
            // Web API configuration and services
            var config = new HttpConfiguration();
            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.EnableCors(new EnableCorsAttribute("http://localhost:21575", "accept, authorization", "GET"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}",
                defaults: new { id = RouteParameter.Optional }
            );

            return config;
        }
    }
}