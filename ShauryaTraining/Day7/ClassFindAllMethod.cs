using System;
using System.Collections.Generic;
using System.Text;


namespace ShauryaTraining.Day7
{
    class ClassFindAllMethod
    {

        static void Filter(List<int> lst, Predicate<int> p1)
        {
            foreach (int element in lst)
            {
                bool b = p1(element);
                if(b==true)
                    Console.WriteLine(element);
            }
        }
        static bool isEven(int a)
        {
            return a % 2 == 0;
        }

        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 23, 65, 43, 23, 98, 45, 69, 99 };
            l1.ForEach(a => Console.WriteLine(a));

            List<int> l3 = l1.FindAll((a) => a % 2 == 0);
            l3.ForEach(a => Console.WriteLine(a));
        }
    }
}
