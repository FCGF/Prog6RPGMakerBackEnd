using RpgMaker.Model;
using RpgMaker.Model.Enum;

namespace RpgMaker.ModelImplementation {
  public class CharacterSheet : Entity<long>, ICharacterSheet {
    public GameType GameType { get; set; }
    public string SheetLocation { get; set; }

  }
}
