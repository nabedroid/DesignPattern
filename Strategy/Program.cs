namespace Strategy {
  internal class Program {
    static void Main(string[] args) {
      // 真鴨
      Duck duck = new MallardDuck();
      duck.PerformQuack();
      duck.PerformFly();
      // 模型
      Duck model = new ModelDuck();
      model.PerformFly();
      model.IFlyBehavior = new FlyRocketPowered();
      model.PerformFly();
      // 鴨笛
      DuckWhistle duckWhistle = new DuckWhistle();
      duckWhistle.Quack();

      // コンソール閉じ待ち
      System.Console.ReadKey();
    }
  }
}
