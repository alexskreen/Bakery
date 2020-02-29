using System;
namespace Bakery.Items
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
    string userBreadResponse = Console.ReadLine().ToLower();

    if (userBreadResponse.Contains("yeah") || userBreadResponse.Contains("sure") || userBreadResponse.Contains("yep") || userBreadResponse.Contains("yes"))
    {
    Console.WriteLine("How many loaves of bread would you like?");
    string stringHowManyLoaves = Console.ReadLine();
    // Console.WriteLine("You want " + stringHowManyLoaves + " loaves?");
    int howManyLoaves = int.Parse(stringHowManyLoaves);
    userBread.Loaves = (howManyLoaves);    
      if (userBread.Loaves %3 == 0)
      {
      int freeLoaves = (userBread.Loaves/3);
      userBread.BreadCost = ((userBread.Loaves - freeLoaves) * 5);
      // Console.WriteLine(userBread.BreadCost);
      // Console.WriteLine("userBread.BreadCost: " + userBread.BreadCost);
      // Console.WriteLine("userBread.Loaves: " + userBread.Loaves);
      }
      else
      {
      int freeLoaves = (userBread.Loaves/3);
      userBread.BreadCost = ((userBread.Loaves - freeLoaves) * 5);
      // Console.WriteLine("userBread.BreadCost: " + userBread.BreadCost);
      // Console.WriteLine("userBread.Loaves: " + userBread.Loaves);

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
    public static void HowManyPastries(Pastry userPastry)
    {
    Console.WriteLine("Would you like any pastries today?");
    string userPastryResponse = Console.ReadLine().ToLower();

    if (userPastryResponse.Contains("yeah") || userPastryResponse.Contains("sure") || userPastryResponse.Contains("yep") || userPastryResponse.Contains("yes"))
    {
    Console.WriteLine("How many pastries would you like?");
    string stringHowManyPastries = Console.ReadLine();
    // Console.WriteLine("You want " + stringHowManyPastries + " pastries?");
    int howManyPastries = int.Parse(stringHowManyPastries);
    userPastry.Pastries = (howManyPastries);    
      if (userPastry.Pastries %3 == 0)
      {
      int freePastries = (userPastry.Pastries/3);
      userPastry.PastryCost = ((userPastry.Pastries * 2) - freePastries);
      // Console.WriteLine(userPastry.PastryCost);
      // Console.WriteLine("userPastry.PastryCost: " + userPastry.PastryCost);
      // Console.WriteLine("userPastry.Pastries: " + userPastry.Pastries);
      }
      else
      {
      int freePastries = (userPastry.Pastries/3);
      userPastry.PastryCost = ((userPastry.Pastries * 2) - freePastries);
      // Console.WriteLine("userPastry.PastryCost: " + userPastry.PastryCost);
      // Console.WriteLine("userPastry.Pastries: " + userPastry.Pastries);
      }
    }
    // else
    // {
    //   Console.WriteLine("That's too bad, our Pastry is really good!");
    //   Console.WriteLine("Bread and Pastries are the only things we currently offer. It's a very odd bakery. Feel free to look around.");
    // }
    }
  }
}