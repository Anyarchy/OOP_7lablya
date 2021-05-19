using System;

namespace OOP_7lablya
{
    class Program
    {
        public static void Main(string[] args)
        {
            Equation[] array = new Equation[3];
            array[0] = new Equation(4, 2, 3);
            array[1] = new Equation(2, -8, 2);
            array[2] = new Equation(3, 1, 4);
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    array[i].Function();
                    Console.WriteLine($"Result of equation[{i}]: {array[i].Result}");
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Result of equation[{i}]: Devision by zero ");
                }

                catch (ArgumentException)
                {
                    Console.WriteLine($"Result of equation[{i}]: Wrong arguments ");
                }
            }

        }
    }
}