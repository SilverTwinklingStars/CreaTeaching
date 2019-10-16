using System;

namespace Composition
{
  internal class Animal : IAnimal
  {
    private readonly IDescription _description;
    private readonly IMovement _movement;
    private readonly IHunt _hunt;

    public Animal(IDescription description, IMovement movement, IHunt hunt)
    {
      _description = description;
      _movement = movement;
      _hunt = hunt;
    }

    public void Describe()
    {
      Describe(_description.Name);
    }

    public void Describe(string name)
    {
      Console.WriteLine($"We introduce you to : {name}");
      Console.WriteLine(_description.Describe());
    }

    public void Move()
    {
      Console.WriteLine("My movement:");
      Console.WriteLine(_movement.Move());
    }

    public void Hunt()
    {
      Console.WriteLine("When I am hungry:");
      Console.WriteLine(_hunt.Hunt());
    }
  }
}