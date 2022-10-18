using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
  /// <summary>
  /// Person class
  /// </summary>
  public class Person
  {
    /// <summary>
    /// ID prop
    /// </summary>
    public int Id { get; set; } = 0;

    /// <summary>
    /// First name
    /// </summary>
    public string FristName { get; set; } = "";

    /// <summary>
    /// Last Name
    /// </summary>
    public string LastName { get; set; } = "";

  }
}