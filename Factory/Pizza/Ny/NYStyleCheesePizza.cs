namespace Factory.Pizza.Ny {
  internal class NYStyleCheesePizza : Pizza {
    public NYStyleCheesePizza() {
      this._name = "ニューヨークスタイルのソース＆チーズピザ";
      this._dough = "薄いクラフト生地";
      this._sauce = "マリナラソース";

      this._toppings.Add("すりおろしたレッジャーノチーズ");
    }
  }
}
