using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate {
  public class PlayerRepository : AbstractRepository<long, IPlayer>, IPlayerRepository {
    public PlayerRepository(SessionFactory sessionFactory)
      : base(sessionFactory) {
    }

  }
}
