using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
  internal abstract class Animal : IAnimal
  {

    public virtual string DefaultName { get; protected set; } = "An animal";

    public void Describe()
    {
      Describe(DefaultName);
    }
    public abstract void Describe(string name);

    public virtual void Hunt()
    {
      Console.WriteLine("When I am hungry:");
    }

    public virtual void Move()
    {
      Console.WriteLine("My movement:");
    }
  }
}
