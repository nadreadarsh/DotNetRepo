using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class SwapNumber
    {
        static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 20;
            int var3;


            Console.WriteLine("Before Swap "+var1);
            Console.WriteLine("Before Swap "+var2);

            var3 = var1;
            var1 = var2;
            var2 = var3;

            Console.WriteLine("After Swap " + var1);
            Console.WriteLine("After Swap " + var2);
            
        }
    }
}
