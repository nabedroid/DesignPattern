namespace Proxy {

  [System.Serializable]
  public class HasQuarterState : State {

    [System.NonSerialized()]
    private GumballMachine _gumballMachine;
    private System.Random _randomWinner = new System.Random();

    public HasQuarterState(GumballMachine gumballMachine) {
      this._gumballMachine = gumballMachine;
    }

    public void InsertQuarter() {
      System.Console.WriteLine("You can't insert another quarter");
    }

    public void EjectQuarter() {
      System.Console.WriteLine("Quarter returned");
      _gumballMachine.State = _gumballMachine.NoQuarterState;
    }

    public void TurnCrank() {
      System.Console.WriteLine("You turned...");
      int winner = _randomWinner.Next(0, 10);
      if (winner == 0 && _gumballMachine.Count > 1) {
        _gumballMachine.State = _gumballMachine.WinnerState;
      } else {
        _gumballMachine.State = _gumballMachine.SoldState;
      }
    }

    public void Dispense() {
      System.Console.WriteLine("No gumball dispensed");
    }

    public void Refill() { }

    public override string ToString() {
      return "waiting for turn of crank";
    }

  }

}