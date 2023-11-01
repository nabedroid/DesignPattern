using System.Collections.Generic;

namespace Iterator {

  internal class PancakeHouseMenu : IMenu {

    List<MenuItem> _menuItems;

    public PancakeHouseMenu() {
      _menuItems = new List<MenuItem>();
      AddItem("K&Bのパンケーキ朝食", "スクランブルエッグとトースト付きパンケーキ", true, 2.99);
      AddItem("いつものパンケーキ朝食", "卵焼きとソーセージ付きパンケーキ", false, 2.99);
      AddItem("ブルーベリーパンケーキ", "新鮮なブルーベリーを使ったパンケーキ", true, 3.49);
      AddItem("ワッフル", "ブルーベリーか苺の好きなほうをのせたワッフル", true, 3.59);
    }

    public void AddItem(string name, string description, bool vegetarian, double price) {
      _menuItems.Add(new MenuItem(name, description, vegetarian, price));
    }

    //public List<MenuItem> GetMenuItems() {
    //  return _menuItems;
    //}

    public IEnumerator<MenuItem> CreateIterator() {
      return _menuItems.GetEnumerator();
    }

  }

}
