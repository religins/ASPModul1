using System.Web.Mvc;

namespace asp_mvc_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Welcome() { return View(); }
    }
}