namespace Observer {

  internal class ForecastDisplay : IObserver, IDisplayElement {
    private float _currentPressure = 29.92f;  
    private float _lastPressure;
    private WeatherData _weatherData;

    public ForecastDisplay(WeatherData weatherData) {
      this._weatherData = weatherData;
      weatherData.RegisterObserver(this);
    }

    public void Update() {
      this._lastPressure = this._currentPressure;
      this._currentPressure = this._weatherData.Pressure;
      Display();
    }

    public void Display() {
      System.Console.Write("予報：");
      if (this._currentPressure > this._lastPressure) {
      System.Console.WriteLine("天気は良くなります！");
    } else if (this._currentPressure == this._lastPressure) {
      System.Console.WriteLine("ほとんど同じです");
    } else if (this._currentPressure < this._lastPressure) {
      System.Console.WriteLine("寒い雨模様の天候に注意してください");
    }
  }
  }
}