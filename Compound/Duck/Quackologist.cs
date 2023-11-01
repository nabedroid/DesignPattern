namespace Compound.Duck {
  internal class Quackologist : IObserver {
    public void Update(IQuackObservable duck) {
      System.Console.WriteLine($"カモの鳴き声学者：{duck}が鳴きました");
    }
  }
}
