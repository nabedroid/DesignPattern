namespace Factory.Pizza.Chicago {
  internal class ChicagoStyleClamPizza : Pizza {
    public ChicagoStyleClamPizza() {
      this._name = "シカゴスタイルのアサリピザ";
      this._dough = "極厚クラスト生地";
      this._sauce = "プラムトマトソース";

      this._toppings.Add("シュレッドモツァレラチーズ");
      this._toppings.Add("チェサピーク湾産冷凍アサリ");
    }

    public override void Cut() {
      System.Console.WriteLine("ピザを四角形にカットする");
    }
  }
}
