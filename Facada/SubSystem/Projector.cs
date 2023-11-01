namespace Facade.SubSystem {

  internal class Projector {
    private string _description;
    private StreamingPlayer _player;

    public Projector(string description, StreamingPlayer player) {
      this._description = description;
      this._player = player;
    }

    public void On() {
      System.Console.WriteLine(this._description + " on");
    }

    public void Off() {
      System.Console.WriteLine(this._description + " off");
    }

    public void WideScreenMode() {
      System.Console.WriteLine(this._description + " in widescreen mode (16x9 aspect ratio)");
    }

    public void TvMode() {
      System.Console.WriteLine(this._description + " in tv mode (4x3 aspect ratio)");
    }

    public override string ToString() {
      return this._description;
    }
  }
}
