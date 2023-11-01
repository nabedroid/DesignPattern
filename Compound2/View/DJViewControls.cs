using System.Windows.Forms;
using Compound2.Observer;
using System.Drawing;
using System;

namespace Compound2.View {

  internal partial class DJView : IBeatObserver, IBPMObserver {

    private Form _controlFrame;
    private Panel _controlPanel;
    private Label _bpmLabel;
    private TextBox _bpmTextField;
    private Button _setBPMButton;
    private Button _increaseBPMButton;
    private Button _decreaseBPMButton;
    private MenuStrip _menuBar;
    private ToolStripMenuItem _menu;
    private ToolStripMenuItem _startMenuItem;
    private ToolStripMenuItem _stopMenuItem;

    public void CreateControls() {
      // Menu 関連
      _startMenuItem = new ToolStripMenuItem() { Text = "開始" };
      _startMenuItem.Click += (object sender, EventArgs e) => { _controller.Start(); };

      _stopMenuItem = new ToolStripMenuItem() { Text = "停止" };
      _stopMenuItem.Click += (object sender, EventArgs e) => { _controller.Stop(); };

      ToolStripMenuItem exit = new ToolStripMenuItem() { Text = "終了" };
      exit.Click += (object sender, EventArgs e) => { Application.ExitThread(); };

      _menu = new ToolStripMenuItem() { Text = "DJコントロール" };
      _menu.DropDownItems.AddRange(new ToolStripItem[] { _startMenuItem, _stopMenuItem, exit });

      _menuBar = new MenuStrip() { GripStyle = ToolStripGripStyle.Visible };
      _menuBar.SuspendLayout();
      _menuBar.Items.AddRange(new ToolStripMenuItem[] { _menu });
      _menuBar.Location = new Point(0, 0);

      // BPM入力
      _bpmLabel = new Label() { Text = "BPMを入力：", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };

      _bpmTextField = new TextBox() { Dock = DockStyle.Fill, MaxLength = 3, Anchor = AnchorStyles.Bottom };

      TableLayoutPanel enterPanel = new TableLayoutPanel() { ColumnCount = 2, RowCount = 1 };
      enterPanel.SuspendLayout();
      enterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
      enterPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
      enterPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      enterPanel.Controls.Add(_bpmLabel, 0, 0);
      enterPanel.Controls.Add(_bpmTextField, 1, 0);

      // 設定ボタン
      _setBPMButton = new Button() { Text = "設定", Dock = DockStyle.Fill };
      _setBPMButton.Click += ActionPerformed;

      // 増減ボタン
      _increaseBPMButton = new Button() { Text = ">>", Dock = DockStyle.Fill };
      _increaseBPMButton.Click += ActionPerformed;

      _decreaseBPMButton = new Button() { Text = "<<", Dock = DockStyle.Fill };
      _decreaseBPMButton.Click += ActionPerformed;

      TableLayoutPanel buttonPanel = new TableLayoutPanel() { ColumnCount = 2, RowCount = 1 };
      buttonPanel.SuspendLayout();
      buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      buttonPanel.Controls.Add(_decreaseBPMButton, 0, 0);
      buttonPanel.Controls.Add(_increaseBPMButton, 1, 0);

      // BPM、設定、増減ボタンを配置
      TableLayoutPanel insideControlPanel = new TableLayoutPanel() { ColumnCount = 1, RowCount = 3 };
      insideControlPanel.SuspendLayout();
      insideControlPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      insideControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
      insideControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
      insideControlPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
      insideControlPanel.Controls.Add(enterPanel, 0, 0);
      insideControlPanel.Controls.Add(_setBPMButton, 0, 1);
      insideControlPanel.Controls.Add(buttonPanel, 0, 2);

      // Formに配置
      _controlPanel = new Panel() { Dock = DockStyle.Fill };
      _controlPanel.SuspendLayout();
      _controlPanel.Controls.Add(insideControlPanel);

      _controlFrame = new Form() { Text = "コントロール" };
      _controlFrame.Size = new Size(230, 180);
      _controlFrame.FormClosed += (object sender, FormClosedEventArgs e) => { Application.ExitThread(); };
      _controlFrame.Controls.Add(_controlPanel);
      _controlFrame.Controls.Add(_menuBar);
      _controlFrame.MainMenuStrip = _menuBar;

      _menuBar.ResumeLayout(false);
      _menuBar.PerformLayout();
      enterPanel.ResumeLayout(false);
      enterPanel.PerformLayout();
      buttonPanel.ResumeLayout(false);
      buttonPanel.PerformLayout();
      insideControlPanel.ResumeLayout(false);
      insideControlPanel.PerformLayout();
      _controlPanel.ResumeLayout(false);
      _controlPanel.PerformLayout();
      _controlFrame.ResumeLayout(false);
      _controlFrame.PerformLayout();
      _controlFrame.Show();
    }

    public void EnableStopMenuItem() {
      _stopMenuItem.Enabled = true;
    }

    public void DisableStopMenuItem() {
      _stopMenuItem.Enabled = false;
    }

    public void EnableStartMenuItem() {
      _startMenuItem.Enabled = true;
    }

    public void DisableStartMenuItem() {
      _startMenuItem.Enabled = false;
    }

    public void ActionPerformed(object sender, EventArgs e) {
      if (sender == _setBPMButton) {
        int bpm = 90;
        if (_bpmTextField.Text.Length > 0) {
          bpm = int.Parse(_bpmTextField.Text);
        }
        _controller.BPM = bpm;
      } else if (sender == _increaseBPMButton) {
        _controller.IncreaseBPM();
      } else if (sender == _decreaseBPMButton) {
        _controller.DecreaseBPM();
      }
    }

  }

}