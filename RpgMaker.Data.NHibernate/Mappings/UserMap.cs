using FluentNHibernate.Mapping;
using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class UserMap : ClassMap<IUser> {

    public UserMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      Map(x => x.NickName);
      Map(x => x.Email);
    }

  }
}
