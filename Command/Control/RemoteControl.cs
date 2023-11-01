using Command.Command;

namespace Command.Control {
  internal class RemoteControl {
    private ICommand[] _onCommands;
    private ICommand[] _offCommands;

    public RemoteControl() {
      this._onCommands = new ICommand[7];
      this._offCommands = new ICommand[7];

      for (int i = 0; i < 7; i++) {
        this._onCommands[i] = new NoCommand();
        this._offCommands[i] = new NoCommand();
      }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand) {
      this._onCommands[slot] = onCommand;
      this._offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot) {
      this._onCommands[slot].Execute();
    }

    public void OffButtonWasPushed(int slot) {
      this._offCommands[slot].Execute();
    }

    public override string ToString() {
      System.Text.StringBuilder sb = new System.Text.StringBuilder("------ リモコン ------\n");
      for (int i = 0; i < 7; i++) {
        sb.Append($" [スロット{i}] {this._onCommands[i].GetType()} {this._offCommands[i].GetType()}\n");
      }
      return sb.ToString();
    }
  }
}
