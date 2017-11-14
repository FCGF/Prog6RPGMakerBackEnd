using FluentNHibernate.Mapping;
using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class GameCharacterMap : ClassMap<IGameCharacter> {

    public GameCharacterMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      HasMany(x => x.Attributes);
      References(x => x.Chronicle);
      Map(x => x.Experience);
      References(x => x.Player);
    }

  }
}
