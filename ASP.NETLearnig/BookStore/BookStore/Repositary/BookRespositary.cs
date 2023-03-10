using BookStore.Models;

namespace BookStore.Repositary
{
  public class BookRespositary
  {
    public List<BookModel> GetAllBooks()
    {
      return DataSource();
    }
    public BookModel GetBook(int id)
    {
      return DataSource().FirstOrDefault(x => x.Id == id);
    }
    //public void UpdateBook(BookModel book) 
    //{ 

    //}
    //public void DeleteBook(int id) 
    //{

    //}
    public List<BookModel> SearchBook(string book, string author)
    {
      return DataSource().Where(x => x.Title.Contains(book) || x.Author.Contains(author)).ToList();
    }

    private List<BookModel> DataSource()
    {
      return new List<BookModel>()
      {
        new BookModel() {Id = 1, Title="MVC" ,Author = "Raja"},
        new BookModel() {Id = 2, Title="MVVM" ,Author = "Saja"},
        new BookModel() {Id = 3, Title="WebApp" ,Author = "Baja"},
        new BookModel() {Id = 4, Title="OSApp" ,Author = "Taja"},
      };
    }
  }
}
