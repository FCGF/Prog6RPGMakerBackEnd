namespace RpgMaker.Model {
  public interface IAttribute : IEntity<long> {

    string Name { get; set; }
    int CurrentValue { get; set; }
    int MinimunValue { get; set; }
    int MaximumValue { get; set; }
    int PriceMultiplier { get; set; }
    int SpecialMultiplier { get; set; }
    string Specialization { get; set; }

  }
}
