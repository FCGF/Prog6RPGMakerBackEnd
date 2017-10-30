using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using RpgMaker.Model;
using RpgMaker.Model.Enum;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class CharacterSheetMap : ClassMap<ICharacterSheet> {

    public CharacterSheetMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      Map(x => x.GameType);
    }

  }
}
