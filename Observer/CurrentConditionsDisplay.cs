namespace Observer {
  internal class CurrentConditionsDisplay : IObserver, IDisplayElement {
    private float _temperature;
    private float _humidity;
    private WeatherData _weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData) {
      this._weatherData = weatherData;
      weatherData.RegisterObserver(this);
    }

    public void Update() {
      this._temperature = this._weatherData.Temperature;
      this._humidity = this._weatherData.Humidity;
      this.Display();
    }

    public void Display() {
      System.Console.WriteLine($"現在の気象状況：温度{this._temperature}度（華氏） 湿度{this._humidity}%");
    }

  }
}
