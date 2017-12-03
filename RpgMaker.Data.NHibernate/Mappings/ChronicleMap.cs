using FluentNHibernate.Mapping;
using RpgMaker.ModelImplementation;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class ChronicleMap : ClassMap<Chronicle> {

    public ChronicleMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      References<Player>(x => x.GameMaster);
      Map(x => x.GameType);
      Map(x => x.Name);
      HasManyToMany<Player>(x => x.Players);
    }

  }
}
