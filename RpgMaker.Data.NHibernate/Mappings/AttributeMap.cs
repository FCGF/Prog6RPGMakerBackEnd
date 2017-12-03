using FluentNHibernate.Mapping;
using RpgMaker.ModelImplementation;

namespace RpgMaker.Data.NHibernate.Mappings {
  public class AttributeMap : ClassMap<Attribute> {

    public AttributeMap() {
      Id(x => x.Id).GeneratedBy.Identity().UnsavedValue(0);
      Map(x => x.CurrentValue);
      Map(x => x.MaximumValue);
      Map(x => x.MinimunValue);
      Map(x => x.Name);
      Map(x => x.PriceMultiplier);
      Map(x => x.Specialization);
      Map(x => x.SpecialMultiplier);
    }

  }
}
