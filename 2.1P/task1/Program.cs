using System;

namespace Project
{
    class MobileProgram
    {
        class Mobile
        {
            private String accType, device, number;
            private double balance;

            private const double CALL_COST = 0.25;
            private const double TEXT_COST = 0.078;
            public Mobile(String accType, String device, String number)
            {
                this.accType = accType;
                this.device = device;
                this.number = number;
                this.balance = 0.0;
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
            static void Main(string[] args)
            {
                Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");

                Console.WriteLine("Account Type: " + jimMobile.getAccType() + "\nMobile Number: " + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance: " + jimMobile.getBalance());

                jimMobile.setAccType("PAYG");
                jimMobile.setDevice("iPhone 65");
                jimMobile.setNumber("07713334466");
                jimMobile.setBalance(15.50);
                jimMobile.addCredit (10.0); 
                jimMobile.makeCall(5);
                jimMobile.sendText (2);

                Console.WriteLine("Account Type: " + jimMobile.getAccType() + "\nMobile Number: " + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice() + "\nBalance" + jimMobile.getBalance());
            } 
        }
    } 
}