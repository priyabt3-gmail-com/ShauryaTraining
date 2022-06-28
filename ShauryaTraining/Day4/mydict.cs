using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day4
{
    class Emp
    {
        int eid;
        string sname;
        int salary;

        public Emp(int eid, string sname, int salary)
        {
            this.eid = eid;
            this.sname = sname;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Eid:{eid} Sname:{sname} Salary:{salary}";
        }

        

        public override int GetHashCode()
        {
            return HashCode.Combine(eid, sname, salary);
        }
    }
        class mydict
        {

            static void Main(string[] args)
            {
            Dictionary<Emp, string> d1 = new Dictionary<Emp, string>();
            d1.Add(new Emp(1, "Amol", 90),"Shaurya");
            d1.Add(new Emp(1, "Amol", 90),"Shaurya");
                foreach (KeyValuePair<Emp, string> kv in d1)
                    Console.WriteLine(kv.Key + " " + kv.Value);
            }

        }
}








