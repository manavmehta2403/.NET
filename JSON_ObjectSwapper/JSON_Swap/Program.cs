using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace JSON_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var json = File.ReadAllText("../Event_99.json");
                System.Console.WriteLine(json);
                var options = new JsonDocumentOptions
                {
                    AllowTrailingCommas = true
                };

                System.Console.WriteLine(options);

                using (JsonDocument document = JsonDocument.Parse(json,options))
                {
                    foreach(JsonElement element in document.RootElement.EnumerateArray())
                    {
                        System.Console.WriteLine(element.GetProperty("_ts"));
                    }
                }
            }
            catch (Exception e)
            {
                
                System.Console.WriteLine("The file could not be read");
                System.Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
