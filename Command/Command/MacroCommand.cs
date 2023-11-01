using System.Linq;

namespace Command.Command {
  internal class MacroCommand : ICommand{
    private ICommand[] _commands;

    public MacroCommand(ICommand[] commands) {
      this._commands = commands;
    }

    public void Execute() {
      foreach (ICommand command in _commands) {
        command.Execute();
      }
    }
    
    public void Undo() {
      foreach (ICommand command in _commands.Reverse()) {
        command.Undo();
      }
    }

  }
}
