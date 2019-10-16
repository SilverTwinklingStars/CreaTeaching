using System;

namespace Inheritance
{
  internal class Snake : Animal
  {
    private readonly string _name = null;
    public Snake(string name)
    {
      _name = name;
    }

    public override string DefaultName  => _name ?? "woodpecker";

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

    public override void Move()
    {
      Console.WriteLine("I twist and turn and push myself forward.");
      base.Move();
    }
  }
}