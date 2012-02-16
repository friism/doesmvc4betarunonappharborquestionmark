using System.Reflection;
using System.Web.Mvc;

namespace Mvc4BetaApplication.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Version = Assembly.GetAssembly(typeof(Controller)).GetName().Version.ToString();
			return View();
		}
	}
}
