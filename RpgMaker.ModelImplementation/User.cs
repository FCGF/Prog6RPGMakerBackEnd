using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public class User : Entity<long>, IUser {
    public virtual string Email { get; set; }
    public virtual string NickName { get; set; }
  }
}
