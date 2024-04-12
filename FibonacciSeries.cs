using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class FibonacciSeries
    {
        public void fibonacci() {
            int first = 0, second = 1, terms = 10, third;
           // Console.WriteLine(first+" , "+second);
            for (int i = 2; i < terms; i++)
            {
                third = first + second;
                Console.WriteLine(third+" ");
                first = second;
                second = third;
            }

        }
        static void Main(string[] args)
        {
            FibonacciSeries fs = new FibonacciSeries();
            fs.fibonacci();



        }
    }
}
