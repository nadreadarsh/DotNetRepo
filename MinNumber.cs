using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class MinNumber
    {
        static void Main(string[] args)
        {
            int[] arr = { 94, 57, 92, 56, 55 };
            int min = arr[0];
            for(int i = 1;i< arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
        }
        
    }
}
