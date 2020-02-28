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
  }
}