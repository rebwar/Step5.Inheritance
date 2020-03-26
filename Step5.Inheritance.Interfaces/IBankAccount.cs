namespace Step5.Inheritance.Interfaces
{
    interface IBankAccount
    {
        void Deposite(int value);
        void Withdraw(int value);
        int Balance { get; set; }
    }
}
