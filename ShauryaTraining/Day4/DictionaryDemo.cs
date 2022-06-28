using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day4
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(101, "Priya");
            d1.Add(102, "Shinde");
            d1.Add(103, "Vijay");
            d1.Add(104, "Gauri");
            Console.WriteLine(d1[101]);//to get corresponding to key

            //replace
            d1[102] = "Sagar";

            foreach (KeyValuePair<int, string> kv in d1)
            {
                Console.WriteLine(kv.Key+"=>"+kv.Value);
            }

            Console.WriteLine(d1.ContainsKey(106));//existance of Key
            Console.WriteLine(d1.ContainsValue("Vijay"));
        }
    }
}
