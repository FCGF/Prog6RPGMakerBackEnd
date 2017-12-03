using FluentNHibernate.Mapping;
using RpgMaker.ModelImplementation;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class CharacterSheetMap : ClassMap<CharacterSheet> {

    public CharacterSheetMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      Map(x => x.GameType);
      Map(x => x.SheetLocation);
    }

  }
}
