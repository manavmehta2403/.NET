using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsoleApp
{
  public class Program
  {
    static void Main(string[] args)
    {
      Consume_WebAPI().Wait();
      Console.ReadKey();
    }

    static async Task Consume_WebAPI()
    {
      var client = new HttpClient();
      client.BaseAddress = new Uri("https://portal.ixon.cloud:443/");
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

      HttpResponseMessage response = await client.GetAsync("api/");
      if (response.IsSuccessStatusCode)
      {
        dynamic result = await response.Content.ReadAsStringAsync();

        Rootobject rootobject = JsonConvert.DeserializeObject<Rootobject>(result);

        foreach (var item in rootobject.Data)
        {
          Console.WriteLine("{0}\n{1}\n\n", item.Rel, item.Href);
        }
      }
    }
  }



  public class Rootobject
  {
    public string Type { get; set; }
    public List<Datum> Data { get; set; }
    public object MoreAfter { get; set; }
    public string Status { get; set; }
  }

  public class Datum
  {
    public string Rel { get; set; }
    public string Href { get; set; }
  }

}
