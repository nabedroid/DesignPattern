using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

namespace Proxy.Server {
  internal class GumballMachineTestDrive {
    static void Main(string[] args) {

      if (args.Length != 2) {
        System.Console.WriteLine($"GumballMachine <name> <inventory>");
        return;
      }

      string location = args[0];
      int numberGumballs = int.Parse(args[1]);

      IChannel channel = new IpcServerChannel(location);
      ChannelServices.RegisterChannel(channel, true);

      GumballMachine machine = new GumballMachine(location, numberGumballs);
      RemotingServices.Marshal(machine, "gumballmachine", typeof(GumballMachine));

      System.Console.WriteLine($"Start GumballMachine at {location}");
      System.Console.WriteLine("Press any key to exit...");
      System.Console.ReadKey();
    }
  }
}
