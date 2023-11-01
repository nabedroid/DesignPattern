namespace Observer {
  internal class HeatIndexDisplay : IObserver, IDisplayElement {
    private float _temperature;
    private float _humidity;
    private WeatherData _weatherData;

    public HeatIndexDisplay(WeatherData weatherData) {
      this._weatherData = weatherData;
      weatherData.RegisterObserver(this);
    }

    public void Update() {
      this._temperature = this._weatherData.Temperature;
      this._humidity = this._weatherData.Humidity;
      this.Display();
    }

    public void Display() {
      System.Console.WriteLine($"熱指数：{this.ComputeHeatIndex(this._temperature, this._humidity)}");
    }

    private float ComputeHeatIndex(float t, float rh) {
      float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
        (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
        (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
        (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *  
        (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
        (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +     
        0.000000000843296 * (t * t * rh * rh * rh)) -
        (0.0000000000481975 * (t * t * t * rh * rh * rh)));
	    return index;
    }
  }
}
