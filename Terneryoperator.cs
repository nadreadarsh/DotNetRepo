using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class Terneryoperator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = number > 0 ? "Positive" : (number < 0 ? "Negative" : "Zero");

            Console.WriteLine($"{number} is {result}");
        }
    }
}
