using System;
using Bakery.Items;
using Bakery.Users;
using Bakery.Wheel;

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
    User newUser = new User(0, 0, 50);
    Bread userBread = new Bread(0, 0);
    Bread.HowManyLoaves(userBread);

    Pastry userPastry = new Pastry(0, 0);

    Pastry.HowManyPastries(userPastry);

    Console.WriteLine("So I have " + userBread.Loaves + " loaves of bread");
    Console.WriteLine("and " + userPastry.Pastries + " pastries");

    Program.IsThatCorrect(userBread, userPastry, newUser);
    Program.CashOrCard(newUser);
  }



  public static void IsThatCorrect(Bread userBread, Pastry userPastry, User newUser)
  {
    Console.WriteLine("Is that correct?");
    string checkOutResponse = Console.ReadLine();
    newUser.Total = (userBread.BreadCost + userPastry.PastryCost);
    if (checkOutResponse.Contains("yeah") || checkOutResponse.Contains("sure") || checkOutResponse.Contains("yep") || checkOutResponse.Contains("yes"))
    {
      if (userBread.Loaves > 0 && userPastry.Pastries > 0)
      {
        Console.WriteLine(userBread.Loaves + " loaves of bread and " + userPastry.Pastries + " pastries " + " comes out to  $" + (userBread.BreadCost + userPastry.PastryCost));
      }
      else if (userBread.Loaves == 0)
      {
        Console.WriteLine(userPastry.Pastries + " pasteries comes out to  $" + userPastry.PastryCost);
      }
      else if (userPastry.Pastries == 0)
      {
        Console.WriteLine(userBread.Loaves + " loaves of bread comes out to  $" + newUser.Total);
      }
    }
    else
    {
      Console.WriteLine("I'm sorry ");
      Program.Main();
    }
  }
  public static void CashOrCard(User newUser)
  {
    Console.WriteLine("Would you like to pay with cash or card?");
    string userPaymentResponse = Console.ReadLine().ToLower();
    if (userPaymentResponse.Contains("cash"))
    {
    User.UserBills(newUser);
    }
    else if (userPaymentResponse.Contains("card") || userPaymentResponse.Contains("card") || userPaymentResponse.Contains("debit") || userPaymentResponse.Contains("credit") || userPaymentResponse.Contains("plastic") || userPaymentResponse.Contains("amex") || userPaymentResponse.Contains("visa") || userPaymentResponse.Contains("mastercard"))
    {
      Console.WriteLine("Insert your card. DON'T SWIPE IT! IT'S 2020!");

      // This code is a loading bar for a card reader. I couldn't quite get it to work

      // ConsoleSpinner spinner = new ConsoleSpinner();
      // spinner.Delay = 300;
      // while (true)
      // {
      //   spinner.Turn(displayMsg: "Loading ", sequenceCode: 5);
      // }
    }
  }

}