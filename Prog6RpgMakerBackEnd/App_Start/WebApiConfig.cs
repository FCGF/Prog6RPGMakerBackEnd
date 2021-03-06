﻿using System.Web.Http;
using Microsoft.Owin.Security.OAuth;

namespace Prog6RpgMakerBackEnd {
  public static class WebApiConfig {
    public static void Register(HttpConfiguration config) {
      // Web API configuration and services
      // Configure Web API to use only bearer token authentication.
      config.SuppressDefaultHostAuthentication();
      config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

      config.EnableCors();

      // Web API routes
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
    }
  }
}
