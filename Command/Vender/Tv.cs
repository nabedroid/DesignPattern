namespace Command.Vender {
  internal class Tv {

    private string _location;
    private int _channel;
    private int _volume;

    public Tv(string location) {
      this._location = location;
    }

    public void On() {
      System.Console.WriteLine($"{this._location} TVの電源が入っています");
    }

    public void Off() {
      System.Console.WriteLine($"{this._location} TVの電源が切れています");
    }

    public void SetInputChannel() {
      this._channel = 3;
      System.Console.WriteLine($"{this._location} TVのチャンネルがDVDに設定されています");
    }

    public string Location { get { return this._location; } }
    public int Channel { get { return this._channel; } }
    public int Volume { get { return this._volume; } }
  }
}
