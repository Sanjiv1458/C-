using System;

namespace Project
{
    class carProgram
    {
        double efficiency = 0, fuel = 0, driven = 0;
        private const double CON_LTR = 0.25;
        private const double PRICE_LTR = 1.385;
        public carProgram(Double efficiency, Double fuel, Double driven)
        {
            this.efficiency = efficiency;
            this.fuel = fuel;
            this.driven = driven;
        }
        public double getFuel()
        {
            return this.fuel;
        }
        public double  getTotalMiles()
        {
            return this.driven;
        }
        public double setTotalMiles(double miles)
        {
            return this.fuel = miles;
        }
        public void printFuelCost()
        {
            double result = this.fuel * PRICE_LTR;
            Console.WriteLine("Fuel Cost: " + result.ToString("C"));
        }
        public void addFuel(double fuel)
        {
            this.fuel = this.fuel+ fuel;
            Console.WriteLine("Fuel after adding the fuel: " + this.fuel.ToString("C"));
        }
        public void calcCost(double fuel)
        {
            double result = fuel * PRICE_LTR;
            Console.WriteLine("Price of given quantity of fuel: " + result.ToString("C"));
        }
        public void convertToLitres(double gallon)
        {
            double result;
            result = gallon * CON_LTR;
            Console.WriteLine("Conversion of gallon to litres: " + result);
        }
        public void drive(double driven, double milege)
        {
            this.driven = driven;
            double liter1 = this.driven/milege;
            double liter2 = liter1 * CON_LTR;
            double price = liter2 * PRICE_LTR;
            Console.WriteLine("Car driven after updation: " + this.driven);
            Console.WriteLine("Fuel consumption by Car in gallon is: " + liter1);
            Console.WriteLine("Fuel consumption by Car in liters is: " + liter2);
            Console.WriteLine("Fuel price of consumed fuel: " + price.ToString("C"));
        }

        static void Main(string [] args)
        {
            carProgram car = new carProgram(120, 20, 40);
            car.setTotalMiles(10);
            car.addFuel(20);
            car.calcCost(50);
            car.convertToLitres(150);
            car.drive(170, 90);
        }
    }
}