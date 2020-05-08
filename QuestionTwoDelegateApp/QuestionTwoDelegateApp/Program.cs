using System;


namespace QuestionTwoDelegateApp
{
    public delegate string MethodGroupConversion(string person);  
    class Program
    {   

        static void Main(string[] args)
        {
            //Func<string, string> GroupConversion = Program.Space;
            //MethodGroupConversion
            TestDelegate rev = new TestDelegate();//instance of the object class
                    
            MethodGroupConversion reverseDelegate1 = new MethodGroupConversion(rev.Reverse);
            MethodGroupConversion reverseDelegate2 = rev.Space;             

            string name = reverseDelegate1("Leonardo Thomas");
            string name1 = reverseDelegate2("Maximus");
            Console.WriteLine($"The reverse method: {name}\nThe space method: { name1}");
                      
        }       
      
    }
}
