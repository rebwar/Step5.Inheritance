using System;

namespace Step5.Inheritance.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            BankMellatAccount bankMellat = new BankMellatAccount();
            Console.WriteLine(bankMellat.GetAccountType());
            bankMellat.Withdraw(1200);
        }
    }
}
