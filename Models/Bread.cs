using System;
namespace Bakery.Bread
{
  public class Bread
  {
    public string Name { get; set; }
    public int Cost { get; set;}

    public Bread(string name, int cost)
    {
      Name = name;
      Cost = cost;
    }
  }
    public class Pastry
  {
    public string Name { get; set; }
    public int Cost { get; set;}

    public Bread(string name, int cost)
    {
      Name = name;
      Cost = cost;
    }
  }
}