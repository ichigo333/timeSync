using System;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;
using System.Xml;
//using System.Xml.Serialization;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace timeSync {
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("Hello World!");

      var datacontractserializer = new DataContractJsonSerializer(typeof(ListOfNotes));
      var stream = new StreamReader("E:\\test.json");
      var json = stream.ReadToEnd().ToString();

      JArray tokens = JArray.Parse(json);
      foreach (var token in tokens) {
        Console.WriteLine(token.SelectToken("id").ToString() + " : " + (DateTime)token.SelectToken("target_date") + " : " + token.SelectToken("label"));
      }

     
      //var test = (Note)datacontractserializer.ReadObject(fileStream);
	
      Console.ReadLine();

    }

    [DataContract]
    public class ListOfNotes {
      [DataMember]
      private List<Note> notes = new List<Note>();

      public void addNote(Note note) {
        notes.Add(note);
      }
    }

    [DataContract]
    public class Note {
      [DataMember]
      public string type;
      [DataMember]
      public string id;
    }
  }
}
