using Compound2.Observer;

namespace Compound2.Model {

  internal class HeartAdapter : IBeatModel {

    private IHeartModel _heart;

    public HeartAdapter(IHeartModel heart) {
      this._heart = heart;
    }

    public void Initialize() { }

    public void On() { }

    public void Off() { }

    public int BPM {
      get { return  _heart.GetHeartRate(); }
      set { }
    }

    public void RegisterObserver(IBeatObserver o) {
      _heart.RegisterObserver(o);
    }

    public void RemoveObserver(IBeatObserver o) {
      _heart.RemoveObserver(o);
    }

    public void RegisterObserver(IBPMObserver o) {
      _heart.RegisterObserver(o);
    }

    public void RemoveObserver(IBPMObserver o) {
      _heart.RemoveObserver(o);
    }

  }

}

