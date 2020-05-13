namespace Shapes.Models
{
  public class Circle
  {
    public int Radius { get; set; }
    public Circle(int radius)
    {
      Radius = radius;
    }
    public int GetArea()
    {
      return 0;
    }

    //Math.Round(result, 2);
  }
}