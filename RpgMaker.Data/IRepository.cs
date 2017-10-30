using RpgMaker.Model;

namespace RpgMaker.Data {
  public interface IRepository<TId, TEntity> where TEntity : class, IEntity<TId> {

    TEntity Find(TId id);
    TEntity Save(TEntity entity);
    void Update(TEntity entity);
    TEntity SaveOrUpdate(TEntity entity);
    void Delete(TEntity entity);

  }
}
