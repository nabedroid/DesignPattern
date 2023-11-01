using System;

namespace Proxy {

  public class GumballMachine : MarshalByRefObject, IGumballMachineRemote {

    private string _location;
    private State _soldOutState;
    private State _noQuarterState;
    private State _hasQuarterState;
    private State _soldState;
    private State _winnerState;

    private State _state;
    private int _count = 0;

    public GumballMachine(string location, int numberGumballs) {
      _location = location;
      _soldOutState = new SoldOutState(this);
      _noQuarterState = new NoQuarterState(this);
      _hasQuarterState = new HasQuarterState(this);
      _soldState = new SoldState(this);
      _winnerState = new WinnerState(this);

      _count = numberGumballs;
      _state = numberGumballs > 0 ? _noQuarterState : _soldOutState;
    }

    public void InsertQuarter() {
      _state.InsertQuarter();
    }

    public void EjectQuarter() {
      _state.EjectQuarter();
    }

    public void TurnCrank() {
      _state.TurnCrank();
      _state.Dispense();
    }

    public string Location {
      get { return _location; }
      set { _location = value; }
    }

    public State State {
      get { return _state; }
      set { _state = value; }
    }

    public int Count {
      get { return _count; }
      set { _count = value; }
    }

    public void ReleaseBall() {
      System.Console.WriteLine("A gumball comes rolling out the slot...");
      if (_count > 0) {
        _count = _count - 1;
      }
    }

    public void Refill(int count) {
      _count += count;
      System.Console.WriteLine("The gumball machine was just Refilled; its new count is: " + _count);
      _state.Refill();
    }

    public State SoldOutState { get { return _soldOutState; } }
    public State NoQuarterState { get { return _noQuarterState; } }
    public State HasQuarterState { get { return _hasQuarterState; } }
    public State SoldState { get { return _soldState; } }
    public State WinnerState { get { return _winnerState; } }

    public override string ToString() {
      System.Text.StringBuilder result = new System.Text.StringBuilder();
      result.Append($"\nMighty Gumball, Inc.");
      result.Append($"\nJava-enabled Standing Gumball Model #2004");
      result.Append($"\nInventory: {_count} gumball");
      if (_count != 1) {
        result.Append("s");
      }
      result.Append($"\n");
      result.Append($"Machine is {_state}\n");
      return result.ToString();
    }
  }
}