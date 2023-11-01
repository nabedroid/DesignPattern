namespace Factory.Pizza.California {
  internal class CaliforniaStyleCheesePizza : Pizza {
    public CaliforniaStyleCheesePizza() {
      this._name = "カリフォルニアスタイルのチーズピザ";
      this._dough = "極薄クラフト生地";
      this._sauce = "サルサソース";

      this._toppings.Add("チーズ");
    }
  }
}
