using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day5
{
    class MyStudsort:IComparer<Stud>
    {
        public int Compare(Stud x, Stud y)
        {
            return x.Sname.CompareTo(y.Sname);
        }
    }
    class DSS3
    {
        static void Main(string[] args)
        {
            SortedList<Stud, string> ss = new SortedList<Stud, string>(new MyStudsort());
            ss.Add(new Stud(1, "Ajinkya", 90), "c#");
            ss.Add(new Stud(2, "Riya", 90), "Java");
            ss.Add(new Stud(3, "Amey", 90), "c#");



        }
    }
}
