using System;


namespace Project
{
    class MyTime
    {
        private int hour;
        private int minute;
        private int second;
        public MyTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        void SetHour(int hour)
        {
            if (hour >= 0 && hour <= 23)
            {
                this.hour = hour;
            }
            else
            {
                Console.WriteLine("Please Enter between 0 to 23");
            }
        }

        void SetMinute(int minute)
        {
            if (minute >= 0 && minute <= 59)
            {
                this.minute = minute;
            }
            else
            {
                Console.WriteLine("Please Enter between 0 to 59");
            }
        }
        void SetSecond(int second)
        {
            if (second >= 0 && second <= 59)
            {
                this.second = second;
            }
            else
            {
                Console.WriteLine("Please Enter between 0 to 59");
            }
        }

        public int GetHour()
        {
            return this.hour;
        }
        public int GetMinute()
        {
            return this.minute;
        }
        public int GetSecond()
        {
            return this.second;
        }

        public override String ToString()
        {
            string result;
            result = this.hour + ":" + this.minute + ":" + this.second;
            return result;
        }

        MyTime NextSecond()
        {
            if (this.second >= 59)
            {
                this.second = 0;
                this.minute = this.minute + 1;
                if (this.minute >= 59)
                {
                    this.minute = 0;
                    this.hour = this.hour + 1;
                    if (this.hour >= 23)
                    {
                        this.hour = 0;
                    }
                    else
                    {
                        this.hour = this.hour + 1;
                    }
                }
                else
                {
                    this.minute = this.minute + 1;
                }
            }
            else
            {
                this.second = this.second + 1;
            }
            return this;
        }

        MyTime NextMinute()
        {
            if (this.minute >= 59)
            {
                this.minute = 0;
                this.hour++;
                if (this.hour >= 23)
                {
                    this.hour = 0;
                }
                else
                {
                    this.hour = this.hour + 1;
                }
            }
            else
            {
                this.minute = this.minute + 1;
            }
            return this;
        }

        MyTime NextHour()
        {
            if (this.hour >= 23)
            {
                this.hour = 0;
            }
            else
            {
                this.hour = this.hour + 1;
            }
            return this;
        }

        MyTime PreviousSecond()
        {
            if (this.second == 0)
            {
                this.second = 59;
                this.minute = this.minute - 1;
                if (this.minute == 0)
                {
                    this.minute = 59;
                    this.hour = this.hour - 1;
                    if (this.hour == 0)
                    {
                        this.hour = this.hour - 1;
                    }
                    else
                    {
                        this.hour = this.hour - 1;
                    }
                }
                else
                {
                    this.minute = this.minute - 1;
                }
            }
            else
            {
                this.second = this.second - 1;
            }
            return this;
        }

        MyTime PreviousMinute()
        {
            if (this.minute == 0)
            {
                this.minute = 59;
                this.hour = this.hour - 1;
                if (this.hour == 0)
                {
                    this.hour = 23;
                }
                else
                {
                    this.hour = this.hour - 1;
                }
            }
            else
            {
                this.minute = this.minute - 1;
            }
            return this;
        }

        MyTime PreviousHour()
        {
            if (this.hour == 0)
            {
                this.hour = 23;
            }
            else
            {
                this.hour = this.hour - 1;
            }
            return this;
        }

        static void Main(string[] args)
        {
            Console.Write("Please set hour time pin: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please set minute time pin: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please set second time pin: ");
            int second = Convert.ToInt32(Console.ReadLine());
            MyTime time = new MyTime(hour, minute, second);
            Console.WriteLine(" "+ "\n========:TIME:========");
            Console.WriteLine(time.ToString());
            Console.WriteLine(" ");
            Console.WriteLine("Validation!!!");
            Console.WriteLine(" ");
            time.SetHour(61);
            time.SetMinute(65);
            time.SetSecond(-45);
            int option;
            do
            {
                Console.WriteLine("\n1. next second" + "\n2. next minute" + "\n3. next hours" + "\n4. previous second" + "\n5. previous minute" + "\n6. previous hours" + "\n7. Print" + "\n8. Exit");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        time.NextSecond();
                        break;

                    case 2:
                        time.NextMinute();
                        break;

                    case 3:
                        time.NextHour();
                        break;

                    case 4:
                        time.PreviousSecond();
                        break;

                    case 5:
                        time.PreviousMinute();
                        break;

                    case 6:
                        time.PreviousHour();
                        break;

                    case 7:
                        Console.WriteLine(" "+ "\n========:TIME:========");
                        Console.WriteLine(time.ToString());
                        break;

                    case 8:
                        Console.WriteLine("Thanks");
                        break;
                }
            } while (option != 8);
        }
    }
}
