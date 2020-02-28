using System;
using Bakery.Items;

class Program
{
  static void Main()
  {
  Console.WriteLine("Welcome to Alex's Bakery! The finest bakery in all the land!");
  Console.WriteLine("Prices: Bread: $5");
  Console.WriteLine("Prices: Pastry: $2");
  Console.WriteLine("You're in luck! We are running some great promotions today!");
  Console.WriteLine("Bread is buy 2 get 1 free!");
  Console.WriteLine("Pastries are 3 for $5!");
  Bread userBread = new Bread (0, 0);
  Bread.HowManyLoaves(userBread);

  Pastry userPastry = new Pastry (0, 0);

  // Console.WriteLine("userPastry.PastryCost: " + userPastry.PastryCost);

  Pastry.HowManyPastries(userPastry);

  Console.WriteLine("So I have " + userBread.Loaves + " loaves of bread");
  Console.WriteLine("and " + userPastry.Pastries + " pastries");

  Pastry.isThatCorrect();



  }
  public static void isThatCorrect()
  {
  Console.WriteLine("Is that correct?");
  string checkOutResponse = Console.ReadLine();
  if (checkOutResponse.Contains("yeah") || checkOutResponse.Contains("sure") || checkOutResponse.Contains("yep") || checkOutResponse.Contains("yes"))
  {
  Console.WriteLine(" ");
  }


    }
}