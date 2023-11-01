namespace Compound.Duck {

  internal class RedheadDuck : IQuackable {

    private Observable _observable;

    public RedheadDuck() {
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
      return "アメリカホシハジロ";
    }

  }

}
