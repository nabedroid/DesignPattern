namespace Strategy {
  public abstract class Duck {
    protected IFlyBehavior _iFlyBehavior;
    protected IQuackBehavior _iQuackBehavior;

    public Duck() {}

    public abstract void Display();

    public void PerformFly() {
      this._iFlyBehavior?.Fly();
    }

    public void PerformQuack() {
      this._iQuackBehavior?.Quack();
    }

    public void Swim() {
      System.Console.WriteLine("すべての鴨は浮きます。そうおとりでもね。");
    }

    public IFlyBehavior IFlyBehavior {
      set { this._iFlyBehavior = value; }
    }

    public IQuackBehavior IQuackBehavior {
      set { this._iQuackBehavior = value; }
    }
  }
}
