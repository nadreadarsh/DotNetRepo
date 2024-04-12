using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class FirstProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
                int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine($"Addition of Numbers is {c}");



        }
    }
}
