using Factory.Ingredient;

namespace Factory.Factory {
  internal interface IPizzaIngredientFactory {
    IDough CreateDough();
    ISauce CreateSauce();
    ICheese CreateCheese();
    IVeggies[] CreateVeggies();
    IPepperoni CreatePepperoni();
    IClam CreateClam();
  }
}
