using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
  public class RouterRootElements
  {
    public readonly string Jsonrpc = "2.0";
    public readonly int Id = 1;
    public readonly string Method = "call";

    public List<object> @Params { get; set; } = new List<object>();
  }
}
