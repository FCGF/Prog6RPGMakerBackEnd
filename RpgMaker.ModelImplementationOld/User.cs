using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public class User : Entity<long>, IUser {
    public string Email { get; set; }
    public string NickName { get; set; }
  }
}
