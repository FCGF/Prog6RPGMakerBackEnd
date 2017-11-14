using System;
using NHibernate;
using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate {
  public class UserRepository : AbstractRepository<long, IUser>, IUserRepository {
    public UserRepository(SessionFactory sessionFactory)
      : base(sessionFactory) {
    }

    public IUser FindByEmail(string email) {
      return Command((ISession session) => {
        return session.QueryOver<IUser>()
                        .Where(u => string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase))
                        .SingleOrDefault<IUser>();
      });
    }
  }
}
