using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class MaxNumber
    {
        static void Main(string[] args)
        {
            int[] arr = {94,56,90,53 };
            int large = arr[0];
            for (int i = 1; i < arr.Length; i++) {
                if ( arr[i] > large)
                {
                    large= arr[i];
                   
                }
               
            }
            Console.WriteLine(large);


        }
    }
}
