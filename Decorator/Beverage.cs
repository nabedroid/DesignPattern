namespace Decorator {
  internal abstract class Beverage {
    public enum Size {  TALL, GRANDE, VENTI };
    protected Size _size = Size.TALL;
    protected string _description = "不明な飲み物";

    public virtual string GetDescription() {
      return _description;
    }

    public void SetSize(Size size) {
      this._size = size;
    }

    public Size GetSize() {
      return this._size;
    }

    public abstract double Cost();

  }
}
