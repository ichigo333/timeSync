using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace timeSync {
  class MainClass {
    public static void Main(string[] args) {

      var stream = new StreamReader("E:\\test.json");
      var json = stream.ReadToEnd().ToString();

      JArray tokens = JArray.Parse(json);
      foreach (var token in tokens) {
        Console.WriteLine(token.SelectToken("id").ToString() + " : " + (DateTime)token.SelectToken("target_date") + " : " + token.SelectToken("label"));
      }
        	
      Console.ReadLine();

    }
  }
}
