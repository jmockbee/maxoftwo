﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxoftwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.Write("Enter a number: ");
                var number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter another number: ");
                var number2 = Convert.ToInt32(Console.ReadLine());

                var max = (number1 > number2) ? number1 : number2;
                Console.WriteLine("Max is " + max);
            
        }
    }
}
