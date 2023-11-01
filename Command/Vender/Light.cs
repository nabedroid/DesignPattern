namespace Command.Vender {
  internal class Light {

    private string _location;

    public Light(string location) {
      this._location = location;
    }

    public void On() {
      System.Console.WriteLine($"{this._location} 照明が点いています");
    }

    public void Off() {
      System.Console.WriteLine($"{this._location} 照明が消灯しています");
    }

    public string Location { get { return this._location; } }
  }
}
