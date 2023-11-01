namespace Factory.Pizza.Chicago {
  internal class ChicagoStyleCheesePizza : Pizza {
    public ChicagoStyleCheesePizza() {
      this._name = "シカゴスタイルのディープディッシュチーズピザ";
      this._dough = "極厚クラスト生地";
      this._sauce = "プラムトマトソース";

      this._toppings.Add("シュレッドモツァレラチーズ");
    }

    public override void Cut() {
      System.Console.WriteLine("ピザを四角形にカットする");
    }
  }
}
