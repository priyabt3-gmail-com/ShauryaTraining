using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Day2
{

    class MinBalanceException : SystemException
    {
        public MinBalanceException(string msg) : base(msg)
        {

        }
        public MinBalanceException()
        { 
        
        }


    }
    class Acctbal
    {
        static int acctbal=0;

        public int Balance
        {
            set
            {
                if (acctbal < 500)
                    throw new MinBalanceException("Insufficient Balance");
                acctbal = value;
                


            }
        }
        static void Main(string[] args)
        {
            Acctbal a = new Acctbal();
           
                try
                {
                
                    Console.WriteLine("Enter Acct Bal ");
                    a.Balance = int.Parse(Console.ReadLine());
                Console.WriteLine("Acct Bal "+acctbal);
                 

                }
                catch (MinBalanceException e)
                {

                    Console.WriteLine(e.Message);

                }
                
           

            

        }
    }
}
