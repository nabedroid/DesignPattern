using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound2.View {

  internal class BeatBar : ProgressBar {

    private Task _thread;
    private CancellationTokenSource _tokenSource;

    public BeatBar() {
      Maximum = 100;
      _tokenSource = new CancellationTokenSource();
      _thread = Task.Run(Run, _tokenSource.Token);
    }

    protected override void Dispose(bool disposing) {
      base.Dispose(disposing);
      _tokenSource.Cancel();
    }

    public void Run() {
      for (;;) {
        int value = (int)(Value * 0.75);
        if (this.InvokeRequired) {
          Invoke(new System.Action(() => { Value = value; }));
        } else {
          Value = value;
        }
        try {
          Thread.Sleep(50);
        } catch (System.Exception e) {
          System.Console.WriteLine(e);
        }
      }
    }

  }

}
