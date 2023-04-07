using System;

namespace Project
{
    class Employee
    {
        private String name;
        private Double salary;
        public Employee(String name, Double salary)
        {
            this.salary = salary;
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        public String getSalary()
        {
            return this.salary.ToString("C");
        }
        public void raiseSalary()
        {
            double result;
            result = this.salary + this.salary * 0.04;
            Console.WriteLine("Raised salary: " + result.ToString("C"));
        }

        public void tax()
        {
            if(this.salary > 0 && this.salary < 18200)
            {
                Console.WriteLine("No Tax is applicable");
            }
            else if(this.salary > 18201 && this.salary < 37000)
            {
                double result;
                result = this.salary * 0.19;
                Console.WriteLine("Tax is " + result.ToString("C"));
            }
            else if(this.salary > 37001 && this.salary < 90000)
            {
                double result;
                result = this.salary * 0.325;
                Console.WriteLine("Tax is " + result.ToString("C"));
            }
            else if(this.salary > 90001 && this.salary < 180000)
            {
                double result;
                result = this.salary * 0.37;
                Console.WriteLine("Tax is" + result.ToString("C"));
            }
            else if(this.salary > 180000)
            {
                double result;
                result = this.salary * 0.45;
                Console.WriteLine("Tax is" + result.ToString("C"));
            }
        }

        static void Main(string [] args)
        {
            Employee emp = new Employee("Sanjiv", 60000);
            Console.WriteLine("Employee Name is " + emp.getName() + " and salary is " + emp.getSalary());
            emp.tax();
            emp.raiseSalary();
        }
    }
}