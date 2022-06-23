using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraining.Assignment21jun
{
    interface Icecream
    {
        void eat();
    }

    interface Juice
    {
        void drink();
    }
    class Mastani:Icecream,Juice
    {
        public void eat()
        {
            global::System.Console.WriteLine("Ice Cream should be Eat");
        }
        public void drink()
        {
            global::System.Console.WriteLine("Juice Shold be Drink");
        }

    }
    class IcecreamPorlour
    {
        static void Main(string[] args)
        {
            Mastani m = new Mastani();
            m.drink();
            m.eat();
        }
    }
}
