namespace TempleteMethod {
  internal class Program {
    static void Main(string[] args) {
      TeaWithHook teaHook = new TeaWithHook();
      CoffeeWithHook coffeeHook = new CoffeeWithHook();

      System.Console.WriteLine("紅茶を淹れる");
      teaHook.PrepareRecipe();

      System.Console.WriteLine("コーヒーを淹れる");
      coffeeHook.PrepareRecipe();

      System.Console.ReadKey();
    }
  }
}
