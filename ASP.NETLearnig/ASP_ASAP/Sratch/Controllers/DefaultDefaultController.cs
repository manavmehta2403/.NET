using Microsoft.AspNetCore.Mvc;

namespace MiddlewareLuchSettingsAddMVCContainers.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
