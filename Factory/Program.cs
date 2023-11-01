using Factory.Store;

namespace Factory {
  internal class Program {
    static void Main(string[] args) {
      PizzaStore nyStore = new NYPizzaStore();
      PizzaStore chicagoStore = new ChicagoPizzaStore();

      Pizza.Pizza pizza = nyStore.OrderPizza("チーズ");
      System.Console.WriteLine($"イーサンの注文は{pizza.Name}");

      pizza = chicagoStore.OrderPizza("チーズ");
      System.Console.WriteLine($"ジョエルの注文は{pizza.Name}");

      System.Console.ReadKey();
    }
  }
}
