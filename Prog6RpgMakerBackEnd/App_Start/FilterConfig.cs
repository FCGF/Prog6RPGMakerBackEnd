using System.Web.Mvc;

namespace Prog6RpgMakerBackEnd {
  public class FilterConfig {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
