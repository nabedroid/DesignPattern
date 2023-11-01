using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;

namespace Proxy.Client {
  internal class GumballMonitorTestDrive {
    static void Main(string[] args) {

      string[] locations = {
        "santafe.mightygumball.com",
        "boulder.mightygumball.com",
        "austin.mightygumball.com"
      };

      if (args.Length > 0 ) {
        locations = new string[] { args[0] };
      }

      GumballMonitor[] monitors = new GumballMonitor[locations.Length];

      IChannel channel = new IpcClientChannel();
      ChannelServices.RegisterChannel(channel, true);

      for (int i = 0; i < locations.Length; i++) {
        string uri = $"ipc://{locations[i]}/gumballmachine";
        IGumballMachineRemote machine = System.Activator.GetObject(typeof(IGumballMachineRemote), uri) as IGumballMachineRemote;
        monitors[i] = new GumballMonitor(machine);
        System.Console.WriteLine(monitors[i]);
      }

      foreach (GumballMonitor monitor in monitors) {
        monitor.Report();
      }

      System.Console.WriteLine("Press any key to exit...");
      System.Console.ReadKey();

    }
  }
}
