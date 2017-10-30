using System.Collections.Generic;
using RpgMaker.Model;

namespace RpgMaker.Data {
  public interface IChronicleRepository : IRepository<long, IChronicle> {

    IList<IChronicle> FindByPlayersContains(IPlayer player);

    IList<IChronicle> FindByGameMaster(IPlayer gameMaster);

  }
}
