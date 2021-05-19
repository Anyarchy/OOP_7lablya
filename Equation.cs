using static System.Math;
using System;

namespace OOP_7lablya
{
    public class Equation
    {
        private double a, b, c;
        public double Result { get; set; }

        public Equation(double x1, double x2, double x3)
        {
            a = x1;
            b = x2;
            c = x3;
        }


        public void Function()
        {
            if (a * 2 + b / c == 0)
                throw new DivideByZeroException("Division by zero");
            if (b <= 1)
                throw new ArgumentException("Wrong arguments");
            Result = ((8 * Log10(b - 1) - c) / (2 * a + b / c));

        }
    }
}