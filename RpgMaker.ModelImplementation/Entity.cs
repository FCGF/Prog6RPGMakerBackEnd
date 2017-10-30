using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public abstract class Entity<T> : IEntity<T> {
    public T Id { get; set; }

  }
}
