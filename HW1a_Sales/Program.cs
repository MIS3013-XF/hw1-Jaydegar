// HW1a Sales Total

// Your Name: Jayde Garcia
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            double sum1;
            double sum2;
            double sum3;

            const double multiplier = 0.085;

            string num1AsString;
            string num2AsString;

            Console.WriteLine("What is the product name of the item you are purchasing?");
            string productname = Console.ReadLine();
            Console.WriteLine("How many football tickets do you want to buy?");
            num1AsString = Console.ReadLine();
            Console.WriteLine("What is the price for each football ticket?");
            num2AsString = Console.ReadLine();

            num1 = Convert.ToDouble(num1AsString);
            num2 = Convert.ToDouble(num2AsString);

            sum1 = num1 * num2;

            Console.WriteLine($"\n\tYour subtotal for your bill is ${sum1.ToString("N2")}. ");

            sum2 = sum1 * multiplier;
            Console.WriteLine($"\tYour sales tax for your bill is ${sum2.ToString("N2")}. ");

            sum3 = sum1 + sum2;

            Console.WriteLine($"\tYour total for your bill is ${sum3.ToString("N2")}. ");

            Console.ReadKey();
        }
    }
}
