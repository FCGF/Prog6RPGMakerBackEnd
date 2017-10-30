using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate {
  public abstract class AbstractRepository<TId, TEntity> : IRepository<TId, TEntity> where TEntity : class, IEntity<TId> {

    protected ISession Session {
      get {
        NHibernateUtil.
      }
    }

    public TEntity Find(TId id) {
      throw new NotImplementedException();
    }

    public TEntity Save(TEntity entity) {
      throw new NotImplementedException();
    }

    public void Update(TEntity entity) {
      throw new NotImplementedException();
    }

    public TEntity SaveOrUpdate(TEntity entity) {
      throw new NotImplementedException();
    }

    public void Delete(TEntity entity) {
      throw new NotImplementedException();
    }

    protected T Command(Func<bool , bool>)

  }
}
