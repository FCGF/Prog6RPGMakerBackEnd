using FluentNHibernate.Mapping;
using RpgMaker.ModelImplementation;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class PlayerMap : ClassMap<Player> {

    public PlayerMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      HasManyToMany<Chronicle>(x => x.Chronicles);
      HasMany<GameCharacter>(x => x.GameCharacters);
      Map(x => x.Name);
    }

  }
}
