namespace Facade.SubSystem {

  public class Screen {
    private string _description;

    public Screen(string description) {
      this._description = description;
    }

    public void Up() {
      System.Console.WriteLine(this._description + " going up");
    }

    public void Down() {
      System.Console.WriteLine(this._description + " going down");
    }


    public override string ToString() {
      return this._description;
    }
  
  }

}
