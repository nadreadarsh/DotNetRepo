using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class GreatestNumber
    {
        public void number()
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 <= num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 >= num3 && num2 <= num3)
            {
                Console.WriteLine(num2);
            }
            else if(num3 >= num1 && num3 >=num2) {
                Console.WriteLine(num3);
            }
        
        
        }
        static void Main(string[] args)
        {
            GreatestNumber greater = new GreatestNumber();
            greater.number();
        }
    }
}
