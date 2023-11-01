using Compound2.Observer;

namespace Compound2.Model {

  internal interface IBeatModel {

    void Initialize();
    void On();
    void Off();
    int BPM { get; set; }
    void RegisterObserver(IBeatObserver o);
    void RemoveObserver(IBeatObserver o);
    void RegisterObserver(IBPMObserver o);
    void RemoveObserver(IBPMObserver o);

  }

}
