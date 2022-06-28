using System;
using System.Collections;
using System.Text;

namespace ShauryaTraining.AssignmentCollection
{
    class Q7
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two ");
            ht.Add(3,"Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");
            ht.Add(6, "Six");
            ht.Add(7, "Seven");
            ht.Add(8, "Eight");
            ht.Add(9, "Nine");
            ht.Add(10, "Ten");

            int[] a = new int[ht.Count];
            ht.Keys.CopyTo(a, 0);
            foreach (int d in a)
            {
                if (d % 3 == 0)
                    ht.Remove(d);
            }
        }
    }
}
