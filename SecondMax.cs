using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class SecondMax
    {
        static void Main(string[] args)
        {
            int[] arr = { 94, 57, 92 };
            int large = arr[0];
           

            int max = large;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > large)
                {
                    max = large;
                    large = arr[i]; 

                }else if (arr[i] < max && arr[i]!=large) { }
            }
            Console.WriteLine(max);
        }
    }
}
