using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public  class CompareString
    {
        static void Main(string[] args)
        {
            string n1 = "Adarsh";
            string n2 = "adarsh";
            if(n1 == n2)
            {
                Console.WriteLine("Same String");
            }
            else
            {
                Console.WriteLine("Different String");
            }
        }
    }
}
