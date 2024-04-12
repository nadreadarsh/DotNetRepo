using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class Grade_Perc
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

            if (perc >= 90)
            {
                Console.WriteLine("A");
            }
            else if (perc >= 80)
            {
                Console.WriteLine("B");
            }
            else if (perc >= 70)
            {
                Console.WriteLine("C");
            }
            else if (perc >= 60)
            {
                Console.WriteLine("D");
            }
            else {
                Console.WriteLine("Fail");
            }
                
        }
    }
}
