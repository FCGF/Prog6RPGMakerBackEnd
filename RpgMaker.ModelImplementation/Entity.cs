using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public abstract class Entity<T> : IEntity<T> {
    public virtual T Id { get; set; }

  }
}
