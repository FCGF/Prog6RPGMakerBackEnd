using System;
using System.Collections.Generic;
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

    public IEnumerable<TEntity> FindAll() {
      return Session.QueryOver<TEntity>().Future();
    }

    public TEntity Save(TEntity entity) {
      return Command((ISession session) => {
        return session.Save(entity) as TEntity;
      });
    }

    public void Update(TEntity entity) {
      Command((ISession session) => {
        session.Update(entity);
        return entity;
      });
    }

    public TEntity SaveOrUpdate(TEntity entity) {
      return Command((ISession session) => {
        session.SaveOrUpdate(entity);
        return Find(entity.Id);
      });
    }

    public void Delete(TEntity entity) {
      return Command((ISession session) => {
        session.Delete(entity);
        return entity;
      });
    }

    protected T Command<T>(Func<ISession, T> function) {
      T result = default(T);

      using (ISession session = Session) {
        using (ITransaction transaction = session.BeginTransaction()) {
          try {
            transaction.Begin();
            result = function(session);
            transaction.Commit();
          } catch (Exception) {
            transaction.Rollback();
            throw;
          }
        }
      }

      return result;
    }

  }
}
