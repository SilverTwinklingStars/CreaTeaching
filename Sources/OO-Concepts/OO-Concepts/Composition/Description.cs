namespace Composition
{
  internal interface IDescription
  {
    string Name { get; }
    string Describe();
  }
  internal class BirdDescription : IDescription
  {
    public string Name => "bird";
    public string Describe()
    {
      return "I have two legs and two wings. My fur is made of feathers. I lay eggs.";
    }
  }

  public class AmphibianDescription : IDescription
  {
    public AmphibianDescription() : this("Amphibian") { }

    public AmphibianDescription(string name)
    {
      Name = name;
    }
    public string Name { get; }
    public string Describe()
    {
      return "I have short legs and move quicker when I'm in a warm environment and slower in a cold. My fur is made of scales. I lay eggs.";
    }
  }

  public class CarnivorMamalDescription : IDescription
  {
    public CarnivorMamalDescription() : this("carnivore") { }

    public CarnivorMamalDescription(string name)
    {
      Name = name;
    }
    public string Name { get; }
    public string Describe()
    {
      return "I like to eat meat and I use 4 legs to move around. My fur is made of hair. I give birth to living childs.";
    }
  }
}