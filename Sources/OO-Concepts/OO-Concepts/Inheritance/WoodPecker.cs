using System;

namespace Inheritance
{
  internal class WoodPecker : Animal
  {
    public WoodPecker()
    {
    }

    public override string DefaultName { get; protected set; } = "woodpecker";

    public override void Describe(string name)
    {
      Console.WriteLine($"We introduce you to : {name}");
      Console.WriteLine("I have two legs and two wings. My fur is made of feathers. I lay eggs.");
    }

    public override void Hunt()
    {
      base.Hunt();
      Console.WriteLine("I pick around until a worm curiously shows his head and then I quickly grab it and eat it");
    }
  }
}