namespace Facade.SubSystem {
  public class PopcornPopper {
    private string _description;

    public PopcornPopper(string description) {
      this._description = description;
    }

    public void On() {
      System.Console.WriteLine(this._description + " on");
    }

    public void Off() {
      System.Console.WriteLine(this._description + " off");
    }

    public void Pop() {
      System.Console.WriteLine(this._description + " popping popcorn!");
    }


    public override string ToString() {
      return this._description;
    }
  }
}
