using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
    class Account
    {
        public long acctno, balance;
        public string custnm;

        Account()
        {
            acctno = 123456789;
            balance = 45000;
            custnm = "Priya Shinde";
            Console.WriteLine("I am in default Constructor");

        }
        Account(long actno1, long balance1, string custnm1)
        {
            acctno = actno1;
            balance = balance1;
            custnm = custnm1;

            Console.WriteLine("I am in Parameterized Constructor");
        }
        void depositeAmount()
        {
            Console.WriteLine("Enetr the Amount to be Deposit : ");
            int damt = int.Parse(Console.ReadLine());
            balance = balance + damt;
        }
        void withdrwalAmount()
        {
            Console.WriteLine("Enetr the Amount to be Withdrawal : ");
            int wamt = int.Parse(Console.ReadLine());
            balance = balance - wamt;
        }
        void checkBal()
        {
            Console.WriteLine("Available Balance is "+balance);
        }
        static void Main(string[] args)
        {
            Account a = new Account();
            Account b = new Account(123456789, 45000, "Priya Shinde");
            
            b.withdrwalAmount();
            b.depositeAmount();
            b.checkBal();
        }
    }
}
