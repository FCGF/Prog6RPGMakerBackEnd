using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate {
  public class GameCharacterRepository : AbstractRepository<long, IGameCharacter>, IGameCharacterRepository {
    public GameCharacterRepository(SessionFactory sessionFactory)
      : base(sessionFactory) {
    }

  }
}
