using System;
using Newtonsoft.Json.Linq;

namespace timeSync {
  public class NoteTranslator : INoteTranslator {
    public Note Translate(JObject jsonObject) {
      return new Note();
    }
  }
}

