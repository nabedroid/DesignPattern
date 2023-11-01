namespace Command.Command.Tv {

  internal class TvOffCommand : ICommand {
    
    private Vender.Tv _tv;

    public TvOffCommand(Vender.Tv tv) {
      this._tv = tv;
    }

    public void Execute() {
      this._tv?.Off();
    }

    public void Undo() {
      this._tv.On();
    }
  }
}
