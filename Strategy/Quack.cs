namespace Strategy {
  public class Quack : IQuackBehavior{
    void IQuackBehavior.Quack() {
      System.Console.WriteLine("ガーガー");
    }
  }
}
