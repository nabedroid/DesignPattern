namespace State {


  public class SoldState : State {

    private GumballMachine __gumballMachine;

    public SoldState(GumballMachine _gumballMachine) {
      this.__gumballMachine = _gumballMachine;
    }

    public void InsertQuarter() {
      System.Console.WriteLine("Please wait, we're already giving you a gumball");
    }

    public void EjectQuarter() {
      System.Console.WriteLine("Sorry, you already turned the crank");
    }

    public void TurnCrank() {
      System.Console.WriteLine("Turning twice doesn't get you another gumball!");
    }

    public void Dispense() {
      __gumballMachine.ReleaseBall();
      if (__gumballMachine.Count > 0) {
        __gumballMachine.State = __gumballMachine.NoQuarterState;
      } else {
        System.Console.WriteLine("Oops, out of gumballs!");
        __gumballMachine.State = __gumballMachine.SoldOutState;
      }
    }

    public void Refill() { }

    public override string ToString() {
      return "dispensing a gumball";
    }
  }
}