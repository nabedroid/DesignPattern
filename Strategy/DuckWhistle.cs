namespace Strategy {
  public class DuckWhistle {
    private IQuackBehavior _iQuackBehavior;

    public DuckWhistle() {
      this._iQuackBehavior = new Quack();
    }

    public void Quack() {
      this._iQuackBehavior?.Quack();
    }

    public IQuackBehavior IQuackBehavior {
      set { _iQuackBehavior = value; }
    }
  }
}
