namespace Command.Vender {
  internal class GarageDoor {

    private string _location;

    public GarageDoor(string location) {
      this._location = location;
    }

    public void Up() {
      System.Console.WriteLine($"{ this._location} ガレージのドアは開いています");
    }

    public void Down() {
      System.Console.WriteLine($"{ this._location} ガレージのドアは閉じています");
    }

    public void Stop() {
      System.Console.WriteLine($"{ this._location} ガレージのドアが停止しています");
    }

    public void LightOn() {
      System.Console.WriteLine($"{ this._location} ガレージのライトが点いています");
    }

    public void LightOff() {
      System.Console.WriteLine($"{ this._location} ガレージのライトが消灯しています");
    }

    public string Location { get { return _location; } }
  }
}
