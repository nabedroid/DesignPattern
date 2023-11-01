namespace Command.Command.Stereo {
  internal class StereoOnWithCDCommand : ICommand {
    private Vender.Stereo _stereo;

    public StereoOnWithCDCommand(Vender.Stereo stereo) {
      this._stereo = stereo;
    }

    public void Execute() {
      this._stereo.On();
      this._stereo.SetCd();
      this._stereo.SetVolume(11);
    }

    public void Undo() {
      this._stereo.Off();
    }
  }
}
