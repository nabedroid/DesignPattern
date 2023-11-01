using Compound2.Observer;

namespace Compound2.Model {
  internal interface IHeartModel {
    int GetHeartRate();
    void RegisterObserver(IBeatObserver o);
    void RemoveObserver(IBeatObserver o);
    void RegisterObserver(IBPMObserver o);
    void RemoveObserver(IBPMObserver o);
  }
}
