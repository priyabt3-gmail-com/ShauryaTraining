using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day4
{
    class Stud
    {
        int sid;
        string sname;
        int percentage;

        public Stud(int sid, string sname, int percentage)
        {
            this.Sid = sid;
            this.Sname = sname;
            this.Percentage = percentage;
        }
        public override string ToString()
        {
            return $"Sid:{sid} Sname:{sname} Percetage:{percentage}";
        }

        public override bool Equals(object obj)
        {
            return obj is Stud stud &&
                   sid == stud.sid &&
                   sname == stud.sname &&
                   percentage == stud.percentage;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sid, sname, percentage);
        }

        public int Percentage { get => percentage; set => percentage = value; }
        public string Sname { get => sname; set => sname = value; }
        public int Sid { get => sid; set => sid = value; }
    }
        class Demolist
        {
            static void Main(string[] args)
            {
                List<Stud> lst = new List<Stud>();
                lst.Add(new Stud(101, "Priya", 89));
                lst.Add(new Stud(102, "Suraj", 86));
                lst.Add(new Stud(103, "Vijay", 78));
                lst.Add(new Stud(104, "Ramm", 68));

                foreach (Stud ob in lst)
                {
                    if (ob.Percentage > 80)
                        Console.WriteLine(ob);
                }

            }

        }
    }
    
            





