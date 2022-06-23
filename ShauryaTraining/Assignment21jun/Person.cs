using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
    class Person
    {
        int vid;
        string vname;
        Vehicle v;

        public int Vid
        {
            get;
            set;
        }
        public string Vname
        {
            get;
            set;
        }
        public Vehicle V
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            
            p.Vid = 101;
            p.Vname = "Priya";
           
            Vehicle r = new Vehicle();                                
                    p.v = r;
                    p.v.Vid = 102;
                    p.v.Vname = "Aarti";
            Console.WriteLine(" "+p.Vid+" "+p.Vname);
            Console.WriteLine(" " + p.v.Vid + " " + p.v.Vname);
        }
    }
    class Vehicle
    {
        int vid;
        string vname;
    public int Vid
        {
            get;
            set;
        }
        public string Vname
        {
            get;
            set;
        }

    
    
    }


}
