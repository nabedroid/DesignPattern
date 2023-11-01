namespace Factory.Store {
  internal abstract class PizzaStore {

    public Pizza.Pizza OrderPizza(string type) {
      Pizza.Pizza pizza = null;
      pizza = this.CreatePizza(type);

      pizza.Prepare();
      pizza.Bake();
      pizza.Cut();
      pizza.Box();

      return pizza;
    }

    public abstract Pizza.Pizza CreatePizza(string type);
  }
}
