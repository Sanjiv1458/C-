using System;

namespace BankSystem
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
                throw new InvalidOperationException("Deposition executed");
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
            Console.WriteLine("|{0, =25}|{1, 25}|{2. 25}|{3, 25} | ", "FROM ACCOUNT", "TO ACCOUNT", "TRANSFER AMOUNT", "STATUS");
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
                throw new InvalidOperationException("Transfer previously Executed");
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


    class BankSystem
    {
        public enum MenuOption
        {
            Withdraw,
            Deposit,
            Transfer,
            Print,
            Quit
        }

        MenuOption ReadUserInput()
        {
            Console.WriteLine(" \n" + " \n" + "=================: Welcome to Bank :=================" + " \n");
            Console.WriteLine("=====================================================");
            Console.WriteLine("-> 1. Withdraw");
            Console.WriteLine("-> 2. Deposit");
            Console.WriteLine("-> 3. Transfer");
            Console.WriteLine("-> 4. Print");
            Console.WriteLine("-> 5. Quit");
            Console.WriteLine("=====================================================");

            Console.Write("Please Select your option: ");
            MenuOption option = new MenuOption();
            int result = Convert.ToInt32(Console.ReadLine());

            option = (MenuOption)result - 1;
            return option;
        }
        static void Print(Account account)
        {
            account.Print();
        }
        static void DoDeposit(Account account)
        {
            Console.Write("Please Enter the amount you want to deposit: ");
            decimal amount = Convert.ToInt32(Console.ReadLine());
            DepositTransaction transaction = new DepositTransaction(account, amount);
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException)
            {
                transaction.Print();
                return;
            }
            transaction.Print();
        }

        static void DoWithdraw(Account account)
        {
            Console.Write("Please Enter the amount you want to withdraw: ");
            decimal amount = Convert.ToInt32(Console.ReadLine());
            WithdrawTransaction withdraw = new WithdrawTransaction(account, amount);
            try
            {
                withdraw.Execute();
            }
            catch (InvalidOperationException)
            {
                withdraw.Print();
                return;
            }
            withdraw.Print();
        }

        static void Dotransfer(Account fromTransfer, Account toTransfer)
        {
            Console.Write("Please Enter the amount you want to transfer: ");
            decimal amount = Convert.ToInt32(Console.ReadLine());
            TransferTransaction transfer = new TransferTransaction(fromTransfer, toTransfer, amount);
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
            acc.Print();
            TransferTransaction transfer1 = new TransferTransaction(acc, acc1, 2000);
            acc.Print();
            acc1.Print();
            WithdrawTransaction withdraw = new WithdrawTransaction(acc2, 1000);
            acc2.Print();
            
            MenuOption option;
            BankSystem system = new BankSystem();

            do
            {
                option = system.ReadUserInput();
                switch (option)
                {
                    case MenuOption.Withdraw:
                        BankSystem.DoWithdraw(acc);
                        break;

                    case MenuOption.Deposit:
                        BankSystem.DoDeposit(acc);
                        break;

                    case MenuOption.Transfer:
                        BankSystem.Dotransfer(acc, acc2);
                        break;

                    case MenuOption.Print:
                        BankSystem.Print(acc);
                        break;

                    case MenuOption.Quit:
                        Console.WriteLine("Thanks for using!!!");
                        break;

                    default:
                        Console.WriteLine("Please enter the valid option!!!");
                        Console.Write("Please enter the option: ");
                        option = system.ReadUserInput();
                        break;
                }
            } while (option != MenuOption.Quit);
        }
    }
}