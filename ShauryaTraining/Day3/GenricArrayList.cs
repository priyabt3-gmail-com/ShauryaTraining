using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
namespace ShauryaTraining.Day3
{


    

    class GenricArrayList
    {
        static void Main(string[] args)
        {

            List<int> obj = new List<int>();

            obj.Add(100);
            obj.Add(200);
            obj.Add(7000);
            obj.Add(900);

            obj.Insert(0, 555);

            obj[2] = 22;
            // obj.Sort(); //it sort data low to high

            

            foreach(object s in obj)
            {
                Console.WriteLine(s);
            }
            





        }
    }
}
