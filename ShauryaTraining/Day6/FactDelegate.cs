using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day6
{
    public delegate int mydele1(int n);
    class FactDelegate
    {
        static int factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        static void Main(string[] args)
        {
            mydele1 d1 = FactDelegate.factorial;
            int r=d1(5);
            Console.WriteLine(r);
            
        }
    }
}
