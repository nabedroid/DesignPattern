namespace Facade.SubSystem {
  internal class StreamingPlayer {
    private string _description;
    private int _currentChapter;
    private Amplifier _amplifier;
    private string _movie;

    public StreamingPlayer(string description, Amplifier amplifier) {
      this._description = description;
      this._amplifier = amplifier;
    }

    public void On() {
      System.Console.WriteLine(this._description + " on");
    }

    public void Off() {
      System.Console.WriteLine(this._description + " off");
    }

    public void Play(string movie) {
      this._movie = movie;
      this._currentChapter = 0;
      System.Console.WriteLine(this._description + " playing \"" + this._movie + "\"");
    }

    public void Play(int chapter) {
      if (this._movie == null) {
        System.Console.WriteLine(this._description + " can't play chapter " + chapter + " no this._movie selected");
      } else {
        this._currentChapter = chapter;
        System.Console.WriteLine(this._description + " playing chapter " + this._currentChapter + " of \"" + this._movie + "\"");
      }
    }

    public void Stop() {
      this._currentChapter = 0;
      System.Console.WriteLine(this._description + " stopped \"" + this._movie + "\"");
    }

    public void Pause() {
      System.Console.WriteLine(this._description + " paused \"" + this._movie + "\"");
    }

    public void SetTwoChannelAudio() {
      System.Console.WriteLine(this._description + " set two channel audio");
    }

    public void SetSurroundAudio() {
      System.Console.WriteLine(this._description + " set surround audio");
    }

    public override string ToString() {
      return this._description;
    }

  }

}
