namespace Command.Vender {
  internal class CeilingFan {
    public enum Speed { 強 = 3, 中 = 2, 弱 = 1, OFF = 0 }
    
    private string _location;
    private Speed _speed;

    public CeilingFan(string location) {
      this._location = location;
      this._speed = Speed.OFF;
    }

    public void High() {
      this._speed = Speed.強;
      System.Console.WriteLine($"{this._location} シーリングファンの強さは「{this._speed}」です");
    }

    public void Medium() {
      this._speed = Speed.中;
      System.Console.WriteLine($"{this._location} シーリングファンの強さは「{this._speed}」です");
    }

    public void Low() {
      this._speed = Speed.弱;
      System.Console.WriteLine($"{this._location} シーリングファンの強さは「{this._speed}」です");
    }

    public void Off() {
      this._speed = Speed.OFF;
      System.Console.WriteLine($"{this._location} シーリングファンは止まっています");
    }

    public Speed GetSpeed() { return this._speed; }
    public string Location { get { return this._location; } }
  }
}
