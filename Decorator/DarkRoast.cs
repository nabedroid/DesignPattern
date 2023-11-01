namespace Decorator {
  internal class DarkRoast : Beverage {
    public DarkRoast() {
      this._description = "ダークロースト";
    }

    public override double Cost() {
      return 0.99;
    }
  }
}
