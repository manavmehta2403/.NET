using System;
using System.Collections.Generic;
using System.IO;

namespace FilerWriter
{
  class Program
  {
    static void Main(string[] args)
    {
      DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\mehtama\OneDrive - Windmöller & Hölscher KG\Dokumente\Windmoller-Learning\Ini");
      FileInfo[] Files = dinfo.GetFiles("DAT_*.ini");
      foreach (FileInfo file in Files)
      {
        Console.WriteLine(file.Name);
      }

      //HashSet allows only the unique values to the list
      HashSet<int> uniqueList = new HashSet<int>();

      var a = uniqueList.Add(1);
      var b = uniqueList.Add(2);
      var c = uniqueList.Add(3);
      var d = uniqueList.Add(2); // should not be added to the list but will not crash the app

      foreach (var item in uniqueList)
      {
        Console.WriteLine(item);
      }
      

      //Dictionary allows only the unique Keys to the list, Values can be repeated
      Dictionary<int, string> dict = new Dictionary<int, string>();

      dict.Add(1, "Happy");
      dict.Add(2, "Smile");
      dict.Add(3, "Happy");
      dict.Add(2, "Sad"); // should be failed // Run time error "An item with the same key has already been added." App will crash
      Console.WriteLine(dict);
    }
  }
}
