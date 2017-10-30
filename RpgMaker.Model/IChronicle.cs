using System.Collections.Generic;
using RpgMaker.Model.Enum;

namespace RpgMaker.Model {
  public interface IChronicle : IEntity<long> {
    string Name { get; set; }
    IList<IPlayer> Players { get; set; }
    GameType GameType { get; set; }
    IPlayer GameMaster { get; set; }
  }
}
