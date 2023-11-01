namespace Factory.Pizza.Ny {
  internal class NYStyleClamPizza : Pizza {
    public NYStyleClamPizza() {
      this._name = "ニューヨークスタイルのハマグリピザ";
      this._dough = "薄いクラフト生地";
      this._sauce = "マリナラソース";

      this._toppings.Add("すりおろしたレッジャーノチーズ");
      this._toppings.Add("ロングアイランド湾産の新鮮なアサリ");
    }
  }
}
