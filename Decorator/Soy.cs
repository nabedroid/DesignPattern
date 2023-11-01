namespace Decorator {
  internal class Soy : CondimentDecorator {
    public Soy(Beverage beverage) {
      this._beverage = beverage;
    }

    public override string GetDescription() {
      return this._beverage.GetDescription() + "、豆乳";
    }

    public override double Cost() {
      double cost = this._beverage.Cost();
      switch (this._beverage.GetSize()) {
        case Beverage.Size.TALL:
          cost += 0.10;
          break;
        case Beverage.Size.GRANDE:
          cost += 0.15;
          break;
        case Beverage.Size.VENTI:
          cost += 0.20;
          break;
      }
      return cost;
    }
  }
}
