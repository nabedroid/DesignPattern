using System.Collections.Generic;

namespace Compound.Duck {
  // Compositeパターン
  internal class Flock : IQuackable {

    private List<IQuackable> _quackers = new List<IQuackable>();

    public void Add(IQuackable quackable) {
      _quackers.Add(quackable);
    }

    public void Quack() {
      // Iteratorパターン
      IEnumerator<IQuackable> enumerator = _quackers.GetEnumerator();
      
      while (enumerator.MoveNext()) {
        IQuackable quacker = enumerator.Current;
        quacker.Quack();
      }
    }

    public void RegisterObserver(IObserver observer) {
      IEnumerator<IQuackable> enumerator = _quackers.GetEnumerator();

      while (enumerator.MoveNext()) {
        IQuackable quacker = enumerator.Current;
        quacker.RegisterObserver(observer);
      }
    }

    public void NotifyObservers() { }

  }
}
