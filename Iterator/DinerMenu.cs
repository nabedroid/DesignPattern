using System.Collections.Generic;

namespace Iterator {

  internal class DinerMenu : IMenu {

    private const int MaxItems = 6;
    private int _numberOfItems = 0;
    private MenuItem[] _menuItems;

    public DinerMenu() {
      _menuItems = new MenuItem[MaxItems];
      AddItem("ベジタリアンBLT", "（フェイク）ベーコンをはさんだ全粒小麦パンサンドイッチ", true, 2.99);
      AddItem("BLT", "ベーコンをはさんだ全粒小麦パンサンドイッチ", false, 2.99);
      AddItem("本日のスープ", "ポテトサラダを添えた本日のスープ", false, 3.29);
      AddItem("ホットドッグ", "ザワークラウト、レリッシュ、玉ねぎ、チーズをはさんだホットドッグ", false, 3.05);
    }

    public void AddItem(string name, string description, bool vegetarian, double price) {
      MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
      if (_numberOfItems >= MaxItems) {
        System.Console.WriteLine("すいません、メニューはいっぱいです！メニューに項目を追加できません");
      } else {
        _menuItems[_numberOfItems] = menuItem;
        _numberOfItems = _numberOfItems + 1;
      }
    }

    //public MenuItem[] GetMenuItems() {
    //  return _menuItems;
    //}

    public IEnumerator<MenuItem> CreateIterator() {
      return new DinerMenuIEnumerator(_menuItems);
    }

  }

}
