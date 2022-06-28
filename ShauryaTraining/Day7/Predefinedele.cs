using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day7
{
    class Predefinedele
    {
        static public int add(int a, float b,long c)
        {
            
                return (int)(a + b + c);
        }
        static void greet(string nm)
        {
            Console.WriteLine("Good Afternoon"+nm);
        }
        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, long, int> f1 =add;
            int ans = f1(10, 3.4f, 90l);
            Console.WriteLine("ADD "+ans);
            Action<string> f2 = greet;
            f2("\nPriya");
            Predicate<int> f3 = isEven;
            Console.WriteLine(f3(67));

        }
    }
}
