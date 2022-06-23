using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.day1
{
   
        // Sealed class
        sealed class SealedClass
        {

            // Calling Function
            public int Add(int a, int b)
            {
                return a + b;
            }
        }

        class Program
        {

            // Main Method
            static void Main(string[] args)
            {

                // Creating an object of Sealed Class
                SealedClass slc = new SealedClass();

                // Performing Addition operation
                int total = slc.Add(6, 4);
                Console.WriteLine("Total = " + total.ToString());
            }
        }
    }

