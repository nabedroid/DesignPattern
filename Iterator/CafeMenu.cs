using System.Collections.Generic;
using System.Diagnostics.SymbolStore;

namespace Iterator {
  internal class CafeMenu : IMenu {
    private Dictionary<string, MenuItem> _menuItems;

    public CafeMenu() {
      _menuItems = new Dictionary<string, MenuItem>();
      AddItem("野菜バーガーとフライドポテト", "全粒小麦パンにレタスとトマトをはさんだ野菜バーガーとフライドポテト", true, 3.99);
      AddItem("本日のスープ", "サラダが付いた本日のスープ", false, 3.69);
      AddItem("ブリトー", "インゲン豆、サルサ、グアカモーレ入りの大きなブリトー", true, 4.29);
    }

    public void AddItem(string name, string description, bool vegitarian, double price) {
      _menuItems.Add(name, new MenuItem(name, description, vegitarian, price));
    }

    public IEnumerator<MenuItem> CreateIterator() {
      return _menuItems.Values.GetEnumerator();
    }
  }
}
