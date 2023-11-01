namespace Command.Command.Light {
  internal class LightOffCommand : ICommand {
    private Vender.Light _light;

    public LightOffCommand(Vender.Light light) {
      this._light = light;
    }

    public void Execute() {
      this._light?.Off();
    }

    public void Undo() {
      this._light?.On();
    }
  }
}
