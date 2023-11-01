using System.Runtime.CompilerServices;

namespace Singleton {
  internal class ChocolateBoiler {
    private static ChocolateBoiler _instance;
    private bool _empty;
    private bool _boiled;

    [MethodImpl(MethodImplOptions.Synchronized)]
    public static ChocolateBoiler GetInstance() {
      if (_instance == null) { 
        _instance = new ChocolateBoiler();
      }
      return _instance;
    }

    private ChocolateBoiler() {
      this._empty = true;
      this._boiled = false;
    }

    public void Fill() {
      if (this._empty) {
        this._empty = false;
        this._boiled = true;
      }
    }

    public void Drain() {
      if (!this._empty && this._boiled) {
        this._empty = true;
        this._boiled = false;
      }
    }

    public void Boid() {
      if (!this._empty && !this._boiled) {
        this._boiled = true;
      }
    }

    public bool Empty { get { return this._empty; } }
    public bool Boiled { get { return this._boiled; } }
  }
}
