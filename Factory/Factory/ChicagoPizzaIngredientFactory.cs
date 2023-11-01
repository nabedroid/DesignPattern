using Factory.Ingredient;
using Factory.Ingredient.Cheese;
using Factory.Ingredient.Clam;
using Factory.Ingredient.Dough;
using Factory.Ingredient.Pepperoni;
using Factory.Ingredient.Sauce;
using Factory.Ingredient.Veggies;

namespace Factory.Factory {
  internal class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory {

    public IDough CreateDough() {
      return new ThickCrustDough();
    }

    public ISauce CreateSauce() {
      return new PlumTomatoSauce();
    }

    public ICheese CreateCheese() {
      return new MozzarellaCheese();
    }

    public IVeggies[] CreateVeggies() {
      return new IVeggies[] { new Spinach(), new BlackOlive(), new Eggplant() };
    }

    public IPepperoni CreatePepperoni() {
      return new SlicedPepperoni();
    }

    public IClam CreateClam() {
      return new FrozenClam();
    }

  }
}
