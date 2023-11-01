using System.Collections.Generic;

namespace Observer {
  internal class WeatherData : ISubject {
    private List<IObserver> _iObservers;
    private float _temperature;
    private float _humidity;
    private float _pressure;


    public WeatherData() {
      this._iObservers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver iObserver) {
      this._iObservers.Add(iObserver);
    }

    public void RemoveObserver(IObserver iObserver) {
      this._iObservers.Remove(iObserver);
    }

    public void NotifyObservers() {
      foreach (IObserver iObserver in this._iObservers) {
        iObserver.Update();
      }
    }

    public void MeasurementsChanged() {
      this.NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure) {
      this._temperature = temperature;
      this._humidity = humidity;
      this._pressure = pressure;
      this.MeasurementsChanged();
    }

    public float Temperature {
      get { return this._temperature; }
    }

    public float Humidity {
      get { return this._humidity; }
    }

    public float Pressure {
      get { return this._pressure; }
    }
  }
}
