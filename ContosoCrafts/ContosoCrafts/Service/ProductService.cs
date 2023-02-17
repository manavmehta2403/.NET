using ContosoCrafts.Model;
using System.Text.Json;

namespace ContosoCrafts.Service
{
	public class ProductService
	{
		private const string DirectoryPath = "data";
		private const string FilePath = "products.json";

		public IWebHostEnvironment WebHostEnvironment { get; }

		public ProductService(IWebHostEnvironment webHostEnvironment)
		{
			WebHostEnvironment = webHostEnvironment;
		}

		private string JsonFileName
		{
			get
			{
				return Path.Combine(WebHostEnvironment.WebRootPath, DirectoryPath, FilePath);
			}
		}

		public IEnumerable<Product> GetProducts()
		{
			using (var jsonReader = File.OpenText(JsonFileName))
			{
				return JsonSerializer.Deserialize<List<Product>?>(jsonReader.ReadToEnd(),
					new JsonSerializerOptions
					{
						PropertyNameCaseInsensitive = true
					});
			}
		}

		public void AddRating(string productId, int rating)
		{
			var products = GetProducts();
			var query = products.First(x => x.Equals(productId));

			if (query.Ratings == null)
			{
				query.Ratings = new List<int?> { rating };
			}
			else
			{
				var ratingList = query.Ratings.ToList();
				ratingList.Add(rating);
				query.Ratings = ratingList;
			}

			using (var writer = File.OpenWrite(JsonFileName))
			{
				JsonSerializer.Serialize<IEnumerable<Product>>
					(new Utf8JsonWriter(writer, new JsonWriterOptions
					{
						SkipValidation = true,
						Indented = true
					}), 
					products
					);
			}
		}
	}
}
