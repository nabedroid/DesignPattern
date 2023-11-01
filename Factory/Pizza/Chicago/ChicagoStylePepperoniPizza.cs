﻿namespace Factory.Pizza.Chicago {
  internal class ChicagoStylePepperoniPizza : Pizza {
    public ChicagoStylePepperoniPizza() {
      this._name = "シカゴスタイルのペパロニピザ";
      this._dough = "極厚クラスト生地";
      this._sauce = "プラムトマトソース";

      this._toppings.Add("シュレッドモツァレラチーズ");
      this._toppings.Add("ブラックオリーブ");
      this._toppings.Add("ほうれん草");
      this._toppings.Add("ナス");
      this._toppings.Add("スライスペパロニ");
    }

    public override void Cut() {
      System.Console.WriteLine("ピザを四角形にカットする");
    }
  }
}
