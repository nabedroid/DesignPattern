namespace Proxy {

  public interface IGumballMachineRemote {
    int Count { get; }
    string Location { get; }
    State State { get; }
  }

}
