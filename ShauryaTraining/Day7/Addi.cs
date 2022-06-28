using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day7
{
    public delegate int del3(int a, int b);
    class Addi
    {
        static int add(int a, int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            del3 ob = (a, b) =>
            {
                return a + b;
            };

            del3 ob2 = (a, b) => a + b;
            Console.WriteLine("Answer= "+ob2(8,9));

        }
    }
}
