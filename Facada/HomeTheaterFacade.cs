using Facade.SubSystem;

namespace Facade {
  internal class HomeTheaterFacade {
    private Amplifier _amp;
    private Tuner _tuner;
    private StreamingPlayer _player;
    private Projector _projector;
    private TheaterLights _lights;
    private Screen _screen;
    private PopcornPopper _popper;

    public HomeTheaterFacade(Amplifier amp, Tuner tuner, StreamingPlayer player, Projector projector, TheaterLights lights, Screen screen, PopcornPopper popper) {
      this._amp = amp;
      this._tuner = tuner;
      this._player = player;
      this._projector = projector;
      this._lights = lights;
      this._screen = screen;
      this._popper = popper;
    }

    public void WatchMovie(string movie) {
      System.Console.WriteLine("映画を見る準備をします");
      this._popper.On();
      this._popper.Pop();
      this._lights.Dim(10);
      this._screen.Down();
      this._projector.On();
      this._projector.WideScreenMode();
      this._amp.On();
      this._amp.SetStreamingPlayer(this._player);
      this._amp.SetSurroundSound();
      this._amp.SetVolume(5);
      this._player.On();
      this._player.Play(movie);
    }

    public void EndMovie() {
      System.Console.WriteLine("ムービーシアターを停止します");
      this._popper.Off();
      this._lights.Off();
      this._screen.Up();
      this._projector.Off();
      this._amp.Off();
      this._player.Stop();
      this._player.Off();
    }
  }
}
