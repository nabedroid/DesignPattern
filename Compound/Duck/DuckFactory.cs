﻿namespace Compound.Duck {

  internal class DuckFactory : AbstractDuckFactory {

    public override IQuackable CreateMallardDuck() {
      return new MallardDuck();
    }

    public override IQuackable CreateRedheadDuck() {
      return new RedheadDuck();
    }

    public override IQuackable CreateDuckCall() {
      return new DuckCall();
    }

    public override IQuackable CreateRubberDuck() {
      return new RubberDuck();
    }

  }

}
