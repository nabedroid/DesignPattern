namespace Iterator {
  internal class MenuItem {
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

    public string Name {
      get { return _name; }
      set { this._name = value; }
    }

    public string Description {
      get { return _description; }
      set { this._description = value; }
    }

    public bool Vegetarian {
      get { return _vegetarian; }
      set { this._vegetarian = value; }
    }

    public double Price {
      get { return _price; }
      set { this._price = value; }
    }

  }

}
