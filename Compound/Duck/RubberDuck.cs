namespace Compound.Duck {

  internal class RubberDuck : IQuackable {

    private Observable _observable;

    public RubberDuck() {
      _observable = new Observable(this);
    }

    public void Quack() {
      System.Console.WriteLine("キューキュー");
      NotifyObservers();
    }

    public void RegisterObserver(IObserver observer) {
      _observable.RegisterObserver(observer);
    }

    public void NotifyObservers() {
      _observable.NotifyObservers();
    }

    public override string ToString() {
      return "ゴムのアヒル";
    }

  }

}
