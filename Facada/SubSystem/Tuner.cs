namespace Facade.SubSystem {

  internal class Tuner {
    private string _description;
    private Amplifier _amplifier;
    private double _frequency;

    public Tuner(string description, Amplifier amplifier) {
      this._description = description;
    }

    public void On() {
      System.Console.WriteLine(this._description + " on");
    }

    public void Off() {
      System.Console.WriteLine(this._description + " off");
    }

    public void SetFrequency(double frequency) {
      System.Console.WriteLine(this._description + " setting frequency to " + frequency);
      this._frequency = frequency;
    }

    public void SetAm() {
      System.Console.WriteLine(this._description + " setting AM mode");
    }

    public void SetFm() {
      System.Console.WriteLine(this._description + " setting FM mode");
    }

    public override string ToString() {
      return this._description;
    }

  }

}
