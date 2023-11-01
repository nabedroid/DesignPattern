namespace Decorator {
  internal class Decaf : Beverage {
    public Decaf() {
      this._description = "カフェインレス";
    }

    public override double Cost() {
      return 1.05;
    }
  }
}
