using Factory.Pizza;

namespace Factory.Store {
  internal class NYPizzaStore : PizzaStore {

    public override Pizza.Pizza CreatePizza(string item) {

      Pizza.Pizza pizza = null;
      Factory.IPizzaIngredientFactory factory = new Factory.NYPizzaIngredientFactory();

      switch (item) {
        case "チーズ":
          pizza = new CheesePizza(factory);
          pizza.Name = "ニューヨークスタイルチーズピザ";
          break;
        case "野菜":
          pizza = new VeggiePizza(factory);
          pizza.Name = "ニューヨークスタイル野菜ピザ";
          break;
        case "アサリ":
          pizza = new ClamPizza(factory);
          pizza.Name = "ニューヨークスタイルアサリピザ";
          break;
        case "ペパロニ":
          pizza = new PepperoniPizza(factory);
          pizza.Name = "ニューヨークスタイルペパロニピザ";
          break;
      }
      return pizza;
    }
  }
}
