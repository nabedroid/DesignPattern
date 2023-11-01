namespace Command.Command.GarageDoor {
  internal class GarageDoorOpenCommand : ICommand {
    private Vender.GarageDoor _garageDoor;

    public GarageDoorOpenCommand(Vender.GarageDoor garageDoor) {
      this._garageDoor = garageDoor;
    }

    public void Execute() {
      this._garageDoor?.Up();
    }

    public void Undo() {
      this._garageDoor?.Down();
    }
  }
}
