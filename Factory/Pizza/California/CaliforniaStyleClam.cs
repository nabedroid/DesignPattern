namespace Factory.Pizza.California {
  internal class CaliforniaStyleClamPizza : Pizza {
    public CaliforniaStyleClamPizza() {
      this._name = "カリフォルニアスタイルのアサリピザ";
      this._dough = "極薄クラフト生地";
      this._sauce = "サルサソース";

      this._toppings.Add("チーズ");
      this._toppings.Add("日本産アサリ");
    }
  }
}
