using System.Collections.Generic;
using System.Linq;
using NHibernate;
using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate {
  public class ChronicleRepository : AbstractRepository<long, IChronicle>, IChronicleRepository {
    public ChronicleRepository(SessionFactory sessionFactory)
      : base(sessionFactory) {
    }

    public IList<IChronicle> FindByGameMaster(IPlayer gameMaster) {
      return Command((ISession session) => {
        return session.QueryOver<IChronicle>()
                        .Where(c => c.GameMaster.Id == gameMaster.Id)
                        .List<IChronicle>();
      });
    }

    public IList<IChronicle> FindByPlayersContains(IPlayer player) {
      return Command((ISession session) => {
        return session.QueryOver<IChronicle>()
                        .Where(c => c.Players.Select(p => p.Id).Contains(player.Id))
                        .List<IChronicle>();
      });
    }
  }
}
