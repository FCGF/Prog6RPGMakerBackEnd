using System.Collections.Generic;
using RpgMaker.Model;
using RpgMaker.Model.Enum;

namespace RpgMaker.Service {
  public interface IAttributeService {

    IList<IAttribute> GetAttributes(GameType gameType);

  }
}
