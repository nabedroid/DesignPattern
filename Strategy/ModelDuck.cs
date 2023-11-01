namespace Strategy {
  public class ModelDuck : Duck {
    public ModelDuck() {
      this._iFlyBehavior = new FlyNoWay();
      this._iQuackBehavior = new Quack();
    }

    public override void Display() {
      System.Console.WriteLine("模型のカモです");
    }
  }
}
