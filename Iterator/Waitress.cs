using System.Collections;
using System.Collections.Generic;

namespace Iterator {

  internal class Waitress {

    private IMenu _pancakeHouseMenu;
    private IMenu _dinerMenu;
    private IMenu _cafeMenu;

    public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu) {
      _pancakeHouseMenu = pancakeHouseMenu;
      _dinerMenu = dinerMenu;
      _cafeMenu = cafeMenu;
    }

    public void PrintMenu() {
      IEnumerator<MenuItem> pancakeEnumerator = _pancakeHouseMenu.CreateIterator();
      IEnumerator<MenuItem> dinerEnumerator = _dinerMenu.CreateIterator();
      IEnumerator<MenuItem> cafeEnumerator = _cafeMenu.CreateIterator();

      System.Console.WriteLine("メニュー");
      System.Console.WriteLine("---");
      System.Console.WriteLine("朝食");
      PrintMenu(pancakeEnumerator);
      System.Console.WriteLine("");
      System.Console.WriteLine("昼食");
      PrintMenu(dinerEnumerator);
      System.Console.WriteLine("");
      System.Console.WriteLine("夕食");
      PrintMenu(cafeEnumerator);
    }

    private void PrintMenu(IEnumerator<MenuItem> enumerator) {
      while (enumerator.MoveNext()) {
        MenuItem menuItem = enumerator.Current;
        System.Console.Write($"{menuItem.Name} -- ");
        System.Console.Write($"{menuItem.Price} -- ");
        System.Console.WriteLine($"{menuItem.Description}");
      }
    }

  }

}
