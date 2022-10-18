using API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace API.Controllers
{
  /// <summary>
  /// People's Controller it is used to have all the information about the peeps
  /// </summary>
  public class PeopleController : ApiController
  {

    List<Person> people = new List<Person>();

    /// <summary>
    /// ctor
    /// </summary>
    public PeopleController()
    {
      people.Add(new Person { FristName = "Raj", LastName = "Verma", Id = 1 });
      people.Add(new Person { FristName = "Trip", LastName = "Pretty", Id = 2 });
      people.Add(new Person { FristName = "Vihal", LastName = "Lok", Id = 3 });
    }

    /// <summary>
    /// It gives the first names of the peeps
    /// </summary>
    /// <param name="userId">user id</param>
    /// <param name="age">age</param>
    /// <returns>string of list of the peeps first name</returns>
    [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
    [HttpGet]
    public  List<string> GetFirstNames(int userId, int age)
    {
      var output = new List<string>();

      foreach (var f in people)
      {
        output.Add(f.FristName);
      }

      return output;
    }

    // GET: api/People
    /// <summary>
    /// Get all the details of the peeps
    /// </summary>
    /// <returns></returns>
    public List<Person> Get()
    {
      return people;
    }

    // GET: api/People/5
    public Person Get(int id)
    {
      return people.Where(x => x.Id == id).First();
    }

    // POST: api/People
    public void Post(Person val)
    {
      people.Add(val);
    }

    //// PUT: api/People/5
    //public void Put(int id, [FromBody]string value)
    //{
    //}

    // DELETE: api/People/5
    public void Delete(int id)
    {
    }
  }
}
