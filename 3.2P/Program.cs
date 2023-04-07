using System;

namespace BankSystem
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
        public bool Deposit(decimal amount)
        {
            this._balance = this._balance + amount;
            return true;
        }
        public bool Withdraw(decimal amount)
        {
            if (this._balance < amount || amount < 0)
            {
                return false;
            }
            else
            { 
                this._balance = this._balance - amount;
                return true;
            }
        }

        public void DoWithdraw()
        {
            Console.Write("Please enter the amount you want to withdraw: ");
            decimal amount = Convert.ToInt32(Console.ReadLine());
            bool withdraw = Withdraw(amount);
            if(withdraw == true)
            {
                Console.WriteLine("Amount has been deducted");
            }
            else
            {
                Console.WriteLine("Amount has not been deducted");
            }
        }

        public void DoDeposit()
        {
            Console.Write("Please enter the amount you want to withdraw: ");
            decimal amount = Convert.ToInt32(Console.ReadLine());
            bool deposit = Withdraw(amount);
            if(deposit == true)
            {
                Console.WriteLine("Amount has been credited");
            }
            else
            {
                Console.WriteLine("Amount has not been credited");
            }
        }

        public enum MenuOption
        {
            Withdraw,
            Deposit,
            Print,
            Quit
        }

        MenuOption ReadUserInput()
        {
            Console.WriteLine("=================: Welcome to Bank :=================" + " \n");
            Console.WriteLine("=====================================================");
            Console.WriteLine("-> 1. Withdraw");
            Console.WriteLine("-> 2. Deposit");
            Console.WriteLine("-> 3. Print");
            Console.WriteLine("-> 4. Quit");
            Console.Write("Please Select your option: ");
            MenuOption option = new MenuOption();
            int result = Convert.ToInt32(Console.ReadLine());
            
            option = (MenuOption)result - 1;
            return option;
        }

        public void print()
        {
            Console.WriteLine("Name: " + this.getAccName() + "\nBalance: " + this.getAccBalance().ToString("C"));
        }

        static void Main(string[] args)
        {
            Account acc = new Account("Sanjiv", 50000);
            Console.WriteLine("Name: " + acc.getAccName() + "\nBalance: " + acc.getAccBalance().ToString("C"));
            MenuOption option;
            do
            {
                option = acc.ReadUserInput();
                switch (option)
                {
                    case MenuOption.Withdraw:
                        acc.DoWithdraw();
                        break;

                    case MenuOption.Deposit:
                        acc.DoDeposit();
                        break;

                    case MenuOption.Print:
                        acc.print();
                        break;

                    case MenuOption.Quit:
                        Console.WriteLine("Thanks for using!!!");
                        break;
                        
                    default:
                        Console.WriteLine("Please enter the valid option!!!");
                        option = acc.ReadUserInput();
                        break;
                }
            } while (option != MenuOption.Quit);
        }
    }
}