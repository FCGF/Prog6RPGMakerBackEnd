using RpgMaker.Model;

namespace RpgMaker.ModelImplementation {
  public class Attribute : Entity<long>, IAttribute {
    public string Name { get; set; }
    public int CurrentValue { get; set; }
    public int MinimunValue { get; set; }
    public int MaximumValue { get; set; }
    public int PriceMultiplier { get; set; }
    public int SpecialMultiplier { get; set; }
    public string Specialization { get; set; }

    public int CalculatePrice() {
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
