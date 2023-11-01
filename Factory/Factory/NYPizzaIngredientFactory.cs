using Factory.Ingredient;
using Factory.Ingredient.Cheese;
using Factory.Ingredient.Clam;
using Factory.Ingredient.Dough;
using Factory.Ingredient.Pepperoni;
using Factory.Ingredient.Sauce;
using Factory.Ingredient.Veggies;

namespace Factory.Factory {
  internal class NYPizzaIngredientFactory : IPizzaIngredientFactory {

    public IDough CreateDough() {
      return new ThinCrustDough();
    }

    public ISauce CreateSauce() {
      return new MarinaraSauce();
    }

    public ICheese CreateCheese() {
      return new ReggianoCheese();
    }

    public IVeggies[] CreateVeggies() {
      return new IVeggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
    }

    public IPepperoni CreatePepperoni() {
      return new SlicedPepperoni();
    }

    public IClam CreateClam() {
      return new FreshClam();
    }

  }
}
