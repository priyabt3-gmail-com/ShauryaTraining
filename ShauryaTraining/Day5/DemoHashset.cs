using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day5
{
    class DemoHashset
    {
        static void Main(string[] args)
        {
            HashSet<string> ht = new HashSet<string>();
            ht.Add("om");
            ht.Add("Priya");
            ht.Add("Om");
            foreach(string d in ht)
                Console.WriteLine(d);
        }
    }
}
