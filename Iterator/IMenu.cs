using System.Collections.Generic;

namespace Iterator {
  internal interface IMenu {
    IEnumerator<MenuItem> CreateIterator();
  }
}
