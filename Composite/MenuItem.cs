namespace Composite {
  internal class MenuItem : MenuComponent {

    private string _name;
    private string _description;
    private bool _vegetarian;
    private double _price;

    public MenuItem(string name, string description, bool vegetarian, double price) {
      this._name = name;
      this._description = description;
      this._vegetarian = vegetarian;
      this._price = price;
    }

    public override string GetName() {
      return this._name;
    }

    public override string GetDescription() {
      return this._description;
    }

    public override bool IsVegetarian() {
      return this._vegetarian;
    }

    public override double GetPrice() {
      return this._price;
    }

    public override void Print() {
      System.Console.Write($" {_name}");
      if (this._vegetarian) {
        System.Console.Write($"(v)");
      }
      System.Console.WriteLine($", {_price}");
      System.Console.WriteLine($"  -- {_description}");
    }

  }

}
