using FluentNHibernate.Mapping;
using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class PlayerMap : ClassMap<IPlayer> {

    public PlayerMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      HasManyToMany(x => x.Chronicles);
      HasMany(x => x.GameCharacters);
      Map(x => x.Name);
    }

  }
}
