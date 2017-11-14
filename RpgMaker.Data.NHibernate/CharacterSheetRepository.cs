using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate {
  public class CharacterSheetRepository : AbstractRepository<long, ICharacterSheet>, ICharacterSheetRepository {
    public CharacterSheetRepository(SessionFactory sessionFactory)
      : base(sessionFactory) {
    }

  }
}
