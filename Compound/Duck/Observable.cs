using System.Collections.Generic;

namespace Compound.Duck {
  internal class Observable : IQuackObservable {
    private List<IObserver> _observers = new List<IObserver>();
    private IQuackObservable _duck;

    public Observable(IQuackObservable duck) { 
      this._duck = duck;
    }

    public void RegisterObserver(IObserver observer) {
      _observers.Add(observer);
    }

    public void NotifyObservers() {
      IEnumerator<IObserver> enumerator = _observers.GetEnumerator();
      while (enumerator.MoveNext()) {
        IObserver observer = enumerator.Current;
        observer.Update(_duck);
      }
    }
  }
}
