using System.Collections.Generic;
using RpgMaker.Model;
using RpgMaker.Model.Enum;

namespace RpgMaker.ModelImplementation {
  public class Chronicle : Entity<long>, IChronicle {
    public string Name { get; set; }
    public IList<IPlayer> Players { get; set; }
    public GameType GameType { get; set; }
    public IPlayer GameMaster { get; set; }
  }
}
