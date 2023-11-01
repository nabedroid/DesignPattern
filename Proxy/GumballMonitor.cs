namespace Proxy {

  public class GumballMonitor {

    IGumballMachineRemote _machine;

    public GumballMonitor(IGumballMachineRemote machine) {
      this._machine = machine;
    }

    public void Report() {
      System.Console.WriteLine($"Gumball Machine: {_machine.Location}");
      System.Console.WriteLine($"Current inventory: {_machine.Count}" + " gumballs");
      System.Console.WriteLine($"Current state: {_machine.State}");
    }
  }

}