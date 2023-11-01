namespace Decorator {
  internal class Espresso : Beverage {
    public Espresso() {
      this._description = "エスプレッソ";
    }

    public override double Cost() {
      return 1.99;
    }
  }
}
