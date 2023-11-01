namespace Factory.Pizza.California {
  internal class CaliforniaStyleVeggiePizza : Pizza {
    public CaliforniaStyleVeggiePizza() {
      this._name = "カリフォルニアスタイルのベジピザ";
      this._dough = "極薄クラフト生地";
      this._sauce = "サルサソース";

      this._toppings.Add("チーズ");
      this._toppings.Add("トマト");
      this._toppings.Add("ナス");
      this._toppings.Add("ほうれん草");
    }
  }
}
