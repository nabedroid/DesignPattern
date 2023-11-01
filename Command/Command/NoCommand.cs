namespace Command.Command {
  internal class NoCommand : ICommand {
    public void Execute() {
      System.Console.WriteLine("コマンドが設定されていません");
    }

    public void Undo() {
      System.Console.WriteLine("コマンドが設定されていません");
    }
  }
}
