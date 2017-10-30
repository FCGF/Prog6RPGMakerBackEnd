using System.Collections.Generic;

namespace RpgMaker.Model {
  public interface IPlayer : IEntity<long> {

    string Name { get; set; }
    IList<IChronicle> Chronicles { get; set; }
    IList<IGameCharacter> GameCharacters { get; set; }

  }
}
