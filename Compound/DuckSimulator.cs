using Compound.Duck;

namespace Compound {

  internal class DuckSimulator {

    public void simulate(AbstractDuckFactory duckFactory) {
      IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
      IQuackable duckCall = duckFactory.CreateDuckCall();
      IQuackable rubberDuck = duckFactory.CreateRubberDuck();
      IQuackable gooseDuck = new Goose.GooseAdapter(new Goose.Goose());
      
      Flock flockOfDucks = new Flock();
      flockOfDucks.Add(redheadDuck);
      flockOfDucks.Add(duckCall);
      flockOfDucks.Add(rubberDuck);
      flockOfDucks.Add(gooseDuck);

      IQuackable mallardOne = duckFactory.CreateMallardDuck();
      IQuackable mallardTwo = duckFactory.CreateMallardDuck();
      IQuackable mallardThree = duckFactory.CreateMallardDuck();
      IQuackable mallardFour = duckFactory.CreateMallardDuck();

      Flock flockOfMallards = new Flock();
      flockOfMallards.Add(mallardOne);
      flockOfMallards.Add(mallardTwo);
      flockOfMallards.Add(mallardThree);
      flockOfMallards.Add(mallardFour);

      flockOfDucks.Add(flockOfMallards);

      System.Console.WriteLine("カモシミュレータ：オブザーバ付き");

      Quackologist quackologist = new Quackologist();
      flockOfDucks.RegisterObserver(quackologist);

      simulate(flockOfDucks);

      System.Console.WriteLine($"カモが鳴いた回数：{QuackCounter.GetQuacks()}回");

    }

    public void simulate(IQuackable duck) {
      duck.Quack();
    }

  }

}
