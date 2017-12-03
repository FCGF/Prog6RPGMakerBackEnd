using RpgMaker.Model;
using RpgMaker.Model.Enum;

namespace RpgMaker.ModelImplementation {
  public class CharacterSheet : Entity<long>, ICharacterSheet {
    public virtual GameType GameType { get; set; }
    public virtual string SheetLocation { get; set; }

  }
}
