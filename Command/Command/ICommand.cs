﻿namespace Command.Command {
  internal interface ICommand {
    void Execute();
    void Undo();
  }
}