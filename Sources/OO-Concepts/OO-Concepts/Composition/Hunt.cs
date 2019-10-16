namespace Composition
{
  internal interface IHunt
  {
    string Hunt();
  }
  internal class WormHunt : IHunt
  {
    public string Hunt()
    {
      return "I pick around until a worm curiously shows his head and then I quickly grab it and eat it";
    }
  }

  internal class LiveStockHunt : IHunt
  {
    public string Hunt()
    {
      return "I sneak upon the weakest and slowest prey around and then quickly attack it and devour it";
    }
  }
}