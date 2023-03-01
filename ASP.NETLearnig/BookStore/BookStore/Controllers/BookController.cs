using BookStore.Models;
using BookStore.Repositary;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
  public class BookController : Controller
  {

    private readonly BookRespositary _bookRespositary;

    public BookController() 
    {
      _bookRespositary = new BookRespositary();
    } 
    public ViewResult GetAllBooks()
    {
      var data = _bookRespositary.GetAllBooks();

      return View(data);
    }

    public BookModel GetBook(int id)
    {
      return _bookRespositary.GetBook(id);
    }

    public List<BookModel> SearchBooks(string book, string author)
    {
      return _bookRespositary.SearchBook(book,author);
    }
  }
}
