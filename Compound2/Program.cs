using Compound2.Control;
using Compound2.Model;
using System;
using System.Windows.Forms;

namespace Practice {
  internal class Program {

    [STAThread]
    static void Main(string[] args) {

      // IBeatModel model = new BeatModel();
      // IController controller = new BeatController(model);
      HeartModel heartModel = new HeartModel();
      IController controller = new HeartController(heartModel);

      Application.Run();
    }
  }
}
