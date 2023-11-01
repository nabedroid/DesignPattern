using Factory.Factory;

namespace Factory.Pizza {
  internal class VeggiePizza : Pizza {

   protected IPizzaIngredientFactory _ingredientFactory;

    public VeggiePizza(IPizzaIngredientFactory ingredientFactory) {
      this._ingredientFactory = ingredientFactory;
    }

    public override void Prepare() {
      System.Console.WriteLine($"{Name}を下準備");
      this._dough = this._ingredientFactory.CreateDough();
      this._sauce = this._ingredientFactory.CreateSauce();
      this._cheese = this._ingredientFactory.CreateCheese();
      this._veggies = this._ingredientFactory.CreateVeggies();
    }

    public override string ToString() {
      return "ピザを出力するコード";
    }
  }
}
