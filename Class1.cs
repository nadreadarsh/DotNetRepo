﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetProject
{
    public class Pattern
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
