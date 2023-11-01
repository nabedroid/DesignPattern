using Factory.Factory;

namespace Factory.Pizza {
  internal class CheesePizza : Pizza {

   protected IPizzaIngredientFactory _ingredientFactory;

    public CheesePizza(IPizzaIngredientFactory ingredientFactory) {
      this._ingredientFactory = ingredientFactory;
    }

    public override void Prepare() {
      System.Console.WriteLine($"{Name}を下準備");
      this._dough = this._ingredientFactory.CreateDough();
      this._sauce = this._ingredientFactory.CreateSauce();
      this._cheese = this._ingredientFactory.CreateCheese();
    }

    public override string ToString() {
      return "ピザを出力するコード";
    }
  }
}
