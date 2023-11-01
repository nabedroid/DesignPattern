namespace Command.Command.Hottub {
  internal class HottubOnCommand : ICommand {
    private Vender.Hottub _hottub;

    public HottubOnCommand(Vender.Hottub hottub) {
      this._hottub = hottub;
    } 

    public void Execute() {
      this._hottub?.On();
      this._hottub?.SetTemperature(40);
      this._hottub?.Circulate();
    }

    public void Undo() {
      this._hottub?.Off();
    }
  }
}
