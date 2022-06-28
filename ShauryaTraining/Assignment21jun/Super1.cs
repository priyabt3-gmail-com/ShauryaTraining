using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
    class Super1
    {
        public virtual void show()
        {
            Console.WriteLine("Super class show method");
        }
    }
    class Sub1 : Super1
    {
        public override void show()

        {
            throw new InvalidOperationException();
            Console.WriteLine("Sub class override show method");
        }
    
    
        static void Main(string[] args)
        {
            Sub1 obj = new Sub1();
            obj.show();
            Console.ReadKey();
        }
    }
}

