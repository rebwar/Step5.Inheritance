using System;

namespace Step5.Inheritance.Interfaces
{
    public class BankMellatAccount : IBankAccount, IAccountType
    {
        public int Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public string GetAccountType()
        {
            return "Bank Mellat Account";
        }

        public void Deposite(int value)
        {
            Console.WriteLine($"Your Deposite:{value}");
        }

        public void Withdraw(int value)
        {
            Console.WriteLine($"Your WithDraw:{value}");
        }
    }
}
