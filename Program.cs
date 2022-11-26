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
            Console.WriteLine("Enter First Point");
            Console.Write("X1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("........................");
            Console.WriteLine("Enter Second Point");
            Console.Write("X2=");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("........................");
            double LenghtofLine = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.Write("Lenght of a Line is : {0}", LenghtofLine);
        }
    }
}
