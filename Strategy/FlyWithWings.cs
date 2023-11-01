namespace Strategy {
  public class FlyWithWings : IFlyBehavior {
    public void Fly() {
      System.Console.WriteLine("羽を使って飛んでいます！");
    }
  }
}