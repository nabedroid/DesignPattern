namespace Iterator {
  internal class Program {
    static void Main(string[] args) {
      PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
      DinerMenu dinerMenu = new DinerMenu();
      CafeMenu cafeMenu = new CafeMenu();

      Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

      waitress.PrintMenu();

      System.Console.ReadKey();
    }
  }
}
