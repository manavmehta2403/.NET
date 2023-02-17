using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
  public class RouterCredentials : RouterRootElements
  {
    #region constant
    private const string Username = "admin";
    private const string PasswordHash = "W&Hgroup1869"; //W&Hgroup1869 //a2c1f06e1fe6f1cfc2603b207deb0be2
    #endregion


    readonly IReadOnlyList<string> Parameters = new List<string>()
    { "00000000000000000000000000000000",
      "session",
      "login"
    };

    readonly IReadOnlyDictionary<string, string> Credentials = new Dictionary<string, string>()
    {
      {"username", Username},
      {"password", PasswordHash},
    };


    #region ctor
    public RouterCredentials()
    {
      Params.AddRange(Parameters);
      Params.Add(Credentials);
    }
    #endregion
  }
}
