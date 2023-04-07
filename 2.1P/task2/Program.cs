using System;

namespace Project
{
    class MobileProgram
    {
        class Mobile
        {
            private String accType, device, number;
            private double balance, wallet;

            private const double CALL_COST = 0.25;
            private const double TEXT_COST = 0.078;

            private const double SERVICE_PER = 0.1;
            public Mobile(String accType, String device, String number)
            {
                this.accType = accType;
                this.device = device;
                this.number = number;
                this.balance = 0.0;
                this.wallet = 1000;
            }
            public String getAccType()
            {
                return this.accType;
            }
            public String getDevice()
            {
                return this.device;
            }
            public String getNumber()
            {
                return this.number;
            }
            public String getBalance()
            {
                return this.balance.ToString("C");
            }
            public String getWallet()
            {
                return this.wallet.ToString("C");
            }
            public void setAccType(String accType)
            {
                this.accType = accType;
            }
            public void setDevice(String device)
            {
                this.device = device;
            }
            public void setNumber(String number)
            {
                this.number = number;
            }

            public void setBalance(double balance)
            {
                this.balance = balance;
            }

            public void setWallet(double wallet)
            {
                this.wallet = wallet;
            }
            public void addWallet(double amount)
            {
                this.wallet += amount;
                Console.WriteLine("Credit added successfully in wallet New balance "+ getWallet());
            }
            public void addCredit(double amount)
            {
                this.balance += amount;
                Console.WriteLine("Credit added successfully. New balance "+ getBalance());
            }
            public void makeCall(int minutes)
            {

                double cost = minutes * CALL_COST;
                this.balance -= cost;
                Console.WriteLine("Call made. New balance " + getBalance());
            }
            public void sendText(int numTexts)
            {
                double cost = numTexts * TEXT_COST;
                this.balance -= cost;
                Console.WriteLine("Text Sent. New balance " + getBalance());
            }
            public void makePayement(double money)
            {
                double cost = money * SERVICE_PER;
                this.wallet -= cost;
                Console.WriteLine("Made Payment. New balance " + getWallet());
            }
            static void Main(string[] args)
            {
                Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");

                Console.WriteLine("Account Type: " + jimMobile.getAccType() + "\nMobile Number: " + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: " + jimMobile.getBalance()+ "\nWallet: " + jimMobile.getWallet());

                jimMobile.setAccType("PAYG");
                jimMobile.setDevice("iPhone 65");
                jimMobile.setNumber("07713334466");
                jimMobile.setBalance(15.50);
                jimMobile.setWallet(1000);
                jimMobile.addWallet(200);
                jimMobile.addCredit (10.0); 
                jimMobile.makeCall(5);
                jimMobile.sendText (2);
                jimMobile.makePayement(80);

                Console.WriteLine("Account Type: " + jimMobile.getAccType() + "\nMobile Number: " + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: " + jimMobile.getBalance() + "\nWallet: " + jimMobile.getWallet());
            } 
        }
    } 
}