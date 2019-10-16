namespace Composition
{
  internal interface IMovement
  {
    string Move();
  }

  internal class FlightMovement : IMovement
  {
    public string Move()
    {
      return "I flap my wings and fly away.";
    }
  }

  internal class SlitherMovement : IMovement
  {
    public string Move()
    {
      return "I twist and turn and push myself forward.";
    }
  }

  internal class RunMovement : IMovement
  {
    public string Move()
    {
      return "I stretch my legs and quickly gallop forward.";
    }
  }
}