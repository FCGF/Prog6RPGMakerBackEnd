using FluentNHibernate.Mapping;
using RpgMaker.ModelImplementation;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class GameCharacterMap : ClassMap<GameCharacter> {

    public GameCharacterMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      HasMany<Attribute>(x => x.Attributes);
      References<Chronicle>(x => x.Chronicle);
      Map(x => x.Experience);
      References<Player>(x => x.Player);
    }

  }
}
