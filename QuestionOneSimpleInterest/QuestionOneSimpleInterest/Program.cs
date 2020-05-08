using System;

namespace QuestionOneSimpleInterest
{   
    class Program
    {
        public delegate void InterestDel(decimal principal, int time, double rate);

        static void Main(string[] args)
        {
            Customer customerOne = new Customer("Matthew Andrew", 11, "54 Pe", 45000, 0.02, 5);
            Customer customerTwo = new Customer("Thomas Luke",24, "23 New York Estate", 150000, 0.06, 3);


            object[][] customers = {
                new object[]{customerOne.Name, customerOne.ID, customerOne.Address, customerOne.Principal, customerOne.Rate, customerOne.Time},
                new object[]{ customerTwo.Name, customerTwo.ID, customerTwo.Address, customerTwo.Principal, customerTwo.Rate, customerTwo.Time }
                };
            //syntax of a jagged array            
            for (int i = 0; i < customers.Length; i++)
            {
                Console.Write("customer({0}): ", i);

                for (int j = 0; j < customers[i].Length; j++)
                {
                   Console.Write("customer{0}{1}", customers[i][j], j == (customers[i].Length - 1) ? "" : " ");
                }
              Console.WriteLine();
            }
        }
       
        //These are the methods
        public static void SimpleInterest(decimal Principal, int Time, double Rate)
        {
            decimal simpleInterest = (Principal * (decimal)(Time * Rate)) / 100;
            string value = $"Simple interest is {simpleInterest:C}\n";
            Console.Write(value: value);
        }

        public static void CompoundInterest(decimal Principal, int Time, double Rate)
        {
            for (int i = 0; i <= Time; i++)
            {
                decimal compoundInterest = Principal * (decimal)(Math.Pow((1.0 + Rate), i));
                string value = $"Compound interest is {compoundInterest:C}\n";
                Console.Write(value: value);
            }
        }       
    }
}
