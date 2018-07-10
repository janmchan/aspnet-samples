using aspnet4_sample1.Models;
using System.Configuration;
using System.Security.Claims;
using System.Web.Mvc;

namespace aspnet4_sample1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
			var model = new OAuth2Model
			{
				Audience = ConfigurationManager.AppSettings["resourceOwnerUrl"]
			};
            ViewBag.AccessToken = ClaimsPrincipal.Current.FindFirst("access_token")?.Value;
			ViewBag.IdToken = ClaimsPrincipal.Current.FindFirst("id_token")?.Value;
			ViewBag.Name = ClaimsPrincipal.Current.FindFirst("name")?.Value;
			ViewBag.RefreshToken = ClaimsPrincipal.Current.FindFirst("refresh_token")?.Value;

			return View(model);
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