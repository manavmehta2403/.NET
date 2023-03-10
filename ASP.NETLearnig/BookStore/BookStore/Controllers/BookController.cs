using BookStore.Models;
using BookStore.Repositary;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace BookStore.Controllers
{
	public class BookController : Controller
	{

		private readonly BookRespositary _bookRespositary;

		//Better way oƒusing viewData
		[ViewData]
    public string Title { get; set; }

		public BookController()
		{
			_bookRespositary = new BookRespositary();
		}
		public ViewResult GetAllBooks()
		{
			Title = "Get All books";

			dynamic data = new ExpandoObject();
			data.Book = _bookRespositary.GetAllBooks();
			data.Type = "CS";


			return View(data);
		}

		public ViewResult GetBook(int id)
		{
			Title = "GetBook";
			var data = _bookRespositary.GetBook(id);
			return View(data);
		}

		public List<BookModel> SearchBooks(string book, string author)
		{
			return _bookRespositary.SearchBook(book, author);
		}
	}
}
