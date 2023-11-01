using Compound2.Model;
using Compound2.View;

namespace Compound2.Control {

  internal class BeatController : IController {

    private IBeatModel _model;
    private DJView _view;

    public BeatController(IBeatModel model) {
      this._model = model;
      _view = new DJView(this, _model);
      _view.CreateView();
      _view.CreateControls();
      _view.DisableStartMenuItem();
      _view.EnableStartMenuItem();
      _model.Initialize();
    }

    public void Start() {
      _model.On();
      _view.DisableStartMenuItem();
      _view.EnableStopMenuItem();
    }

    public void Stop() {
      _model.Off();
      _view.DisableStopMenuItem();
      _view.EnableStartMenuItem();
    }

    public void IncreaseBPM() {
      int bpm = _model.BPM;
      _model.BPM = bpm + 1;
    }

    public void DecreaseBPM() {
      int bpm = _model.BPM;
      _model.BPM = bpm - 1;
    }

    public int BPM {
      set { _model.BPM = value; }
    }

  }

}
