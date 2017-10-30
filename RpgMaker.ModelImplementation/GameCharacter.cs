using System.Collections.Generic;
using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public class GameCharacter : Entity<long>, IGameCharacter {
    public IPlayer Player { get; set; }
    public IChronicle Chronicle { get; set; }
    public IList<IAttribute> Attributes { get; set; }
    public int Experience { get; set; }
  }
}
