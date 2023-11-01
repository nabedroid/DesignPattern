using Factory.Ingredient;

namespace Factory.Pizza {
  internal abstract class Pizza {
    // 商品名
    protected string _name;
    // 材料
    protected IDough _dough;
    protected ISauce _sauce;
    protected IVeggies[] _veggies;
    protected ICheese _cheese;
    protected IPepperoni _pepperoni;
    protected IClam _clam;

    public abstract void Prepare();

    public virtual void Bake() {
      System.Console.WriteLine("180度で25分間焼く");
    }

    public virtual void Cut() {
      System.Console.WriteLine("ピザを扇状にカットする");
    }

    public virtual void Box() {
      System.Console.WriteLine("PizzaStoreの箱にピザを入れる");
    }

    public string Name {
      set {  this._name = value; }
      get { return this._name; }
    }

    public override string ToString() {
      return "ピザを出力するコード";
    }
  }
}
