using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public  class VoteEligibility
    {
        public void isEligible() {
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Eligible For Vote");
            }
            else {
                Console.WriteLine("Not Eligible For Vote");
            }
        }

        static void Main(string[] args)
        {
            VoteEligibility voter = new VoteEligibility(); 
            voter.isEligible();
        }
    }
}
