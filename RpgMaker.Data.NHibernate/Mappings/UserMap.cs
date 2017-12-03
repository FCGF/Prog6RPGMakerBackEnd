using FluentNHibernate.Mapping;
using RpgMaker.ModelImplementation;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class UserMap : ClassMap<User> {

    public UserMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      Map(x => x.NickName);
      Map(x => x.Email);
    }

  }
}
