using Compound2.Model;
using Compound2.View;

namespace Compound2.Control {

  internal class HeartController : IController {

    private IHeartModel _model;
    private DJView _view;

    public HeartController(IHeartModel model) {
      this._model = model;
      _view = new DJView(this, new HeartAdapter(model));
      _view.CreateView();
      _view.CreateControls();
      _view.DisableStopMenuItem();
      _view.DisableStartMenuItem();
    }

    public void Start() { }

    public void Stop() { }

    public void IncreaseBPM() { }

    public void DecreaseBPM() { }

    public int BPM {
      set { }
    }

  }

}