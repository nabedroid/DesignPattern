namespace Strategy {
  public class MuteQuack : IQuackBehavior{
    public void Quack() {
      System.Console.WriteLine("・・・（沈黙）");
    }
  }
}
