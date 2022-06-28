using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ShauryaTraining.Day3
{
    class Class1
    {
        static void Main(string[] args)
        {
            SortedList<Stud, int> L = new SortedList<Stud, int>();

            L.Add(new Stud (01,"Ajinkya",99),100 );
            L.Add(new Stud(02, "Prasad",98), 99);
            L.Add(new Stud(03, "Omkar", 59), 98);
            L.Add(new Stud(04, "Sumit", 89), 96);

            foreach(KeyValuePair<Stud,int>  x in L)
            {
                Console.WriteLine(x.Key   +"   "+     x.Value);
            }

        }
    }
}
