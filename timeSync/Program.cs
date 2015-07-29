using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace timeSync {
  class MainClass {
    public static void Main(string[] args) {

      var stream = new StreamReader("E:\\test1.json");
      var json = stream.ReadToEnd().ToString();
      var counter = 0;

      JArray tokens = JArray.Parse(json);
      foreach (var token in tokens) {
        var note = new Note();
        note.Id = token.SelectToken("id").ToString();
        note.TargetDate = (DateTime)token.SelectToken("target_date");
        note.Label = token.SelectToken("label").ToString();

        counter++;

        Console.WriteLine(note.ToString());
      }

      Console.WriteLine("processed: " + counter + " records");
      Console.ReadLine();

    }
  }
}
