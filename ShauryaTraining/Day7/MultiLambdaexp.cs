using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day7
{
    public delegate void del2(int a, int b);
    class MultiLambdaexp
    {
        static void multiply(int a, int b)
        {
            Console.WriteLine("Product= " + (a * b));
        }
        static void Main(string[] args)
        {
           
            //lambda exper
            del2 d2 = (a, b) => Console.WriteLine("lambda" + (a + b));
            d2(10, 20);
        }

    }
}
