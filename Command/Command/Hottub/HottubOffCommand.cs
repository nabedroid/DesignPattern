namespace Command.Command.Hottub {
  internal class HottubOffCommand : ICommand {
    private Vender.Hottub _hottub;

    public HottubOffCommand(Vender.Hottub hottub) {
      this._hottub = hottub;
    } 

    public void Execute() {
      this._hottub?.Off();
      this._hottub?.SetTemperature(37);
    }

    public void Undo() {
      this._hottub?.On();
    }
  }
}
