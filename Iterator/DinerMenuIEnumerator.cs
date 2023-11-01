using System.Collections;
using System.Collections.Generic;

namespace Iterator {

  internal class DinerMenuIEnumerator : IEnumerator<MenuItem> {

    private MenuItem[] _items;
    private int _position = -1;

    public DinerMenuIEnumerator(MenuItem[] items) {
      _items = items;
    }

    public MenuItem Current => _items[_position];
    object IEnumerator.Current => Current;

    public void Dispose() {
      _items = null;
    }

    public bool MoveNext() {
      _position = _position + 1;
      if (_position >= _items.Length || _items[_position] == null) {
        return false;
      }
      return true;
    }

    public void Reset() {
      _position = -1;
    }
  }

}
