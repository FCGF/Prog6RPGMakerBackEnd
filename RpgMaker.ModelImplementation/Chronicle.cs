using System.Collections.Generic;
using RpgMaker.Model;
using RpgMaker.Model.Enum;

namespace RpgMaker.ModelImplementation {
  public class Chronicle : Entity<long>, IChronicle {
    public virtual string Name { get; set; }
    public virtual IList<IPlayer> Players { get; set; }
    public virtual GameType GameType { get; set; }
    public virtual IPlayer GameMaster { get; set; }
  }
}
