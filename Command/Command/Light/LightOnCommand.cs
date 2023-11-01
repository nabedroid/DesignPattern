namespace Command.Command.Light {
  internal class LightOnCommand : ICommand {
    private Vender.Light _light;

    public LightOnCommand(Vender.Light light) {
      this._light = light;
    }

    public void Execute() {
      this._light?.On();
    }

    public void Undo() {
      this._light?.Off();
    }
  }
}
