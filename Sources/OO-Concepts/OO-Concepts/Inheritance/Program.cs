using System;

namespace Inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      var woodPecker = new WoodPecker();
      var snake = new Snake("Johnny");
      var tiger = new Tiger();

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
