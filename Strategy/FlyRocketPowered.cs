namespace Strategy {
  public class FlyRocketPowered : IFlyBehavior {
    public void Fly() {
      System.Console.WriteLine("宇宙速度で飛んでいます！");
    }
  }
}