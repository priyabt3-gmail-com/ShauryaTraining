using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day2
{
    class InvalidPasswordException:SystemException
    {
        public InvalidPasswordException(string msg) :base(msg)
        { 
        
        }
        

    }
    class Emp
    {

        static string nm,pass;

       

        public string Password
        {
            set {
                if (value.Length < 5)
                    throw new InvalidPasswordException("Invalid Input");
                pass = value;
            
            
            }
        }

        static void Main(string[] args)
         
        {
            Console.WriteLine("Enter name");
            nm = Console.ReadLine();
            Console.WriteLine("Enter Pass");
            pass = Console.ReadLine();

            Emp e1 = new Emp();
            try
            {
                e1.Password = " ";
            }
            catch (InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End Code");
            }
        }



    }
}
