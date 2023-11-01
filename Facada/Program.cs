using Facade.SubSystem;

namespace Facade {
  internal class Program {
    static void Main(string[] args) {
      Amplifier amp = new Amplifier("Amplifier");
      Tuner tuner = new Tuner("AM/FM Tuner", amp);
      StreamingPlayer player = new StreamingPlayer("Streaming Player", amp);
      Projector projector = new Projector("Projector", player);
      TheaterLights lights = new TheaterLights("Theater Ceiling Lights");
      Screen screen = new Screen("Theater Screen");
      PopcornPopper popper = new PopcornPopper("Popcorn Popper");

      HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, player, projector, lights, screen, popper);
      homeTheater.WatchMovie("レイダーズ／失われたアーク（聖櫃）");
      homeTheater.EndMovie();

      System.Console.ReadKey();
    }
  }
}
