namespace Command.Command.Tv {

  internal class TvOnCommand : ICommand {
    
    private Vender.Tv _tv;

    public TvOnCommand(Vender.Tv tv) {
      this._tv = tv;
    }

    public void Execute() {
      this._tv?.On();
    }

    public void Undo() {
      this._tv.Off();
    }
  }
}
