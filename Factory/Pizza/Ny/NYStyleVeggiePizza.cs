namespace Factory.Pizza.Ny {
  internal class NYStyleVeggiePizza : Pizza {
    public NYStyleVeggiePizza() {
      this._name = "ニューヨークスタイルのベジピザ";
      this._dough = "薄いクラフト生地";
      this._sauce = "マリナラソース";

      this._toppings.Add("すりおろしたレッジャーノチーズ");
      this._toppings.Add("ニンニク");
      this._toppings.Add("玉ねぎ");
      this._toppings.Add("キノコ");
      this._toppings.Add("レッドペッパー");
    }
  }
}
