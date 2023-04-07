using System;

namespace TestAccount
{
    class Account
    {
        decimal _balance;
        string _name;
        public Account(string name, decimal balance)
        {
            this._balance = balance;
            this._name = name;
        }

        public String getAccName()
        {
            return this._name;
        }
        public Decimal getAccBalance()
        {
            return this._balance;
        }
        public void Deposit(decimal amount)
        {
            this._balance = this._balance + amount;
        }
        public void Withdraw(decimal amount)
        {
            if (this._balance < amount || amount < 0)
            {  
                Console.WriteLine("Please enter valid amount!!!");
            }
            else
            {
                this._balance = this._balance - amount;
            }   
        }
        public void print()
        {
            Console.WriteLine("Name: " + acc.getAccName()+ "\nBalance: " + acc.getAccBalance());
        }
        static void Main(string[] args)
        {
            Account acc = new Account("Sanjiv", 50000);
            Console.WriteLine("Name: " + acc.getAccName()+ "\nBalance: " + acc.getAccBalance());
            acc.Deposit(20000);
            acc.print();
            acc.Withdraw(10000);
            acc.print();
        }
    }
}