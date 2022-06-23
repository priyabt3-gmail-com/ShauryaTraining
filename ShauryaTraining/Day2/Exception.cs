using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day2
{
    class Exception
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the no.");
                int n = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)

            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Wrong Input");
            }
            catch (NullReferenceException fe)
            {
                Console.WriteLine(fe.Message);
            }
            try
            {
                Console.WriteLine("Enter Name");
                string str = Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Wrong Input");
            }
        }
    }
}
