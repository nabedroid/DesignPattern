namespace Observer {
  internal interface ISubject {
    void RegisterObserver(IObserver iObserver);
    void RemoveObserver(IObserver iObserver);
    void NotifyObservers();
  }
}
