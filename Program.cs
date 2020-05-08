using System;

namespace WebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = 81;
            double Y = 81;
            
            if(X < 0 && Y < 0)
            {
                Console.WriteLine(Math.Sqrt(X) + " and " + Math.Sqrt(Y) + " You have entered negative values, Please enter positive digits");
            }
            else if(X < Y)
            {
                Console.WriteLine("Y with square root " + Math.Sqrt(Y) + " has a higher square root than the number X with square root " + Math.Sqrt(X));
            }
            else if(X > Y)
            {
                Console.WriteLine("X with square root " + Math.Sqrt(X) + " has a higher square root than the number Y with square root " + Math.Sqrt(Y));
            }
            else if(X == Y)
            {
                Console.WriteLine("You have entered digits of same Square root, Please enter digits of different Square root");
            }
        }
    }
}
