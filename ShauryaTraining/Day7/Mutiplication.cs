using System;
using System.Collections;
using System.Text;

namespace ShauryaTraining.Day7
{
    public delegate void del1(int a,int b);
    class Mutiplication
    {
        static void multiply(int a, int b)
        {
            Console.WriteLine("Product= "+(a*b));
        }
        static void Main(string[] args)
        {
            del1 d1 = delegate (int a, int b)
                  {
                      Console.WriteLine("anonyomous method" + (a + b));
                  };
            d1 += delegate (int a, int b)
              {
                  global::System.Console.WriteLine("anyno"+(a+b));
              };
            d1(10, 20);
        }
    }
}
