namespace TempleteMethod {
  internal abstract class CaffeineBeverageWithHook {
    public void PrepareRecipe() {
      BoilWater();
      Brew();
      PourInCup();
      if (CustomerWantsCondiments()) {
        AddCondiments();
      }
    }

    protected void BoilWater() {
      System.Console.WriteLine("お湯を沸かす");
    }

    abstract protected void Brew();

    protected void PourInCup() {
      System.Console.WriteLine("カップに注ぐ");
    }

    protected virtual bool CustomerWantsCondiments() {
      return true;
    }

    abstract protected void AddCondiments();

  }
}
