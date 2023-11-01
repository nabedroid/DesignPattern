using System.Collections.Generic;

namespace Iterator {

  internal class PancakeHouseIterator : Iterator {

    private List<MenuItem> _items;
    private int _position = 0;

    public PancakeHouseIterator(List<MenuItem> items) {
      _items = items;
    }

    public MenuItem Next() {
      MenuItem item = _items[_position];
      _position = _position + 1;
      return item;
    }

    public bool HasNext() {
      return _position < _items.Count;
    }

  }

}
