using FluentNHibernate.Mapping;
using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class ChronicleMap : ClassMap<IChronicle> {

    public ChronicleMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      References(x => x.GameMaster);
      Map(x => x.GameType);
      Map(x => x.Name);
      HasManyToMany(x => x.Players);
    }

  }
}
