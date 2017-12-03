using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using RpgMaker.Data;
using RpgMaker.Data.NHibernate;
using RpgMaker.Service;
using RpgMaker.ServiceImplementation;
using SimpleInjector;

namespace Prog6RpgMakerBackEnd {
  public class WebApiApplication : System.Web.HttpApplication {
    protected void Application_Start() {
      AreaRegistration.RegisterAllAreas();
      GlobalConfiguration.Configure(WebApiConfig.Register);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);

      Container container = new Container();

      container.RegisterSingleton<IAttributeRepository, AttributeRepository>();
      container.RegisterSingleton<ICharacterSheetRepository, CharacterSheetRepository>();
      container.RegisterSingleton<IChronicleRepository, ChronicleRepository>();
      container.RegisterSingleton<IGameCharacterRepository, IGameCharacterRepository>();
      container.RegisterSingleton<IPlayerRepository, PlayerRepository>();
      container.RegisterSingleton<IUserRepository, UserRepository>();

      container.RegisterSingleton<IAttributeService, AttributeService>();

      container.Verify();

    }
  }
}
