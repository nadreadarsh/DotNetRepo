using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            double area;
            double base1 = 4;
            double height = 6;

            area = (base1 * height) / 2;
            Console.WriteLine("Area Of Triangle is " + area);

        }
    }
}
