using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day6
{
    public delegate void mydele(string msg, string nm);
    class DemoDel
    {
        static void greet(string msg, string nm)
        {
            Console.WriteLine("Welcome"+nm+","+msg);
        }
        static void Main(string[] args)
        {
            mydele d1 = DemoDel.greet;
            d1("Good Evening", " Priya");
        }
    }
}
