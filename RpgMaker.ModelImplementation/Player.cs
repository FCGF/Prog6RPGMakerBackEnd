using System.Collections.Generic;
using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public class Player : Entity<long>, IPlayer {
    public virtual string Name { get; set; }
    public virtual IList<IChronicle> Chronicles { get; set; }
    public virtual IList<IGameCharacter> GameCharacters { get; set; }
  }
}
