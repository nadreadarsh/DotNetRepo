using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class PercentageFiveSub
    {
        static void Main(string[] args)
        {
            int sub1 = 56;
            int sub2 = 75;
            int sub3 = 89;
            int sub4 = 67;
            int sub5 = 78;
            double perc;

            int total = sub1 + sub2 + sub3 + sub4 + sub5;
            perc = ((double)total / 500) * 100;
            Console.WriteLine("Percentage  of Five Subject is: " + perc.ToString("0") + "%");
            
        }
    }
}
