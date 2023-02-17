using ContosoCrafts.Model;
using ContosoCrafts.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		public ProductsController(ProductService productService) 
		{
			ProductService = productService;
		}

		public ProductService ProductService { get; private set; }

		[HttpGet]
		public IEnumerable<Product> Get()
		{
			return ProductService.GetProducts();
		}

		[Route("Rate")]
		[HttpGet]
		public ActionResult Get([FromQuery] string Id, [FromQuery]  int Rating)
		{
			ProductService.AddRating(Id, Rating);
			return Ok();
		}
	}
}
