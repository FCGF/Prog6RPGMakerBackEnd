using System.Web.Http.Cors;
using System.Web.Mvc;

namespace Prog6RpgMakerBackEnd.Controllers {

  [EnableCors("*", "*", "*")]
  public class HomeController : Controller {
    public ActionResult Index() {
      ViewBag.Title = "Home Page";

      return Redirect("/swagger/ui/index");
    }
  }
}
