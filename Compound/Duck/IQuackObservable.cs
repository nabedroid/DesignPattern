namespace Compound.Duck {
  internal interface IQuackObservable {
    void RegisterObserver(IObserver observer);
    void NotifyObservers();
  }
}
