using System.Collections.Generic;
using System.Linq;

namespace Observer {
  internal class StatisticsDisplay : IObserver, IDisplayElement {
    private List<float> _temperatures;
    private WeatherData _weatherData;

    public StatisticsDisplay(WeatherData weatherData) {
      this._temperatures = new List<float>();
      this._weatherData = weatherData;
      weatherData.RegisterObserver(this);
    }

    public void Update() {
      this._temperatures.Add(this._weatherData.Temperature);
      this.Display();
    }

    public void Display() {
      System.Console.WriteLine($"平均{this._temperatures.Average()}/最高{this._temperatures.Max()}/最低気温{this._temperatures.Min()}");
    }

  }
}
