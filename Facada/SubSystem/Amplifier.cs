namespace Facade.SubSystem {

  internal class Amplifier {
    private string _description;
    private Tuner _tuner;
    private StreamingPlayer _player;

    public Amplifier(string description) {
      this._description = description;
    }

    public void On() {
      System.Console.WriteLine(this._description + " on");
    }

    public void Off() {
      System.Console.WriteLine(this._description + " off");
    }

    public void SetStereoSound() {
      System.Console.WriteLine(this._description + " stereo mode on");
    }

    public void SetSurroundSound() {
      System.Console.WriteLine(this._description + " surround sound on (5 speakers, 1 subwoofer)");
    }

    public void SetVolume(int level) {
      System.Console.WriteLine(this._description + " setting volume to " + level);
    }

    public void SetTuner(Tuner tuner) {
      System.Console.WriteLine(this._description + " setting tuner to " + tuner);
      this._tuner = tuner;
    }

    public void SetStreamingPlayer(StreamingPlayer player) {
      System.Console.WriteLine(this._description + " setting Streaming player to " + player);
      this._player = player;
    }

    public override string ToString() {
      return this._description;
    }
  }

}
