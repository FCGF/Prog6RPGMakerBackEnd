using RpgMaker.Model.Enum;

namespace RpgMaker.Model {
  public interface ICharacterSheet : IEntity<long> {

    GameType GameType { get; set; }
    string SheetLocation { get; set; }

  }
}
