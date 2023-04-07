using System;

namespace Project
{
    class Account
    {
        public int rate = 10;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Balance { get; private set; }
        public Account(string firstName, string lastName, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public void DoWithdraw(int amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient fund");
            }
            else if (amount < 0)
            {
                throw new InvalidOperationException("Amount can't be negative!!!");
            }
            else
            {
                this.Balance = this.Balance - amount;
            }
        }

        public void DoDeposit(int amount)
        {
            if (amount < 0)
            {
                throw new InvalidOperationException("Amount can't be negative!!!");
            }
            else
            {
                this.Balance = this.Balance + amount;
            }
        }

        public void Loan()
        {
            Console.Write("Please enter the amount for loan: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount > 100000)
            {
                throw new ArgumentOutOfRangeException("We Cann't santion loan of greater 10 lacs");
            }
            Console.Write("Please enter the time period of loan: ");
            int time = Convert.ToInt32(Console.ReadLine());
            int Cal_Int = amount * rate * time / 100;
            Console.WriteLine("Interest: " + Cal_Int);
            if (amount < 0 || time < 0)
            {
                throw new InvalidOperationException("Amount or time can't be negative!!!");
            }
            else
            {
                this.Balance = this.Balance + amount;
            }
        }

        public void Emi(int months)
        {
            Console.Write("Please enter the amount, you want to Calculate as Emi amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int emi = amount / months;
            Console.WriteLine("Monthly intallment amount: " + emi);
        }

        public void Print()
        {
            try
            {
                string s = "Name: ";
                string first = s.Insert(6, FirstName);
                try
                {
                    s = s.Insert(15, LastName);
                }
                catch (OutOfMemoryException ex)
                {
                    Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
                }
                finally
                {
                    string second = s.Insert(15, LastName);
                    Console.WriteLine(s + first + second + " Balance: " + Balance);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
            }
            finally
            {
                Console.WriteLine("Name: " + FirstName + " " + LastName + " Balance: " + Balance);
            }
        }
    }

    class AccArray
    {
        public static void Array1(Account[] accounts, int n)
        {
            accounts = new Account[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter first name: ");
                string first = Console.ReadLine();
                Console.Write("Entet last name: ");
                string last = Console.ReadLine();
                Console.WriteLine("Enter Balance: ");
                int bal = Convert.ToInt32(Console.ReadLine());
                accounts[i] = new Account(first, last, bal);
            }

            for (int i = 0; i <= n; i++)
            {
                accounts[i].Print();
            }
        }

        public static void Array2()
        {
            Console.Write("Please Enter the size of Account array: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Account[] accounts = null;
            for (int i = 0; i < n; i++)
            {
                accounts[i] = new Account("sanjiv", "singh", 1000);
            }

            for (int i = 0; i < n; i++)
            {
                accounts[i].Print();
            }
        }
    }

    class program
    {

        static void Main(string[] args)
        {
            try
            {
                Account account = new Account("Sanjiv", "Kumar", 1000);
                account.DoWithdraw(1001);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
            }

            bool done = true;
            try
            {
                Account account = new Account("Sanjiv", "Kumar", 1000);
                Console.Write("please Enter the amount you want to add: ");
                string amount = Console.ReadLine();
                int deposit = Convert.ToInt32(amount);
                if (deposit > 0)
                {
                    account.DoDeposit(deposit);
                    Console.WriteLine("Status of deposition: " + Convert.ToChar(done));
                }
                Console.WriteLine("Amount has been added and balance is " + account.Balance);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
            }

            try
            {
                Account account = new Account("Sanjiv", "Kumar", 1000);
                Console.Write("please Enter the amount you want to withdraw: ");
                int withdraw = Convert.ToInt32(Console.ReadLine());
                account.DoWithdraw(withdraw);
                Console.WriteLine("Status of withdrawing: " + done);
                Console.WriteLine("Amount has been withdrawn and balance is " + account.Balance);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
                Console.WriteLine("Please enter only integer");
            }

            try
            {
                Account account = new Account("Sanjiv", "Kumar", 1000);
                account.Loan();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
            }

            try
            {
                Account account = new Account("Sanjiv", "Kumar", 1000);
                Console.Write("Please Enter the number of months to calculate Emi amount: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if ((n % 3) != 0)
                {
                    throw new ArgumentException("Emi month number should be multiple of 3");
                }
                account.Emi(n);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
            }

            try
            {
                Account[] accounts = new Account[5];
                AccArray.Array1(accounts, 5);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
            }

            try
            {
                AccArray.Array2();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("The following error detected: " + ex.GetType().ToString() + " with message \"" + ex.Message + "\"");
            }
        }
    }
}