namespace Decorator {
  internal abstract class CondimentDecorator : Beverage {
    protected Beverage _beverage;

    public override abstract string GetDescription();

    public new Beverage.Size GetSize() {
      return this._beverage.GetSize();
    }
  }
}
