using RpgMaker.Model;

namespace RpgMaker.Data {
  public interface IUserRepository : IRepository<long, IUser> {

    IUser FindByEmail(string email);

  }
}
