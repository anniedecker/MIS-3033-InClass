using System;

namespace Numbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            int num1, num2;
            Console.WriteLine("Please enter a number.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            num2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 100; i++)
                {
                    if (i % num1 == 0 && i % num2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
        }
    }
}
