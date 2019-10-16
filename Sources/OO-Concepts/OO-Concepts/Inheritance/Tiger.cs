using System;

namespace Inheritance
{
  internal class Tiger : IAnimal
  {
    public Tiger()
    {
    }

    public void Describe(string name)
    {
      Console.WriteLine($"We introduce you to : {name}");
      Console.WriteLine("I like to eat meat and I use 4 legs to move around. My fur is made of hair. I give birth to living childs.");
    }

    public void Describe()
    {
      Describe("tiger");
    }

    public void Hunt()
    {
      Console.WriteLine("I pick around until a worm curiously shows his head and then I quickly grab it and eat it");
    }

    public void Move()
    {
      Console.WriteLine("I stretch my legs and quickly gallop forward.");
    }
  }
}