using System.Security.Claims;
using System.Web.Mvc;

namespace aspnet4_sample1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.AccessToken = ClaimsPrincipal.Current.FindFirst("access_token")?.Value;
			ViewBag.IdToken = ClaimsPrincipal.Current.FindFirst("id_token")?.Value;

			return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}