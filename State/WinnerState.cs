namespace State {

  public class WinnerState : State {

    private GumballMachine __gumballMachine;

    public WinnerState(GumballMachine _gumballMachine) {
      this.__gumballMachine = _gumballMachine;
    }

    public void InsertQuarter() {
      System.Console.WriteLine("Please wait, we're already giving you a Gumball");
    }

    public void EjectQuarter() {
      System.Console.WriteLine("Please wait, we're already giving you a Gumball");
    }

    public void TurnCrank() {
      System.Console.WriteLine("Turning again doesn't get you another gumball!");
    }

    public void Dispense() {
      __gumballMachine.ReleaseBall();
      if (__gumballMachine.Count == 0) {
        __gumballMachine.State = __gumballMachine.SoldOutState;
      } else {
        __gumballMachine.ReleaseBall();
        System.Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
        if (__gumballMachine.Count > 0) {
          __gumballMachine.State = __gumballMachine.NoQuarterState;
        } else {
          System.Console.WriteLine("Oops, out of gumballs!");
          __gumballMachine.State = __gumballMachine.SoldOutState;
        }
      }
    }

    public void Refill() { }

    public override string ToString() {
      return "despensing two gumballs for your quarter, because YOU'RE A WINNER!";
    }
  }
}