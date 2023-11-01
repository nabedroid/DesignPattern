namespace Decorator {
  internal class HouseBlend : Beverage {
    public HouseBlend() {
      this._description = "ハウスブレンドコーヒー";
    }

    public override double Cost() {
      return 0.89;
    }
  }
}
