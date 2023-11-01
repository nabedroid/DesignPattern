﻿
namespace Command.Command.CeilingFan {
  internal class CeilingFanMediumCommand : ICommand {
    private Vender.CeilingFan _ceilingFan;
    private Vender.CeilingFan.Speed _prevSpeed;

    public CeilingFanMediumCommand(Vender.CeilingFan ceilingFan) {
      this._ceilingFan = ceilingFan;
    }

    public void Execute() {
      this._prevSpeed = this._ceilingFan.GetSpeed();
      this._ceilingFan.Medium();
    }

    public void Undo() {
      switch(this._prevSpeed) {
        case Vender.CeilingFan.Speed.強: this._ceilingFan.High(); break;
        case Vender.CeilingFan.Speed.中: this._ceilingFan.Medium(); break;
        case Vender.CeilingFan.Speed.弱: this._ceilingFan.Low(); break;
        case Vender.CeilingFan.Speed.OFF: this._ceilingFan.Off(); break;
      }
    }
  }
}
