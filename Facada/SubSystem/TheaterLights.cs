namespace Facade.SubSystem {
  internal class TheaterLights {
    private string _description;

    public TheaterLights(string description) {
      this._description = description;
    }

    public void On() {
      System.Console.WriteLine(this._description + " on");
    }

    public void Off() {
      System.Console.WriteLine(this._description + " off");
    }

    public void Dim(int level) {
      System.Console.WriteLine(this._description + " dimming to " + level + "%");
    }

    public override string ToString() {
      return this._description;
    }

  }

}
