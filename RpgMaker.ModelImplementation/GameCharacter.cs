using System.Collections.Generic;
using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public class GameCharacter : Entity<long>, IGameCharacter {
    public virtual IPlayer Player { get; set; }
    public virtual IChronicle Chronicle { get; set; }
    public virtual IList<IAttribute> Attributes { get; set; }
    public virtual int Experience { get; set; }
  }
}
