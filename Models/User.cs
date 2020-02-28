using System;
namespace Bakery.Users
{
  public class User
  {
    public int Total { get; set;}
    public int Payment {get; set;}

    public int Wallet {get; set;}

    public User( int total, int payment, int wallet)
    {
      Total = total;
      Payment = payment;
      Wallet = wallet;
    }

    public static void UserBills(User newUser)
    {
      Console.WriteLine("Enter the bill you are paying with");
      Console.WriteLine("[$50] [$20] [$10] [$5] [$1]");
      string stringUserBillSelect = Console.ReadLine();
      newUser.Payment += int.Parse(stringUserBillSelect);
      Console.WriteLine("Do you have any other bills you'd like to use?");
      string userBillAnswer = Console.ReadLine();
      if (userBillAnswer.Contains("yeah") || userBillAnswer.Contains("sure") || userBillAnswer.Contains("yep") || userBillAnswer.Contains("yes"))
      {
      UserBills(newUser);
      }
      else
      {
      Console.WriteLine("You are paying with $" + newUser.Payment);
      if (newUser.Payment < newUser.Total)
      {
      int userShortBy = Math.Abs(newUser.Payment - newUser.Total);
      Console.WriteLine("I'm sorry, it looks like you are about $" + userShortBy);
      }
      }

  }
  }
}