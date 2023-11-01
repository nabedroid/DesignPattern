using Command.Command;

namespace Command {
  internal class SimpleRemoteControl {
    private ICommand _slot;

    public SimpleRemoteControl() {

    }

    public void SetCommand(ICommand command) {
      this._slot = command;
    }

    public void buttonWasPressed() {
      this._slot?.Execute();
    }
  }
}
