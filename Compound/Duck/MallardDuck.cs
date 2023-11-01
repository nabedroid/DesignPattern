namespace Compound.Duck {

  internal class MallardDuck : IQuackable {

    private Observable _observable;

    public MallardDuck() {
      _observable = new Observable(this);
    }

    public void Quack() {
      System.Console.WriteLine("ガーガー");
      NotifyObservers();
    }

    public void RegisterObserver(IObserver observer) {
      _observable.RegisterObserver(observer);
    }

    public void NotifyObservers() {
      _observable.NotifyObservers();
    }

    public override string ToString() {
      return "マガモ";
    }

  }

}
