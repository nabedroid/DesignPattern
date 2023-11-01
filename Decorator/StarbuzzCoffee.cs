namespace Decorator {
  internal class StarbuzzCoffee {
    static void Main(string[] args) {
      Beverage beverage = new Espresso();
      System.Console.WriteLine(beverage.GetDescription() + " $" +  beverage.Cost());

      Beverage beverage2 = new DarkRoast();
      beverage2 = new Mocha(beverage2);
      beverage2 = new Mocha(beverage2);
      beverage2 = new Whip(beverage2);
      System.Console.WriteLine(beverage2.GetDescription() + " $" +  beverage2.Cost());

      Beverage beverage3 = new HouseBlend();
      beverage3.SetSize(Beverage.Size.VENTI);
      beverage3 = new Soy(beverage3);
      beverage3 = new Mocha(beverage3);
      beverage3 = new Whip(beverage3);
      System.Console.WriteLine(beverage3.GetDescription() + " $" +  beverage3.Cost());

      System.Console.ReadKey();
    }
  }
}
