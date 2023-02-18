using Microsoft.AspNetCore.Mvc;

namespace ASP.NETConsole.Controllers
{
	public class HomeController : Controller
	{
		public string Index 
		{ 
			get
			{
				return "index";
			}
		}
	}
}
