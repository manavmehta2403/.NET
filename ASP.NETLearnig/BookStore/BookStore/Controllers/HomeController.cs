using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace BookStore.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    [ViewData]
    public string HomeString { get; set; }

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public ViewResult Index()
    {
      //VieBag can only be used inside one view type inside the controller
      //Send values to the view
      ViewBag.Value = 123;
      ViewBag.DynamicData = new { id = 1 };

      //Send any dynamic data 
      dynamic data = new ExpandoObject();
      data.value = 23;
      ViewBag.Data = data;

      //Any type
      ViewBag.Type = new BookModel { Id = 10, Title = "ViewBag" };

      //ViewData in Controller
      ViewData["bookCont"] = new BookModel { Id = 100, Title = "ViewDataController" };


      //ViewData Attribute
      HomeString = "IndexString";
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }


    public ViewResult AboutUs()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}