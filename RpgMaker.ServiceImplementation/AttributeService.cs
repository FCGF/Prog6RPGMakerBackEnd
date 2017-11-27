using System.Collections.Generic;
using RpgMaker.Model;
using RpgMaker.Model.Enum;
using RpgMaker.Service;
using Attribute = RpgMaker.ModelImplementation.Attribute;

namespace RpgMaker.ServiceImplementation {
  public class AttributeService : IAttributeService {

    private static IList<IAttribute> worldOfDarknessAttributes;
    private static IList<IAttribute> dungeonsAndDragonsAttributes;

    static AttributeService() {
      worldOfDarknessAttributes = new List<IAttribute>();

      // Atributos
      // Fisicos
      worldOfDarknessAttributes.Add(new Attribute { Name = "Força", MinimunValue = 1, MaximumValue = 10, PriceMultiplier = 5 });
      worldOfDarknessAttributes.Add(new Attribute { Name = "Destreza", MinimunValue = 1, MaximumValue = 10, PriceMultiplier = 5 });
      worldOfDarknessAttributes.Add(new Attribute { Name = "Vigor", MinimunValue = 1, MaximumValue = 10, PriceMultiplier = 5 });

      // Socias
      worldOfDarknessAttributes.Add(new Attribute { Name = "Carisma", MinimunValue = 1, MaximumValue = 10, PriceMultiplier = 5 });
      worldOfDarknessAttributes.Add(new Attribute { Name = "Manipulação", MinimunValue = 1, MaximumValue = 10, PriceMultiplier = 5 });
      worldOfDarknessAttributes.Add(new Attribute { Name = "Aparência", MinimunValue = 1, MaximumValue = 10, PriceMultiplier = 5 });

      // Mentais
      worldOfDarknessAttributes.Add(new Attribute { Name = "Percepção", MinimunValue = 1, MaximumValue = 10, PriceMultiplier = 5 });
      worldOfDarknessAttributes.Add(new Attribute { Name = "Inteligência", MinimunValue = 1, MaximumValue = 10, PriceMultiplier = 5 });
      worldOfDarknessAttributes.Add(new Attribute { Name = "Raciocínio", MinimunValue = 1, MaximumValue = 10, PriceMultiplier = 5 });

      // Habilidades
      // Talentos

      // Perícias

      // Conhecimento

      // Vantagens
      // Outras Caracteristicas

      // Antecedentes

      // Qualidades e Defeitos

      // Fé

      // Virtudes

      // Antecedentes

      // Humanidade

      // Força de Vontade

      dungeonsAndDragonsAttributes = new List<IAttribute>();
    }

    public IList<IAttribute> GetAttributes(GameType gameType) {
      IList<IAttribute> attributes = null;

      if (GameType.WorldOfDarkness.Equals(gameType)) {
        attributes = worldOfDarknessAttributes;
      } else if (GameType.DungeonsAndDragons.Equals(gameType)) {
        attributes = dungeonsAndDragonsAttributes;
      }

      return attributes;
    }

  }
}
