namespace Compound.Duck {
  internal interface IObserver {
    void Update(IQuackObservable duck);
  }
}
