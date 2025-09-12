// HW1b Grade

// Your Name: Jayde Garcia
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            double num4;
            double num5;
            double num6;

            double sum1;

            string num1AsString;
            string num2AsString;
            string num3AsString;
            string num4AsString;
            string num5AsString;
            string num6AsString;

            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            num1AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for assignments?");
            num2AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for exam 1?");
            num3AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for exam 2?");
            num4AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for the exam 3?");
            num5AsString = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for then participation?");
            num6AsString = Console.ReadLine();

            num1 = Convert.ToDouble(num1AsString);
            num2 = Convert.ToDouble(num2AsString);
            num3 = Convert.ToDouble(num3AsString);
            num4 = Convert.ToDouble(num4AsString);
            num5 = Convert.ToDouble(num5AsString);
            num6 = Convert.ToDouble(num6AsString);


            sum1 = (num2/100 * .20) + (num3/100 * .15) + (num4/100 * .25) + (num5/100 * .25) + (num6/100 * .15);

            Console.WriteLine($"{firstname} {lastname} ({num1AsString}), your final grade is {sum1.ToString("p")} ");

            Console.ReadKey();

        }
    }
}
