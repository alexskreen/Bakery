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
    Program.Welcome();
  }
  public static void Welcome()
  {
    User newUser = new User(0, 0, 50);
    Bread userBread = new Bread(0, 0);
    Bread.HowManyLoaves(userBread);

    Pastry userPastry = new Pastry(0, 0);

    Pastry.HowManyPastries(userPastry);

    // Console.WriteLine("So I have " + userBread.Loaves + " loaves of bread");
    // Console.WriteLine("and " + userPastry.Pastries + " pastries");

    Program.IsThatCorrect(userBread, userPastry, newUser);
    Program.CashOrCard(newUser);
    Console.WriteLine("Can I help you with anything else today?");
    string anythingElse = Console.ReadLine();
    if (anythingElse.Contains("yeah") || anythingElse.Contains("sure") || anythingElse.Contains("yep") || anythingElse.Contains("yes"))
    {
      Program.Welcome();
    }
    else
    {
      Console.WriteLine("Have a wonderful day and come back soon!");
    }
  }

  public static void OrderConfirmation(Bread userBread, Pastry userPastry)
  {
    string checkOutResponse = Console.ReadLine();
    if (checkOutResponse.Contains("yeah") || checkOutResponse.Contains("sure") || checkOutResponse.Contains("yep") || checkOutResponse.Contains("yes"))
    {
      Console.WriteLine(userBread.Loaves + " loaves of bread and " + userPastry.Pastries + " pastries " + " comes out to  $" + (userBread.BreadCost + userPastry.PastryCost));
    }
  }

  public static void IsThatCorrect(Bread userBread, Pastry userPastry, User newUser)
  {
    newUser.Total = (userBread.BreadCost + userPastry.PastryCost);
    if (userBread.Loaves > 0 && userPastry.Pastries > 0)
    {
      Console.WriteLine("So I have " + userBread.Loaves + " loaves of bread");
      Console.WriteLine("and " + userPastry.Pastries + " pastries");
      Console.WriteLine("Is that correct?");
      Program.OrderConfirmation(userBread, userPastry);
    }
    else if (userBread.Loaves == 0 && userPastry.Pastries == 0)
    {
      Console.WriteLine("I'm sorry, it looks like your basket is empty. I can't check you out. Look around and see if there is anything that catches your eye.");
      Program.Welcome();
    }

    else if (userBread.Loaves == 0 && userPastry.Pastries > 0)
    {
      Console.WriteLine("So I have " + userPastry.Pastries + " pastries");
      Console.WriteLine("Is that correct?");
      Program.OrderConfirmation(userBread, userPastry);
      Console.WriteLine(userPastry.Pastries + " pasteries comes out to  $" + userPastry.PastryCost);
    }
    else if (userPastry.Pastries == 0 && userBread.Loaves > 0)
    {
      Console.WriteLine("So I have " + userBread.Loaves + " loaves of bread");
      Console.WriteLine("Is that correct?");
      Program.OrderConfirmation(userBread, userPastry);
      Console.WriteLine(userBread.Loaves + " loaves of bread comes out to  $" + newUser.Total);
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