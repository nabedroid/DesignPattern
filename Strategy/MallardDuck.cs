namespace Strategy {
  public class MallardDuck : Duck {

    public MallardDuck() {
      this._iQuackBehavior = new Quack();
      this._iFlyBehavior = new FlyWithWings();
    }

    public override void Display() {
      System.Console.WriteLine("私はマガモ（真鴨、学名：Anas platyrhynchos））です！");
    }
  }
}
