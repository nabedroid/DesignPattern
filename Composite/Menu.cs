using System.Collections.Generic;

namespace Composite {

  internal class Menu : MenuComponent {

    private List<MenuComponent> _menuComponents = new List<MenuComponent>();
    private string _name;
    private string _description;

    public Menu(string name, string description) {
      _name = name;
      _description = description;
    }

    public override void Add(MenuComponent menuComponent) {
      _menuComponents.Add(menuComponent);
    }

    public override void Remove(MenuComponent menuComponent) {
      _menuComponents.Remove(menuComponent);
    }

    public override MenuComponent GetChild(int index) {
      return _menuComponents[index];
    }

    public override string GetName() {
      return _name;
    }

    public override string GetDescription() {
      return _description;
    }

    public override void Print() {
      System.Console.WriteLine($"");
      System.Console.WriteLine($"{_name}, {_description}");
      System.Console.WriteLine($"------------------");

      foreach (MenuComponent menuComponent in _menuComponents) {
        menuComponent.Print();
      }
    }

  }

}
