namespace TempleteMethod {
  internal class TeaWithHook : CaffeineBeverageWithHook {

    protected override void Brew() {
      System.Console.WriteLine("紅茶を浸す");
    }

    protected override void AddCondiments() {
      System.Console.WriteLine("レモンを追加する");
    }

    protected override bool CustomerWantsCondiments() {

      System.Console.Write("紅茶にレモンを入れますか？（y/n）");
      var key = System.Console.ReadKey();
      System.Console.WriteLine();
      return key.KeyChar == 'y';
    }

  }

}
