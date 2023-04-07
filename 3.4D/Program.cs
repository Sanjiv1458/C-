using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Account
    {
        decimal _balance;
        string _name;

        public string Name {get => _name;}
        public decimal Balance{get => _balance;}

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
                Console.WriteLine("invalid input!!!");
            }
            else
            {
                this._balance = this._balance - amount;
            }
        }
    }

    class AccountSorter
    {
        static decimal Maxvalue(Account [] accounts)
        {
            return accounts.Max(acc => acc.Balance);
        }
        public static void Sort(Account[] accounts, int b)
        {
            List<Account>[] buckets = new List<Account>[b];
            for (int i = 0; i < b; i++)
            {
                buckets[i] = new List<Account>();
            }

            foreach (Account account in accounts)
            {
                decimal max = Maxvalue(accounts);
                int bucketChoice = ((int)(Math.Floor(buckets.Length * account.balance / Maxvalue)));
                if(bucketChoice == buckets.Length)
                {
                    bucketChoice -= 1;
                    buckets[bucketChoice].Add(account);
                }
                
            }

            Account[] BubbleSortList(List<Account> input)
            {
                Account temp;
                for (int i = 0; i < input.Count; i++)
                {
                    for (int j = 0; j < input.Count; j++)
                    {
                        if (input[i].getAccBalance() < input[j].getAccBalance())
                        {
                            temp = input[i];
                            input[i] = input[j];
                            input[j] = temp;
                        }
                    }
                }
                return input.ToArray();
            }

            for (int i = 0; i < b; i++)
            {
                Account[] temp = BubbleSortList(buckets[i]);
            }

            int idx = 0;
            for (int i = 0; i< buckets.Length; i++)
            {
                foreach(Account account in buckets[i])
                {
                    accounts[idx] = account;
                    idx++;
                }
            }
        }
    }

    class ListSorter
    {

        public static void Sort(List<Account> accounts, int b)
        {
            List<List<Account>> result = new List<List<Account>>();
            static void InitializeBuckets(List<List<Account>> buckets)
            {
                for (int i = 0; i < 10; i++)
                {
                    List<Account> a = new List<Account>();
                    buckets.Add(a);
                }
            }

            accounts.Sort();

            int GetBucketNumber(double value)
            {
                double val = value * b;
                int bucketNumber = (int)Math.Floor(val);
                return bucketNumber;
            }


            void InsertionSort(Account[] array)
            {
                int j;
                Account temp;

                for (int i = 1; i < array.Length; i++)
                {
                    j = i;
                    while (j > 0 && array[j].getAccBalance() < array[j - 1].getAccBalance())
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        j--;
                    }
                }
            }


            void Scatter(Account[] array, List<List<Account>> buckets)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int bucketNumber = GetBucketNumber(i);
                    buckets[bucketNumber].Add(accounts[i]);
                }
            }

            void BucketSort(Account[] array)
            {
                List<List<Account>> buckets = new List<List<Account>>();
                InitializeBuckets(buckets);

                Scatter(array, buckets);

                int i = 0;
                foreach (List<Account> bucket in buckets)
                {
                    Account[] arr = bucket.ToArray();
                    InsertionSort(arr);

                    foreach (Account d in arr)
                    {
                        array[i++] = d;
                    }
                }
            }
        }
        

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please Enter the size of Accounts you want to add: ");
            n = Convert.ToInt32(Console.ReadLine());
            Account[] accounts = new Account[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter the Balance: ");
                decimal balance = Convert.ToInt32(Console.ReadLine());
                accounts[i] = new Account(name, balance);
            }
            
            List<List<Account>> accountslist = new List<List<Account>>();

            AccountSorter.Sort(accounts, 5);
            ListSorter.Sort(accountslist, 5);

        }
    }
}