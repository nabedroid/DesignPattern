namespace Command {
  internal class Program {
    static void Main(string[] args) {

      //Control.RemoteControl remote = new Control.RemoteControl();

      //Vender.Light livingRoomLight = new Vender.Light("リビングルーム");
      //Vender.Light kitchenLight = new Vender.Light("キッチン");
      //Vender.CeilingFan ceilingFan = new Vender.CeilingFan("リビングルーム");
      //Vender.GarageDoor garage = new Vender.GarageDoor("ガレージ");
      //Vender.Stereo stereo = new Vender.Stereo("リビングルーム");

      //Command.ICommand livingRoomLightOn = new Command.Light.LightOnCommand(livingRoomLight);
      //Command.ICommand livingRoomLightOff = new Command.Light.LightOffCommand(livingRoomLight);
      //Command.ICommand kitchenLightOn = new Command.Light.LightOnCommand(kitchenLight);
      //Command.ICommand kitchenLightOff = new Command.Light.LightOffCommand(kitchenLight);
      //Command.ICommand ceilingFanOn = new Command.CeilingFan.CeilingFanHighCommand(ceilingFan);
      //Command.ICommand ceilingFanOff = new Command.CeilingFan.CeilingFanOffCommand(ceilingFan);
      //Command.ICommand garageDoorUp = new Command.GarageDoor.GarageDoorOpenCommand(garage);
      //Command.ICommand garageDoorDown = new Command.GarageDoor.GarageDoorDownCommand(garage);
      //Command.ICommand stereoOnWithCd = new Command.Stereo.StereoOnWithCDCommand(stereo);
      //Command.ICommand stereoOff = new Command.Stereo.StereoOffCommand(stereo);

      //remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
      //remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
      //remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
      //remote.SetCommand(3, stereoOnWithCd, stereoOff);

      //System.Console.WriteLine(remote);

      //remote.OnButtonWasPushed(0);
      //remote.OffButtonWasPushed(0);
      //remote.OnButtonWasPushed(1);
      //remote.OffButtonWasPushed(1);
      //remote.OnButtonWasPushed(2);
      //remote.OffButtonWasPushed(2);
      //remote.OnButtonWasPushed(3);
      //remote.OffButtonWasPushed(3);

      //Control.RemoteControlWithUndo rc = new Control.RemoteControlWithUndo();

      //Vender.CeilingFan ceilingFan = new Vender.CeilingFan("リビングルーム");

      //Command.ICommand ceilingFanMedium = new Command.CeilingFan.CeilingFanMediumCommand(ceilingFan);
      //Command.ICommand ceilingFanHigh = new Command.CeilingFan.CeilingFanHighCommand(ceilingFan);
      //Command.ICommand ceilingFanOff = new Command.CeilingFan.CeilingFanOffCommand(ceilingFan);

      //rc.SetCommand(0, ceilingFanMedium, ceilingFanOff);
      //rc.SetCommand(1, ceilingFanHigh, ceilingFanOff);

      //rc.OnButtonWasPushed(0);
      //rc.OffButtonWasPushed(0);
      //System.Console.WriteLine(rc);
      //rc.UndoButtonWasPushed();

      //rc.OnButtonWasPushed(1);
      //System.Console.WriteLine(rc);
      //rc.UndoButtonWasPushed();


      //System.Console.ReadKey();

      Control.RemoteControlWithUndo rc = new Control.RemoteControlWithUndo();

      Vender.Light light = new Vender.Light("リビングルーム");
      Vender.Tv tv = new Vender.Tv("リビングルーム");
      Vender.Stereo stereo = new Vender.Stereo("リビングルーム");
      Vender.Hottub hottub = new Vender.Hottub();

      Command.ICommand lightOn = new Command.Light.LightOnCommand(light);
      Command.ICommand stereoOn = new Command.Stereo.StereoOnWithCDCommand(stereo);
      Command.ICommand tvOn = new Command.Tv.TvOnCommand(tv);
      Command.ICommand hottubOn = new Command.Hottub.HottubOnCommand(hottub);

      Command.ICommand lightOff = new Command.Light.LightOffCommand(light);
      Command.ICommand stereoOff = new Command.Stereo.StereoOffCommand(stereo);
      Command.ICommand tvOff = new Command.Tv.TvOffCommand(tv);
      Command.ICommand hottubOff = new Command.Hottub.HottubOffCommand(hottub);

      Command.ICommand[] partyOn = new Command.ICommand[] { lightOn, stereoOn, tvOn, hottubOn };
      Command.ICommand[] partyOff = new Command.ICommand[] { lightOff, stereoOff, tvOff, hottubOff };
      Command.ICommand partyOnMacro = new Command.MacroCommand(partyOn);
      Command.ICommand partyOffMacro = new Command.MacroCommand(partyOff);

      rc.SetCommand(0, partyOnMacro, partyOffMacro);

      System.Console.WriteLine(rc);
      System.Console.WriteLine("--- マクロのOnを押す ---");
      rc.OnButtonWasPushed(0);
      System.Console.WriteLine("--- マクロのOffを押す ---");
      rc.OffButtonWasPushed(0);

      System.Console.ReadKey();
    }
  }
}
