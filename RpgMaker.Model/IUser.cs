namespace RpgMaker.Model {
  public interface IUser : IEntity<long> {

    string Email { get; set; }
    string NickName { get; set; }

  }
}
