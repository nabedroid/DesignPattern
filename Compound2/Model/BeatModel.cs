using Compound2.Observer;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace Compound2.Model {
  internal class BeatModel : IBeatModel {
    private List<IBeatObserver> _beatObservers = new List<IBeatObserver>();
    private List<IBPMObserver> _bmpObservers = new List<IBPMObserver>();
    private CancellationTokenSource _tokenSource;
    private Task _thread;
    private bool _stop = false;
    private int _bmp = 90;
    private SoundPlayer _clip;

    public void Initialize() {
      try {
        _clip = new SoundPlayer("C:\\work\\cs\\DesignPattern\\Compound2\\clap.wav");
      } catch (IOException e) {
        System.Console.WriteLine($"{e.Message}");
      }
    }

    public void On() {
      System.Console.WriteLine("ON");
      _bmp = 90;
      NotifyBPMObservers();
      _stop = false;
      _tokenSource = new CancellationTokenSource();
      _thread = Task.Run(Run, _tokenSource.Token);
    }

    public void Off() {
      StopBeat();
      _tokenSource.Cancel();
      _stop = true;
    }

    public void Run() {
      System.Console.WriteLine($"Run While Start Beat BMP[{_bmp}] STOP[{_stop}]");
      while (!_stop) {
        PlayBeat();
        NotifyBeatObservers();
        try {
          Thread.Sleep(60000 / _bmp);
        } catch (System.Exception e) {
          System.Console.WriteLine($"{e.Message}");
        }
      }
    }

    public int BPM {
      get => _bmp;
      set {
        _bmp = value;
        NotifyBPMObservers();
      }
    }

    public void RegisterObserver(IBeatObserver o) { _beatObservers.Add(o); }
    public void RegisterObserver(IBPMObserver o) { _bmpObservers.Add(o); }
    public void RemoveObserver(IBeatObserver o) { _beatObservers.Remove(o); }
    public void RemoveObserver(IBPMObserver o) { _bmpObservers.Remove(o); }

    public void NotifyBeatObservers() {
      foreach (IBeatObserver o in _beatObservers) {
        o.UpdateBeat();
      }
    }

    public void NotifyBPMObservers() {
      foreach (IBPMObserver o in _beatObservers) {
        o.UpdateBPM();
      }
    }

    public void PlayBeat() {
      _clip.Play();
    }

    public void StopBeat() {
      _clip.Stop();
    }

  }

}
