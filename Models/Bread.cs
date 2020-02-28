using System;
namespace Bakery.Bread
{
  public class Bread
  {
    public int BreadCost { get; set;}
    public int Loaves {get; set;}

    public Bread( int breadCost, int loaves)
    {
      BreadCost = breadCost;
      Loaves = loaves;
    }
    public static void HowManyLoaves(Bread userBread)
    {
    Console.WriteLine("Would you like any bread today?");
    string userBreadResponse = Console.ReadLine();

    if (userBreadResponse.Contains("yeah") || userBreadResponse.Contains("sure") || userBreadResponse.Contains("yep") || userBreadResponse.Contains("yes"))
    {
    Console.WriteLine("How many loaves of bread would you like?");
    string stringHowManyLoaves = Console.ReadLine();
    Console.WriteLine("You want " + stringHowManyLoaves + " loaves?");
    int howManyLoaves = int.Parse(stringHowManyLoaves);
    
      // if (userBread.BreadCost <= 2)
      // {
      // userBread.BreadCost = howManyLoaves * 5;
      // Console.WriteLine(userBread.BreadCost);
      // }
      if (howManyLoaves %3 == 0)
      {
      int freeLoaves = (howManyLoaves/3);
      userBread.BreadCost = ((howManyLoaves - freeLoaves) * 5);
      Console.WriteLine(userBread.BreadCost);
      }
      else
      {
      int freeLoaves = (howManyLoaves/3);
      userBread.BreadCost = ((howManyLoaves - freeLoaves) * 5);
      Console.WriteLine(userBread.BreadCost);
      }
    }
    else
    {
      Console.WriteLine("That's too bad, our bread is really good!");
    }



    }
  }
  
    public class Pastry
  {
    public int PastryCost { get; set;}
    public int Pastries { get; set; }

    public Pastry(int pastryCost, int pastries)
    {
      PastryCost = pastryCost;
      Pastries = pastries;

    }
  }
}