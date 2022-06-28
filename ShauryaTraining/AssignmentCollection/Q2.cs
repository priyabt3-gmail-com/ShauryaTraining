using System;
using System.Collections;
using System.Text;

namespace ShauryaTraining.AssignmentCollection
{
    class Q2
    {
        static void Main(string[] args)
        {

        
            // create and initialize new ArrayList
            ArrayList mylist = new ArrayList();
            mylist.Add("Welcome");
            mylist.Add("to");
            mylist.Add("Think");
            mylist.Add("Quotient");
            mylist.Add("Pvt");
            mylist.Add("Ltd");

            
            Console.WriteLine("ArrayList before sort:");
            foreach (string i in mylist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Console.WriteLine("ArrayList after sort:");

            
            mylist.Sort();

           
            foreach (string i in mylist)
            {
                Console.WriteLine(i);
            }
        }
    }
}
