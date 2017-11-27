using System;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;
using Owin;
using Prog6RpgMakerBackEnd.Models;
using Prog6RpgMakerBackEnd.Providers;

namespace Prog6RpgMakerBackEnd {
  public partial class Startup {
    public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }

    public static string PublicClientId { get; private set; }

    // For more information on configuring authentication, please visit https://go.microsoft.com/fwlink/?LinkId=301864
    public void ConfigureAuth(IAppBuilder app) {
      // Configure the db context and user manager to use a single instance per request
      app.CreatePerOwinContext(ApplicationDbContext.Create);
      app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

      // Enable the application to use a cookie to store information for the signed in user
      // and to use a cookie to temporarily store information about a user logging in with a third party login provider
      app.UseCookieAuthentication(new CookieAuthenticationOptions());
      app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

      // Configure the application for OAuth based flow
      PublicClientId = "self";
      OAuthOptions = new OAuthAuthorizationServerOptions {
        TokenEndpointPath = new PathString("/Token"),
        Provider = new ApplicationOAuthProvider(PublicClientId),
        AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
        AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
        // In production mode set AllowInsecureHttp = false
        AllowInsecureHttp = true
      };

      // Enable the application to use bearer tokens to authenticate users
      app.UseOAuthBearerTokens(OAuthOptions);

      // Uncomment the following lines to enable logging in with third party login providers
      app.UseMicrosoftAccountAuthentication(
          clientId: "54d4be65-7e36-4be4-a76e-65c7f538cd1f",
          clientSecret: "xugrB3[#-uarCREJDN0618]");

      app.UseTwitterAuthentication(
          consumerKey: "zvl5knTBUP9sydZdlIXQOvlgY",
          consumerSecret: "Lq7ZkplxZFMdEvLpQMU9TiLKIBmyWVjZ4gQSZs4Qh6EiBbf1yo");

      //app.UseFacebookAuthentication(
      //    appId: "",
      //    appSecret: "");

      //One Click
      app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions() {
        ClientId = "582684262746-g6ognjvpivfk8j0vrtnl4qphbm1c3eq7.apps.googleusercontent.com",
        ClientSecret = "H6fL-xB7M3S0P3mGIViKpVV0"
      });
    }
  }
}
