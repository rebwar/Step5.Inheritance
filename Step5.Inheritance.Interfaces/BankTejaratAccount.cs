using System;

namespace Step5.Inheritance.Interfaces
{
    public class BankTejaratAccount : IBankAccount, IAccountType
    {
        public int Balance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Deposite(int value)
        {
            throw new NotImplementedException();
        }

        public string GetAccountType()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int value)
        {
            throw new NotImplementedException();
        }
    }
}
