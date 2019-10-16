using System;

namespace Composition
{
  class Program
  {
    static void Main(string[] args)
    {
      var woodPecker = new Animal(new BirdDescription(), new FlightMovement(), new WormHunt());
      var snake = new Animal(new AmphibianDescription("Johnny"), new SlitherMovement(), new LiveStockHunt());
      var tiger = new Animal(new CarnivorMamalDescription(), new RunMovement(), new LiveStockHunt());

      HandleAnimal(woodPecker);
      HandleAnimal(snake);
      HandleAnimal(tiger);
    }

    static void HandleAnimal(IAnimal animal)
    {
      animal.Describe();
      animal.Move();
      animal.Hunt();
      Console.WriteLine();
    }
  }
}
