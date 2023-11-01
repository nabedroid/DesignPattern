using Compound2.Observer;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Compound2.Model {

  internal class HeartModel : IHeartModel {

    private List<IBeatObserver> _beatObservers = new List<IBeatObserver>();
    private List<IBPMObserver> _bpmObservers = new List<IBPMObserver>();
    private int _time = 1000;
    private int _bpm = 90;
    private System.Random _random = new System.Random();
    private CancellationTokenSource _tokenSource;
    private Task _thread;

    public HeartModel() {
      _tokenSource = new CancellationTokenSource();
      _thread = Task.Run(Run, _tokenSource.Token);
    }

    public void Run() {
      int lastrate = -1;
      // フォーム作成前にタスク実行されないように無理やり1秒待たせる
      Thread.Sleep(1000);

      for (;;) {
        int change = _random.Next(10);
        if (_random.Next(2) == 0) {
          change = 0 - change;
        }
        int rate = 60000 / (_time + change);
        if (rate < 120 && rate > 50) {
          _time += change;
          NotifyBeatObservers();
          if (rate != lastrate) {
            lastrate = rate;
            NotifyBPMObservers();
          }
        }
        try {
          Thread.Sleep(_time);
        } catch (System.Exception e) {
          System.Console.WriteLine(e);
        }
      }
    }
    public int GetHeartRate() {
      return 60000 / _time;
    }

    public void RegisterObserver(IBeatObserver o) {
      _beatObservers.Add(o);
    }

    public void RemoveObserver(IBeatObserver o) {
      _beatObservers.Remove(o);
    }
    public void NotifyBeatObservers() {
      foreach (IBeatObserver o in _beatObservers) {
        o.UpdateBeat();
      }
    }

    public void RegisterObserver(IBPMObserver o) {
      _bpmObservers.Add(o);
    }

    public void RemoveObserver(IBPMObserver o) {
      _bpmObservers.Remove(o);
    }

    public void NotifyBPMObservers() {
      foreach (IBPMObserver o in _bpmObservers) {
        o.UpdateBPM();
      }
    }

  }

}
