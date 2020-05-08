using System;

namespace Question3MulticastDelegate
{    
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> ArithmeticDelegate = Addition;
            Func<int, int, int> ArithmeticDelegate2 = Multiplication;

            Console.WriteLine("Multicast delegate program with two methods multiplication and addition\n");
            int num1, num2;

            Console.Write("Please enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter another number: ");
            num2 = int.Parse(Console.ReadLine());
           
            Console.WriteLine($"The sum of {num1} and {num2} is: {ArithmeticDelegate(num1, num2)}\n");
            Console.WriteLine($"The multiplication of {num1} and {num2} is: {ArithmeticDelegate2(num1, num2)}");
            Console.ReadLine();
        }
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static int Multiplication(int a, int b)
        {
            return a * b;
        }

    }
}
