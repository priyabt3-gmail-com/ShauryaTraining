using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
    class MultipleExce
    {
       

            static string nm, pass;
          static int id, sal;

        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter Name ");
                nm = Console.ReadLine();
                Console.WriteLine("Enter Pass ");
                pass = Console.ReadLine();
                Console.WriteLine("Enter ID ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Salary ");
                sal = int.Parse(Console.ReadLine());


            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }

        }


        }
    }
