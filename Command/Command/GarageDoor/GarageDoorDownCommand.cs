namespace Command.Command.GarageDoor {
  internal class GarageDoorDownCommand : ICommand {
    private Vender.GarageDoor _garageDoor;

    public GarageDoorDownCommand(Vender.GarageDoor garageDoor) {
      this._garageDoor = garageDoor;
    }

    public void Execute() {
      this._garageDoor?.Down();
    }

    public void Undo() {
      this._garageDoor?.Up();
    }

  }
}
