// NetClient.cs

using System;
using BANKDUALLib;

class NetClient
{
   public static void Main()
   {
      Account2 acc;
      acc = new Account2();
      Console.WriteLine("balance = {0}", acc.Balance);
      acc.Withdraw(25);
      Console.WriteLine("balance = {0}", acc.Balance);
   }
}