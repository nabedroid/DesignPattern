namespace Strategy {

  public abstract class Character {
    public WeaponBehavior weapon;

    public WeaponBehavior WeaponBehavior {
      set { this.weapon = value; }
    }

    public abstract void fight();

    public void setWeapon(WeaponBehavior w) {
      this.weapon = w;
    }
  }

  public class Queen : Character {
    public override void fight() {}
  }

  public class King : Character {
    public override void fight() {}
  }

  public class Knight : Character {
    public override void fight() {}
  }

  public class Troll : Character {
    public override void fight() {}
  }

  public interface WeaponBehavior {
    void useWeapon();
  }

  public class KnifeBehavior : WeaponBehavior {
    public void useWeapon() {}
  }

  public class AxeBehavior : WeaponBehavior {
    public void useWeapon() {}
  }

  public class SwordBehavior : WeaponBehavior {
    public void useWeapon() {}
  }

  public class BowAndArrowBehavior : WeaponBehavior {
    public void useWeapon() {}
  }
}
