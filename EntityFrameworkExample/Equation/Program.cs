using System;

namespace Equation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Equation e = new Equation();
            Console.WriteLine("Please enter a number.");
            e.Left = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second number.");
            e.Right = Convert.ToDouble(Console.ReadLine());

            
            Console.WriteLine($"The sum of the numbers is: " + e.Add());
            Console.WriteLine($"The difference of the numbers is: "+ e.Subtract());
            Console.WriteLine($"The product of the numbers is: " + e.Multiply());
            //Console.WriteLine(e.LeftToThePower());
            //Console.WriteLine(e.RightToThePower());
        }
    }
}
