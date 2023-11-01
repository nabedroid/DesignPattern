namespace Proxy {

  [System.Serializable]
  public class NoQuarterState : State {
    
    [System.NonSerialized()]
    private GumballMachine _gumballMachine;

    public NoQuarterState(GumballMachine gumballMachine) {
      this._gumballMachine = gumballMachine;
    }

    public void InsertQuarter() {
      System.Console.WriteLine("You inserted a quarter");
      _gumballMachine.State = _gumballMachine.HasQuarterState;
    }

    public void EjectQuarter() {
      System.Console.WriteLine("You haven't inserted a quarter");
    }

    public void TurnCrank() {
      System.Console.WriteLine("You turned, but there's no quarter");
    }

    public void Dispense() {
      System.Console.WriteLine("You need to pay first");
    }

    public void Refill() { }

    public override string ToString() {
      return "waiting for quarter";
    }

  }

}
