using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day3
{
    class StringCreationDemo
    {
        static void Main(string[] args)
        {
            string s = "Hello";
            string a = new String("Hello");
            string s2 = "Hello";

            Console.WriteLine($"{ s}    {a}         {s2}           ");

            Console.WriteLine($"{s.GetHashCode()}             {a.GetHashCode()}         {s2.GetHashCode()}        ");

            Console.WriteLine("/////////////////////");


            s = s + "c#";

            Console.WriteLine($"{s}   {a}      {s2}");

            Console.WriteLine($"{s.GetHashCode()}             {a.GetHashCode()}         {s2.GetHashCode()}        ");

        }
    }
}
