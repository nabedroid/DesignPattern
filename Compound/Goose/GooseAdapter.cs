using Compound.Duck;

namespace Compound.Goose {

  internal class GooseAdapter : IQuackable {

    private Observable _observable;
    private Goose _goose;

    public GooseAdapter(Goose goose) {
      this._goose = goose;
      this._observable = new Observable(this);
    }

    public void Quack() {
      _goose.Honk();
      NotifyObservers();
    }

    public void RegisterObserver(IObserver observer) {
      _observable.RegisterObserver(observer);
    }

    public void NotifyObservers() {
      _observable.NotifyObservers();
    }

    public override string ToString() {
      return "カモのふりをしたガチョウ";
    }

  }

}