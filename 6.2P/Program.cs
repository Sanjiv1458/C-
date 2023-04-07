using System;

namespace Bank
{
    class Account
    {
        string _name;
        decimal _balance;

        public string Name { get => _name; }
        public decimal Balance { get => _balance; }
        public Account(string name, decimal balance)
        {
            this._name = name;
            this._balance = balance;
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
        public void Print()
        {
            Console.WriteLine("========================================::Account Passbook::========================================");
            Console.WriteLine(new String('=', 100));
            Console.WriteLine("|{0, -50}|{1, 50}|", "Account Name", "Current Balance");
            Console.WriteLine(new String('=', 100));
            Console.WriteLine("|{0, -50}|{1, 50}|", Name, Balance.ToString("C"));
        }
    }
    class WithdrawTransaction
    {
        Account _account;
        decimal _amount;
        bool _executed;
        bool _success;
        bool _reversed;

        public bool Executed { get => _executed; }
        public bool Success { get => _success; }
        public bool Reversed { get => _reversed; }

        public WithdrawTransaction(Account account, decimal amount)
        {
            this._account = account;

            if (amount > 0)
            {
                this._amount = amount;
            }
            else if (amount < 0)
            {
                throw new InvalidOperationException("Money can't be negative" + "\nPlease Enter positive amount");
            }
            else if (amount > account.Balance)
            {
                throw new InvalidOperationException("Money Withdraw attempted but not succeed due to Insufficient Balance");
            }
        }

        public void Print()
        {
            Console.WriteLine(new String('=', 100));
            Console.WriteLine("|{0, -25}|{1, 25}|{2, 25}|{3, 25} | ", "Account Name", "Withdraw Amount", "Status", "Current Balance");
            Console.WriteLine(new String('=', 100));
            Console.Write("| {0, -25}|{1, 25}", _account.Name, _amount.ToString("C"));

            if (!_executed)
            {
                Console.Write("{0, 25}|", "Pending");
            }
            else if (_reversed)
            {
                Console.Write("{0, 25} |", "Withdraw reversed");
            }
            else if (_success)
            {
                Console.Write("{0, 25}|", "Withdraw complete");
            }
            else if (!_success)
            {
                Console.Write("{0, 25} |", "Invalid Withdraw");
            }
            Console.WriteLine("{0, 25} |", _account.Balance.ToString("C"));
            Console.WriteLine(new String('=', 100));
        }

        public void Execute()
        {
            if (_executed && _success)
            {
                throw new InvalidOperationException("Withdraw executed");
            }
            _executed = true;
            _success = _account.Withdraw(_amount);
            if (!_success)
            {
                _executed = false;
                throw new InvalidOperationException("Withdraw amount is not valid");
            }
        }

        public void Rollback()
        {
            if (_reversed)
            {
                throw new InvalidOperationException("Transaction already reversed");
            }
            else if (!_success)
            {
                throw new InvalidOperationException("Deduction not successfully executed , Nothing to rollback");
            }
            _reversed = _account.Deposit(_amount);
            if (!_reversed)
            {
                throw new InvalidOperationException("Insufficient funds to rollback");
            }
            _reversed = true;
        }
    }
    class DepositTransaction
    {
        Account _account;
        decimal _amount;
        bool _executed;
        bool _success;
        bool _reversed;

        public bool Executed { get => _executed; }
        public bool Success { get => _success; }
        public bool Reversed { get => _reversed; }

        public DepositTransaction(Account account, decimal amount)
        {
            this._account = account;

            if (amount > 0)
            {
                this._amount = amount;
            }
            else if (amount < 0)
            {
                throw new InvalidOperationException("Money can't be negative" + "\nPlease Enter positive amount");
            }
        }

        public void Print()
        {
            Console.WriteLine(new String('=', 100));
            Console.WriteLine("|{0, -25}|{1, 25}|{2, 25}|{3, 25} | ", "Account Name", "Deposition Amount", "Status", "Current Balance");
            Console.WriteLine(new String('=', 100));
            Console.Write("| (0, -25}|(1, 25|", _account.Name, _amount.ToString("C"));

            if (!_executed)
            {
                Console.Write("{0, 25}|", "Pending");
            }
            else if (_reversed)
            {
                Console.Write("{0, 25} |", "Deposition reversed");
            }
            else if (_success)
            {
                Console.Write("{0, 25}|", "Deposition complete");
            }
            else if (!_success)
            {
                Console.Write("{0, 25} |", "Invalid Deposition");
            }
            Console.WriteLine("{0, 25} |", _account.Balance.ToString("C"));
            Console.WriteLine(new String('=', 100));
        }

        public void Execute()
        {
            if (_executed && _success)
            {
                throw new InvalidOperationException("Deposition already executed");
            }
            _executed = true;
            _success = _account.Deposit(_amount);
            if (!_success)
            {
                _executed = false;
                throw new InvalidOperationException("Withdraw amount is not valid");
            }
        }

        public void Rollback()
        {
            if (_reversed)
            {
                throw new InvalidOperationException("Transaction already reversed");
            }
            else if (!_success)
            {
                throw new InvalidOperationException("Deposition not successfully executed , Nothing to rollback");
            }
            _reversed = _account.Withdraw(_amount);
            if (!_reversed)
            {
                throw new InvalidOperationException("Insufficient funds to rollback");
            }
            _reversed = true;
        }
    }

    class TransferTransaction
    {
        Account _fromAccount;
        Account _toAccount;
        decimal _amount;
        DepositTransaction _deposit;
        WithdrawTransaction _withdraw;
        bool _executed;
        bool _reversed;
        public bool Executed { get => _executed; }

        public bool Reversed { get => _reversed; }
        public bool Success { get => _deposit.Success && _withdraw.Success; }
        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            if (amount > 0)
            {
                this._amount = amount;
            }
            else if (amount < 0)
            {
                throw new InvalidOperationException("Amount can't be negative" + "\nPlease enter positive amount");
            }

            _withdraw = new WithdrawTransaction(_fromAccount, _amount);
            _deposit = new DepositTransaction(_toAccount, _amount);
        }
        public void Print()
        {
            Console.WriteLine(new String('=', 100));
            Console.WriteLine("|{0, =25}|{1, 25}|{2. 25}|{3, 25} | ", "Sender Account", "Reciever Account", "Transfered Amount", "Status");
            Console.WriteLine(new String('=', 100));
            Console.Write("| {0, =25}|{1, 25}|{2,25}", _fromAccount.Name, _toAccount.Name, _amount.ToString("C"));

            if (!_executed)
            {
                Console.Write("{0, 25}|", "Pending");
            }
            else if (_reversed)
            {
                Console.Write("{0, 25} |", "Transfer reversed");
            }
            else if (Success)
            {
                Console.Write("{0, 25}|", "Transfer complete");
            }
            else if (!Success)
            {
                Console.Write("{0, 25} |", "Invalid Transfer");
            }
            Console.WriteLine(new String('=', 100));
        }
        public void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Transfer already Executed");
            }
            _executed = true;
            try
            {
                _withdraw.Execute();
            }
            catch (InvalidOperationException ex)
            {
                throw new InvalidOperationException("Transfer failed due to " + ex.Message);
            }
            if (_withdraw.Success)
            {
                try
                {
                    _deposit.Execute();
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException("Withdraw can't be reversed due to " + ex.Message);
                }
            }
            Print();
            _deposit.Print();
            _withdraw.Print();
        }

        public void Rollback()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Transfer not Executed");
            }
            if (_reversed)
            {
                throw new InvalidOperationException("Transfer already rolled back");
            }
            if (Success)
            {
                try
                {
                    _deposit.Rollback();
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException("Failed to rollback deposit: " + ex.Message);
                }
                try
                {
                    _withdraw.Rollback();
                }
                catch (InvalidOperationException ex)
                {
                    throw new InvalidOperationException("Failed to rollback withdraw: " + ex.Message);
                }
            }
            _reversed = true;
        }
    }

    class Bank
        {
            List<Account> _accounts;
            public Bank()
            {
                _accounts = new List<Account>();
            }
            public void AddAccount(Account account)
            {
                _accounts.Add(account);
            }

            public Account GetAccount(string name)
            {
                Account result = _accounts.Find(account => account.Name == name);
                if(result != null)
                {
                return result;
                }
                else
                {
                    Console.WriteLine("Not found!!!");
                    return null;
                }
            }

            public void ExecuteTransaction(DepositTransaction transaction)
            {
                try
                {
                    transaction.Execute();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            public void ExecuteTransaction(WithdrawTransaction transaction)
            {
                try
                {
                    transaction.Execute();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            public void ExecuteTransaction(TransferTransaction transaction)
            {
                try
                {
                    transaction.Execute();
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }


    class BankSystem
    {
        public enum MenuOption
        {
            CreateAccount,
            Withdraw,
            Deposit,
            Transfer,
            Print,
            Quit
        }
        MenuOption ReadUserInput()
        {
            Console.WriteLine(" \n" + " \n" +"=================: Welcome to the Bank :=================" + " \n");
            Console.WriteLine("=====================================================");
            Console.WriteLine("-> 1. Create Account");
            Console.WriteLine("-> 2. Withdraw");
            Console.WriteLine("-> 3. Deposit");
            Console.WriteLine("-> 4. Transfer");
            Console.WriteLine("-> 5. Print");
            Console.WriteLine("-> 6. Quit");
            Console.WriteLine("=====================================================");
            Console.WriteLine("\n"+ "\n");
            Console.Write("Please Select your option: ");
            MenuOption option = new MenuOption();
            int result = Convert.ToInt32(Console.ReadLine());

            option = (MenuOption)result - 1;
            return option;
        }
        static void Print(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                account.Print();
            }
        }
        static Account FindAccount(Bank bank)
        {
            Account account;
            Console.Write("Please Enter the name to find account: ");
            string name = Console.ReadLine();
            account = bank.GetAccount(name);
            if (account == null)
            {
                Console.WriteLine("The account does not exist by this name!!!");
            }
            return account;
        }
        static void CreateAccount(Bank bank)
        {
            Console.Write("Please Enter account name: ");
            string name = Console.ReadLine();
            Console.Write("please Enter the balance: ");
            decimal balance = Convert.ToInt32(Console.ReadLine());
            bank.AddAccount(new Account(name, balance));
        }
        static void DoDeposit(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                Console.Write("Please Enter the amount you want to deposit: ");
                decimal amount = Convert.ToInt32(Console.ReadLine());
                DepositTransaction transaction = new DepositTransaction(account, amount);
                try
                {
                    bank.ExecuteTransaction(transaction);
                }
                catch (InvalidOperationException)
                {
                    transaction.Print();
                    return;
                }
                transaction.Print();
            }
            else
            {
                Console.WriteLine("Account does not exist in current context: ");
            }
        }

        static void DoWithdraw(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                Console.Write("Please Enter the amount you want to withdraw: ");
                decimal amount = Convert.ToInt32(Console.ReadLine());
                WithdrawTransaction withdraw = new WithdrawTransaction(account, amount);
                try
                {
                    bank.ExecuteTransaction(withdraw);
                }
                catch (InvalidOperationException)
                {
                    withdraw.Print();
                    return;
                }
                withdraw.Print();
            }
            else
            {
                Console.WriteLine("Account does not exist in current context!!!");
            }
        }

        static void Dotransfer(Bank bank)
        {
            Account fromAccount = FindAccount(bank);
            Account toAccount = FindAccount(bank);
            if(fromAccount != null)
            {
                if(toAccount!= null)
                {
                Console.Write("Please Enter the amount you want to transfer: ");
                decimal amount = Convert.ToInt32(Console.ReadLine());
                TransferTransaction transfer = new TransferTransaction(fromAccount, toAccount, amount);
                }
                else{
                    Console.WriteLine("Reciever Account does not exist");
                }
            }
            else{
                Console.WriteLine("Sender Account does not exist");
            }
        }

        static void Main(string[] args)
        {
            Account acc = new Account("Sanjiv", 100);
            Account acc1 = new Account("Prakash", 500);
            Account acc2 = new Account("Rajiv", 600);

            acc.Print();
            acc1.Print();
            acc2.Print();

            DepositTransaction deposit = new DepositTransaction(acc, 5000);
            acc.Print();
            TransferTransaction transfer = new TransferTransaction(acc, acc, 1000);
            TransferTransaction transfer1 = new TransferTransaction(acc, acc1, 2000);
            acc.Print();
            acc1.Print();
            WithdrawTransaction withdraw = new WithdrawTransaction(acc2, 1000);
            acc2.Print();
            MenuOption option;
            BankSystem system = new BankSystem();
            Bank bank = new Bank();

            do
            {
                option = system.ReadUserInput();
                switch (option)
                {
                    case MenuOption.CreateAccount:
                        BankSystem.CreateAccount(bank);
                        break;

                    case MenuOption.Withdraw:
                        BankSystem.DoWithdraw(bank);
                        break;

                    case MenuOption.Deposit:
                        BankSystem.DoDeposit(bank);
                        break;

                    case MenuOption.Transfer:
                        BankSystem.Dotransfer(bank);
                        break;

                    case MenuOption.Print:
                        BankSystem.Print(bank);
                        break;

                    case MenuOption.Quit:
                        Console.WriteLine("Thanks for using!!!");
                        break;

                    default:
                        Console.WriteLine("Please enter the valid option!!!");
                        Console.WriteLine("Please Enter the option: ");
                        option = system.ReadUserInput();
                        break;
                }
            } while (option != MenuOption.Quit);
        }
    }
}