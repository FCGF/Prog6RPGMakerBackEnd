using System;
using NHibernate;
using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate {
  public abstract class AbstractRepository<TId, TEntity> : IRepository<TId, TEntity> where TEntity : class, IEntity<TId> {

    private readonly SessionFactory sessionFactory;

    protected AbstractRepository(SessionFactory sessionFactory) {
      this.sessionFactory = sessionFactory;
    }

    protected ISession Session {
      get { return sessionFactory.OpenSession(); }
    }

    public TEntity Find(TId id) {
      return Session.Get<TEntity>(id);
    }

    public TEntity Save(TEntity entity) {
      return Session.Save(entity) as TEntity;
    }

    public void Update(TEntity entity) {
      Session.Update(entity);
    }

    public TEntity SaveOrUpdate(TEntity entity) {
      Session.SaveOrUpdate(entity);
      return Find(entity.Id);
    }

    public void Delete(TEntity entity) {
      Session.Delete(entity);
    }

    protected T Command<T>(Func<ISession, T> function) {
      T result = default(T);

      using (ISession session = Session) {
        using (ITransaction transaction = session.BeginTransaction()) {
          try {
            transaction.Begin();
            result = function(session);
            transaction.Commit();
          } catch (Exception e) {
            transaction.Rollback();
          }
        }
      }

      return result;
    }

  }
}
