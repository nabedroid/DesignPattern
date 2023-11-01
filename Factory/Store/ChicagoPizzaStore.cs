using Factory.Pizza;

namespace Factory.Store {
  internal class ChicagoPizzaStore : PizzaStore {

    public override Pizza.Pizza CreatePizza(string item) {

      Pizza.Pizza pizza = null;
      Factory.IPizzaIngredientFactory factory = new Factory.ChicagoPizzaIngredientFactory();

      switch (item) {
        case "チーズ":
          pizza = new CheesePizza(factory);
          pizza.Name = "シカゴスタイルチーズピザ";
          break;
        case "野菜":
          pizza = new VeggiePizza(factory);
          pizza.Name = "シカゴスタイル野菜ピザ";
          break;
        case "アサリ":
          pizza = new ClamPizza(factory);
          pizza.Name = "シカゴスタイルアサリピザ";
          break;
        case "ペパロニ":
          pizza = new PepperoniPizza(factory);
          pizza.Name = "シカゴスタイルペパロニピザ";
          break;
      }
      return pizza;
    }
  }
}
