namespace Strategy {
  public class FlyNoWay : IFlyBehavior {
    public void Fly() {
      System.Console.WriteLine("飛べません・・・");
    }
  }
}
