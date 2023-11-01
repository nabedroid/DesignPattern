namespace TempleteMethod {
  internal class CoffeeWithHook : CaffeineBeverageWithHook {

    protected override void Brew() {
      System.Console.WriteLine("フィルタを使ってコーヒーをドリップする");
    }

    protected override void AddCondiments() {
      System.Console.WriteLine("砂糖とミルクを加える");
    }

    protected override bool CustomerWantsCondiments() {

      System.Console.Write("コーヒーに砂糖とミルクを入れますか？（y/n）");
      var key = System.Console.ReadKey();
      System.Console.WriteLine();
      return key.KeyChar == 'y';
    }

  }

}
