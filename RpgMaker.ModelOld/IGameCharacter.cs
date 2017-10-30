using System.Collections.Generic;

namespace RpgMaker.Model {
  public interface IGameCharacter : IEntity<long> {

    IPlayer Player { get; set; }
    IChronicle Chronicle { get; set; }
    IList<IAttribute> Attributes { get; set; }
    int Experience { get; set; }

  }
}
