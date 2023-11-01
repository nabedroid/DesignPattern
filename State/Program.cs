namespace State {

  internal class Program {

    static void Main(string[] args) {
      GumballMachine gumballMachine = new GumballMachine(10);

      System.Console.WriteLine(gumballMachine);

      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();
      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();

      System.Console.WriteLine(gumballMachine);

      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();
      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();

      System.Console.WriteLine(gumballMachine);

      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();
      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();

      System.Console.WriteLine(gumballMachine);

      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();
      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();

      System.Console.WriteLine(gumballMachine);

      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();
      gumballMachine.InsertQuarter();
      gumballMachine.TurnCrank();

      System.Console.WriteLine(gumballMachine);

      System.Console.ReadKey();
    }

  }

}
