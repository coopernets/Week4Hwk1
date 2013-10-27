using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskD
{
    class Program
    {
        static public double length = 0;
        static public double width = 0;
        static void Main(string[] args)
        {

            ConsoleKeyInfo ck;
            Console.WriteLine(" Rectangle Checker  ");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 | Area Check      ");
            Console.WriteLine("2 | Perimeter Check ");
            Console.WriteLine("3 | Exit            ");
            Console.WriteLine("--------------------");
            Console.WriteLine("Please Select: ");
            ck = Console.ReadKey(false);
            if (ck.Key == ConsoleKey.D1)
            {
                LengthWidthCheck();
                double area = AreaCheck(length, width);
                Console.WriteLine("The Area is: " +  area.ToString());
                Console.ReadLine();

            }
            else if (ck.Key == ConsoleKey.D2)
            {
                LengthWidthCheck();
                double perim = PerimCheck(length, width);
                Console.WriteLine("The Perimeter is: " + perim.ToString());
                Console.ReadLine();

            }
            else if (ck.Key == ConsoleKey.D3)
            {
                Environment.Exit(0);
            }
        }

        
        static double AreaCheck(double l, double w)
        {
            double result;
            result = l * w;
            return result;
        }
        static double PerimCheck(double l, double w)
        {
            double result;
            result = (l * 2) + (w * 2);
            return result;
        }
        static void LengthWidthCheck()
        {
            Console.Clear();
            Console.WriteLine("Please enter Length: ");
            length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Width: ");
            width = double.Parse(Console.ReadLine());
        }
    }
}
