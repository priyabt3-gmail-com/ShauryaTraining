using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
    class Class1
    {
        public virtual void show()
        {
            Console.WriteLine("Super class show method");
        }
    }
    class Class2 : Class1
    {
        public override void show()

        {
            throw new InvalidOperationException();
            Console.WriteLine("Sub class override show method");
        }
    
    
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.show();
            Console.ReadKey();
        }
    }
}

