using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate {
  public class AttributeRepository : AbstractRepository<long, IAttribute>, IAttributeRepository {
    public AttributeRepository(SessionFactory sessionFactory)
      : base(sessionFactory) {
    }

  }
}
