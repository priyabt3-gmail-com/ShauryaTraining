using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ShauryaTraining.Day3
{
    class NonGenricHashTable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", ".Net");
            ht.Add("002", "C#");
            ht.Add("003", "ASP.Net");
            ht.Add("004", 1);

            ICollection keys = ht.Keys;  //Getting Key Collection imp

            foreach (String k in keys)
            {
                Console.WriteLine(ht[k]);
            }
           
        }



    }

    }
