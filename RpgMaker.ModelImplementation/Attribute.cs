using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public class Attribute : Entity<long>, IAttribute {
    public virtual string Name { get; set; }
    public virtual int CurrentValue { get; set; }
    public virtual int MinimunValue { get; set; }
    public virtual int MaximumValue { get; set; }
    public virtual int PriceMultiplier { get; set; }
    public virtual int SpecialMultiplier { get; set; }
    public virtual string Specialization { get; set; }

    public virtual int CalculatePrice() {
      int multiplier = GetCurrentMultiplier();
      return this.CurrentValue * multiplier;
    }

    private int GetCurrentMultiplier() {
      return CurrentValue > 5
            ? SpecialMultiplier
            : PriceMultiplier;
    }

  }
}
