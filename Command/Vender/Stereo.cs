namespace Command.Vender {
  internal class Stereo {
    private string _location;
    private int _volume = 10;

    public Stereo(string location) {
      this._location = location;
    }

    public void On() {
      System.Console.WriteLine($"{this._location} オーディオの電源が入っています");
    }

    public void Off() {
      System.Console.WriteLine($"{this._location} オーディオの電源が切れています");
    }

    public void SetCd() {
      System.Console.WriteLine($"{this._location} オーディオがCD入力に設定されています");
    }

    public void SetDvd() {
      System.Console.WriteLine($"{this._location} オーディオがDVD入力に設定されています");
    }

    public void SetRadio() {
      System.Console.WriteLine($"{this._location} オーディオがラジオ入力に設定されています");
    }

    public void SetVolume(int volume) {
      this._volume = volume;
      System.Console.WriteLine($"{this._location} オーディオのボリュームが{this._volume}に設定されています");
    }

    public string Location { get { return _location; } }
    public int Volume { get { return _volume; } }
  }
}
