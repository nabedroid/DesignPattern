namespace Command.Command.Stereo {
  internal class StereoOffCommand : ICommand {
    private Vender.Stereo _stereo;

    public StereoOffCommand(Vender.Stereo stereo) {
      this._stereo = stereo;
    }

    public void Execute() {
      this._stereo.Off();
    }

    public void Undo() {
      this._stereo.On();
    }
  }
}
