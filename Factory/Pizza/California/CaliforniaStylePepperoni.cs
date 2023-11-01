namespace Factory.Pizza.California {
  internal class CaliforniaStylePepperoniPizza : Pizza {
    public CaliforniaStylePepperoniPizza() {
      this._name = "カリフォルニアスタイルのペパロニピザ";
      this._dough = "極薄クラフト生地";
      this._sauce = "サルサソース";

      this._toppings.Add("チーズ");
      this._toppings.Add("日本産ペパロニ");
      this._toppings.Add("ほうれん草");
    }
  }
}
