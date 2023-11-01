namespace Decorator {
  internal class Whip : CondimentDecorator {
    public Whip(Beverage beverage) {
      this._beverage = beverage;
    }

    public override string GetDescription() {
      return this._beverage.GetDescription() + "、ホイップ";
    }

    public override double Cost() {
      return this._beverage.Cost() + 0.10;
    }
  }
}
