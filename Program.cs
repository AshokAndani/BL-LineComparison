using System;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison");
            LenghtofLine();
        }
        public static void LenghtofLine()
        {
            Console.WriteLine("Enter the Values of First Line");

            Console.WriteLine("Enter First Point");
            Console.WriteLine("X1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("........................");

            Console.WriteLine("Enter Second Point");
            Console.WriteLine("X2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("........................");

            Console.WriteLine("Enter the Values of Second Line");

            Console.WriteLine("Enter First Point");
            Console.WriteLine("X3=");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y3=");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("........................");

            Console.WriteLine("Enter Second Point");
            Console.WriteLine("X4=");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y4=");
            double y4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("........................");

            double LenghtofLineOne = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Lenght of First Line is : {0}", LenghtofLineOne);
            Console.WriteLine("........................");
            double LenghtofLineTwo = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Lenght of Second Line is : {0}", LenghtofLineTwo);
            if (LenghtofLineOne.Equals(LenghtofLineTwo))
            {
                Console.WriteLine("First Line and Second Lines are Equal");
            }
            else
            {
                Console.WriteLine("First Line and Second Lines are not Equal");
            }
        }
    }
}
