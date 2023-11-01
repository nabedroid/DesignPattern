namespace Factory.Pizza.Ny {
  internal class NYStylePepperoniPizza : Pizza {
    public NYStylePepperoniPizza() {
      this._name = "ニューヨークスタイルのペパロニピザ";
      this._dough = "薄いクラフト生地";
      this._sauce = "マリナラソース";

      this._toppings.Add("すりおろしたレッジャーノチーズ");
      this._toppings.Add("スライスペパロニ");
      this._toppings.Add("ニンニク");
      this._toppings.Add("玉ねぎ");
      this._toppings.Add("キノコ");
      this._toppings.Add("レッドペッパー");
    }
  }
}
