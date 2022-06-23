using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
   
    abstract class Teacher
    {
       public int Tid;
       public string Tname;
       public int Mobileno;

      
        public abstract void salary();

        public Teacher()
        {
           
        }

       
    }



    // inheriting from abstract class
    
        

    
    class Hourlybased : Teacher
    { 
    int rate_pr_hr,hr;
    Hourlybased(int rate_pr_hr, int hr)
        {
            this.rate_pr_hr = rate_pr_hr;
            this.hr = hr;
        }
        public override void salary()
        {

            Console.WriteLine("Salary: 6 CTC");

        }
        void display()
        {
            Console.WriteLine("Teacher ID: ",Tid);
            Console.WriteLine("Mobile: ", Mobileno);
            Console.WriteLine("Name: ",Tname);


            Console.WriteLine("Rate per Hour: ");
            Console.WriteLine("Hour: ");
        }

        class Salarybased:Teacher
        {
            int sal;
            public override void salary()
            {

                Console.WriteLine("Salary: 6 CTC");

            }
            Salarybased(int sal)
            {
                this.sal = sal;
            }

            static void Main(string[] args)
            {
                // create an object Sal class
                Salarybased obj = new Salarybased(900000);
                obj.salary();
                Hourlybased h = new Hourlybased(700, 1);
                h.display();

                Console.ReadLine();
            }



        }

    }
}
