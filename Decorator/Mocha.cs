namespace Decorator {
  internal class Mocha : CondimentDecorator {
    public Mocha(Beverage beverage) {
      this._beverage = beverage;
    }

    public override string GetDescription() {
      return this._beverage.GetDescription() + "、モカ";
    }

    public override double Cost() {
      return this._beverage.Cost() + 0.20;
    }
  }
}
