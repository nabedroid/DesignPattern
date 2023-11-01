namespace Command.Vender {
  internal class Hottub {
    private bool _on;
    private int _temperature;

    public Hottub() {
    }

    public void On() {
      this._on = true;
    }

    public void Off() {
      this._on = false;
    }

    public void Circulate() {
      if (this._on) {
        System.Console.WriteLine($"風呂を沸かしています");
      }
    }

    public void JetsOn() {
      if (this._on) {
        System.Console.WriteLine($"バブルバスが動いています");
      }
    }

    public void JetsOff() {
      if (this._on) {
        System.Console.WriteLine($"バブルバスが止まっています");
      }
    }

    public void SetTemperature(int temperature) {
      if (this._temperature > temperature) {
        System.Console.WriteLine($"風呂が{temperature}まで冷めています");
      } else if (this._temperature < temperature) {
        System.Console.WriteLine($"風呂が{temperature}まで熱くなっています");
      }
      this._temperature = temperature;
    }
  }
}
