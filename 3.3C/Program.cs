using System;

namespace project
{
    class MyPolynomial
    {
        double[] _coeffs;
        public MyPolynomial(double[] coeffs)
        {
            this._coeffs = coeffs;
        }

        public int GetDegree()
        {
            return this._coeffs.Length - 1;
        }

        public override string ToString()
        {
            string term = " ";
            string variable = "x";
            string constant = _coeffs[0].ToString();


            for (int i = 0; i < _coeffs.Length; i++)
            {
                if (_coeffs[i] == 0)
                {
                    term += " ";
                }
                else if (i == (_coeffs.Length - 1))
                {
                    term += this._coeffs[i];
                }
                else if (i == (_coeffs.Length - 2))
                {
                    term += this._coeffs[i].ToString() + variable + "+";
                }
                else
                {
                    term += _coeffs[i].ToString() + variable + "^" + (this.GetDegree() - i) + "+";
                }
            }
            return term;
        }

        public void Display()
        {
            Console.WriteLine(this.ToString());
        }

        public Double Evaluate(double x)
        {
            double result = 0;
            for (int i = 1; i <= _coeffs.Length; i++)
            {
                result += _coeffs[i - 1] * Math.Pow(x, _coeffs.Length - i);
            }
            return result;
        }

        public MyPolynomial Add(MyPolynomial another)
        {
            int n = 0;
            int m = 0;

            double[] Add;

            if (_coeffs.Length > another._coeffs.Length)
            {
                n = _coeffs.Length;
                m = _coeffs.Length - another._coeffs.Length;
                Add = new double[n];

                for (int i = 0; i < _coeffs.Length; i++)
                {
                    Add[i] = _coeffs[i];
                }
                for (int i = 0; i < another._coeffs.Length; i++)
                {
                    Add[i+m] += another._coeffs[i];
                }
            }
            else
            {
                n = another._coeffs.Length;
                m = another._coeffs.Length - _coeffs.Length;
                Add = new double[n];
                for (int i = 0; i < another._coeffs.Length; i++)
                {
                    Add[i] = another._coeffs[i];
                }
                for (int i = 0; i < _coeffs.Length; i++)
                {
                    Add[i + m] += _coeffs[i];
                }
            }
            MyPolynomial polynomial = new MyPolynomial(Add);
            return polynomial;
        }

        public MyPolynomial Multiply(MyPolynomial another)
        {
            double[] product = new double[_coeffs.Length + another.GetDegree()];
            for (int i = 0; i < _coeffs.Length; i++)
            {
                for (int j = 0; j < another.GetDegree() + 1; j++)
                {
                    product[i + j] += _coeffs[i] * another._coeffs[j];
                }
            }
            MyPolynomial polynomial = new MyPolynomial(product);
            return polynomial;
        }

        static void Main(string[] args)
        {
            int n;
            Console.Write("Please enter the size of your first polynomial: ");
            n = Convert.ToInt32(Console.ReadLine());
            double[] coeffs1 = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Please enter the " + i + " coefficient: ");
                coeffs1[i] = Convert.ToInt32(Console.ReadLine());
            }

            MyPolynomial NewPolynomials = new MyPolynomial(coeffs1);
            Console.WriteLine("First Polynomial: " + NewPolynomials.ToString());

            Console.Write("Please enter the value you want Evaluate in Function: ");
            double value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Evaluation: " + NewPolynomials.Evaluate(value));

            int m;
            Console.Write("Please enter the size of your second polynomial: ");
            m = Convert.ToInt32(Console.ReadLine());
            double[] coeffs2 = new double[m];

            for (int i = 0; i < m; i++)
            {
                Console.Write("Please enter the " + i + " coefficient: ");
                coeffs2[i] = Convert.ToInt32(Console.ReadLine());
            }

            MyPolynomial another = new MyPolynomial(coeffs2);
            Console.WriteLine("Second polynomial: " + another.ToString());

            Console.WriteLine("Evaluation: " + another.Evaluate(value));

            Console.WriteLine("===============:|RESULT|:===============");

            Console.WriteLine("Addition: " + NewPolynomials.Add(another).ToString());

            Console.WriteLine("Multiplication: " + NewPolynomials.Multiply(another).ToString());
        }
    }
}