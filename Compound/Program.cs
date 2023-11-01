using Compound;
using Compound.Duck;

namespace Composite {
  internal class Program {
    static void Main(string[] args) {
      DuckSimulator simulator = new DuckSimulator();
      AbstractDuckFactory duckFactory = new CountingDuckFactory();
      simulator.simulate(duckFactory);
 
      System.Console.ReadKey();
    }
  }
}
