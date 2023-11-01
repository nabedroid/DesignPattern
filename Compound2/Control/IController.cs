namespace Compound2.Control {
  internal interface IController {
    void Start();
    void Stop();
    void IncreaseBPM();
    void DecreaseBPM();
    int BPM { set; }
  }
}
