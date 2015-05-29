using System;
using Newtonsoft.Json.Linq;

namespace timeSync {
  public interface INoteTranslator {
    Note Translate(JObject jsonObject);
  }

}

