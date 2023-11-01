using Command.Command;
using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace Command.Control {
  internal class RemoteControlWithUndo {
    private ICommand[] _onCommands;
    private ICommand[] _offCommands;
    private ICommand _undoCommand;

    public RemoteControlWithUndo() {
      this._onCommands = new ICommand[7];
      this._offCommands = new ICommand[7];

      for (int i = 0; i < 7; i++) {
        this._onCommands[i] = new NoCommand();
        this._offCommands[i] = new NoCommand();
      }
      this._undoCommand = new NoCommand();
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand) {
      this._onCommands[slot] = onCommand;
      this._offCommands[slot] = offCommand;
    }

    public void OnButtonWasPushed(int slot) {
      this._onCommands[slot].Execute();
      this._undoCommand = this._onCommands[slot];
    }

    public void OffButtonWasPushed(int slot) {
      this._offCommands[slot].Execute();
      this._undoCommand = this._offCommands[slot];
    }

    public void UndoButtonWasPushed() {
      this._undoCommand.Undo();
    }

    public override string ToString() {
      System.Text.StringBuilder sb = new System.Text.StringBuilder("------ リモコン ------\n");
      for (int i = 0; i < 7; i++) {
        sb.Append($" [スロット{i}] {this._onCommands[i].GetType().Name} {this._offCommands[i].GetType().Name}\n");
      }
      sb.Append($" [Undo] {this._undoCommand.GetType().Name}\n");
      return sb.ToString();
    }
  }
}
