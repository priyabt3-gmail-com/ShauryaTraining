﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day2
{
    class Nestedtycatch
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two no.");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                try
                {

                    Console.WriteLine("Sum = ", (a + b));
                    Console.WriteLine("Sum = ", (a / b));
                }
                catch (DivideByZeroException d)
                {
                    Console.WriteLine(d.Message);
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }
    }
}
