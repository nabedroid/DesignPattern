namespace Composite {

  internal class Waitress {

    private MenuComponent _allMenus;

    public Waitress(MenuComponent allMenus) {
      this._allMenus = allMenus;
    }

    public void PrintMenu() {
      _allMenus.Print();
    }

  }

}
