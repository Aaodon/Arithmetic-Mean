using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Mean
{
    class Program
    {
        static void Main(string[] args)
        {
            // Codded by Aaodon©
            // Data Type Variable Name = Value;

            double number1, number2, number3, number4, number5;

            Console.Write("Enter the first number = ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number = ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number = ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number = ");
            number4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fifth number = ");
            number5 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);

            Console.WriteLine("********** Result of Arithmetic Mean **********");

            double arith;

            Console.WriteLine();
            arith = (number1 + number2 + number3 + number4 + number5) / 5;
            Console.Write("Result = " + arith);

            Console.Read();
        }
    }
}
