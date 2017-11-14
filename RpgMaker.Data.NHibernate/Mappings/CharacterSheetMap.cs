﻿using FluentNHibernate.Mapping;
using RpgMaker.Model;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class CharacterSheetMap : ClassMap<ICharacterSheet> {

    public CharacterSheetMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      Map(x => x.GameType);
      Map(x => x.SheetLocation);
    }

  }
}
