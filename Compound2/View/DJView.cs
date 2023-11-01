using Compound2.Model;
using Compound2.Control;
using System.Windows.Forms;
using Compound2.Observer;
using System;

namespace Compound2.View {

  internal partial class DJView : IBeatObserver, IBPMObserver {

    private IBeatModel _model;
    private IController _controller;
    private Form _viewFrame;
    private Panel _viewPanel;
    private BeatBar _beatBar;
    private Label _bpmOutputLabel;

    public DJView(IController controller, IBeatModel model) {
      _controller = controller;
      _model = model;
      _model.RegisterObserver((IBeatObserver)this);
      _model.RegisterObserver((IBPMObserver)this);
    }

    public void CreateView() {
      // BeatBar
      _beatBar = new BeatBar() { Style = ProgressBarStyle.Continuous, Dock = DockStyle.Fill, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };
      _beatBar.Value = 0;

      _bpmOutputLabel = new Label() { Text = "オフライン", TextAlign = System.Drawing.ContentAlignment.TopLeft };

      TableLayoutPanel bpmPanel = new TableLayoutPanel() { ColumnCount = 1, RowCount = 2, Dock = DockStyle.Fill };
      bpmPanel.SuspendLayout();
      bpmPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      bpmPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      bpmPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      bpmPanel.Controls.Add(_beatBar, 0, 0);
      bpmPanel.Controls.Add(_bpmOutputLabel, 0, 1);

      _viewPanel = new Panel() { Dock = DockStyle.Fill };
      _viewPanel.SuspendLayout();
      _viewPanel.Controls.Add(bpmPanel);

      _viewPanel.Dock = DockStyle.Fill;

      _viewFrame = new Form();
      _viewFrame.Size = new System.Drawing.Size(150, 100);
      _viewFrame.FormClosed += (object sender, FormClosedEventArgs e) => { Application.ExitThread(); };
      _viewFrame.Controls.Add(_viewPanel);

      bpmPanel.ResumeLayout(false);
      bpmPanel.PerformLayout();
      _viewPanel.ResumeLayout(false);
      _viewPanel.PerformLayout();
      _viewFrame.ResumeLayout(false);
      _viewFrame.PerformLayout();
      _viewFrame.Show();
    }

    public void UpdateBeat() {
      if (_beatBar != null) {
        if (_beatBar.InvokeRequired) {
          _beatBar.Invoke(new Action(UpdateBeat));
        } else {
          _beatBar.Value = 100;
        }
      }
    }

    public void UpdateBPM() {
      int bpm = _model.BPM;
      if (_bpmOutputLabel.InvokeRequired) {
        _bpmOutputLabel.Invoke(new Action(UpdateBPM));
      } else {
        if (bpm == 0) {
          _bpmOutputLabel.Text = "オフライン";
        } else {
          _bpmOutputLabel.Text = $"現在のBPM：{bpm}";
        }
      }
    }

  }
}
