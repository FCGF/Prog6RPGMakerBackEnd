using System.Collections.Generic;
using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public class Player : Entity<long>, IPlayer {
    public string Name { get; set; }
    public IList<IChronicle> Chronicles { get; set; }
    public IList<IGameCharacter> GameCharacters { get; set; }
  }
}
