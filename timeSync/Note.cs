using System;

namespace timeSync {
  public class Note {
    public string Id { get; set; }
    public string Label { get; set; }
    public DateTime TargetDate { get; set; }

    public override string ToString() {
      return string.Format("{0} : {1} : {2}", Id, TargetDate, Label);
    }

  }
}

